namespace Networking_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Local_Port_TextBox = new System.Windows.Forms.TextBox();
            this.Local_IP_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Remote_Port_TextBox = new System.Windows.Forms.TextBox();
            this.Remote_IP_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.Message_TextBox = new System.Windows.Forms.TextBox();
            this.List_Message = new System.Windows.Forms.ListBox();
            this.Send_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Local_Port_TextBox);
            this.groupBox1.Controls.Add(this.Local_IP_TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(67, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MyBox";
            // 
            // Local_Port_TextBox
            // 
            this.Local_Port_TextBox.Location = new System.Drawing.Point(72, 44);
            this.Local_Port_TextBox.Name = "Local_Port_TextBox";
            this.Local_Port_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Local_Port_TextBox.TabIndex = 3;
            // 
            // Local_IP_TextBox
            // 
            this.Local_IP_TextBox.Location = new System.Drawing.Point(72, 20);
            this.Local_IP_TextBox.Name = "Local_IP_TextBox";
            this.Local_IP_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Local_IP_TextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Remote_Port_TextBox);
            this.groupBox2.Controls.Add(this.Remote_IP_TextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(67, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OtherBox";
            // 
            // Remote_Port_TextBox
            // 
            this.Remote_Port_TextBox.Location = new System.Drawing.Point(83, 44);
            this.Remote_Port_TextBox.Name = "Remote_Port_TextBox";
            this.Remote_Port_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Remote_Port_TextBox.TabIndex = 3;
            // 
            // Remote_IP_TextBox
            // 
            this.Remote_IP_TextBox.Location = new System.Drawing.Point(83, 20);
            this.Remote_IP_TextBox.Name = "Remote_IP_TextBox";
            this.Remote_IP_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Remote_IP_TextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP Address";
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(67, 279);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(200, 23);
            this.Connect_Button.TabIndex = 2;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Message_TextBox
            // 
            this.Message_TextBox.Location = new System.Drawing.Point(67, 345);
            this.Message_TextBox.Name = "Message_TextBox";
            this.Message_TextBox.Size = new System.Drawing.Size(555, 20);
            this.Message_TextBox.TabIndex = 3;
            // 
            // List_Message
            // 
            this.List_Message.FormattingEnabled = true;
            this.List_Message.Location = new System.Drawing.Point(285, 25);
            this.List_Message.Name = "List_Message";
            this.List_Message.Size = new System.Drawing.Size(418, 277);
            this.List_Message.TabIndex = 4;
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(628, 345);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Button.TabIndex = 5;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 419);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.List_Message);
            this.Controls.Add(this.Message_TextBox);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Chat Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Local_Port_TextBox;
        private System.Windows.Forms.TextBox Local_IP_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Remote_Port_TextBox;
        private System.Windows.Forms.TextBox Remote_IP_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.TextBox Message_TextBox;
        private System.Windows.Forms.ListBox List_Message;
        private System.Windows.Forms.Button Send_Button;
    }
}

