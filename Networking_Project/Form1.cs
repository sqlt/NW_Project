using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Networking_Project
{
    public partial class Form1 : Form
    {
        Socket sock;
        EndPoint localEnd, remoteEnd;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // sockets info
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //adding user IP 
            Local_IP_TextBox.Text = getLocalIPAddress();
            Remote_IP_TextBox.Text = getLocalIPAddress();
           
        }

        private string getLocalIPAddress()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ipadd in host.AddressList)
            {
                if (ipadd.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ipadd.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //binding sockets
                localEnd = new IPEndPoint(IPAddress.Parse(Local_IP_TextBox.Text),
                    Convert.ToInt32(Local_Port_TextBox.Text));
                sock.Bind(localEnd);

                //establishing connection to remote IP
                remoteEnd = new IPEndPoint(IPAddress.Parse(Remote_IP_TextBox.Text),
                    Convert.ToInt32(Remote_Port_TextBox.Text));
                sock.Connect(remoteEnd);

                //Listening to a port
                buffer = new byte[1500];
                sock.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None,
                    ref remoteEnd, new AsyncCallback(MessageCallBack), buffer);
                Connect_Button.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MessageCallBack(IAsyncResult async)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])async.AsyncState;
                ASCIIEncoding msgEncoding = new ASCIIEncoding();
                string receivedMessage = msgEncoding.GetString(receivedData);

                List_Message.Items.Add("Receiver: " + receivedMessage);
                buffer = new byte[1500];
                sock.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None,
                    ref remoteEnd, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            // converting message to byte array
            ASCIIEncoding msgsEncoding = new ASCIIEncoding();
            byte[] sendMessage = new byte[1500];
            sendMessage = msgsEncoding.GetBytes(Message_TextBox.Text);

            //Sending the message
            sock.Send(sendMessage);
            List_Message.Items.Add("Sender: " + Message_TextBox.Text);
            Message_TextBox.Text = "";
        }
    }
}
