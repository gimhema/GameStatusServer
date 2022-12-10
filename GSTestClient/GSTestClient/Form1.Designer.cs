namespace GSTestClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_serverIP = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.tb_messageInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_connectedUser = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(709, 545);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(125, 29);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_serverIP
            // 
            this.tb_serverIP.Location = new System.Drawing.Point(102, 69);
            this.tb_serverIP.Name = "tb_serverIP";
            this.tb_serverIP.Size = new System.Drawing.Size(564, 27);
            this.tb_serverIP.TabIndex = 2;
            this.tb_serverIP.Text = "127.0.0.1:9000";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(854, 545);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(128, 29);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(102, 547);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(564, 27);
            this.tb_message.TabIndex = 2;
            // 
            // tb_messageInfo
            // 
            this.tb_messageInfo.Location = new System.Drawing.Point(102, 127);
            this.tb_messageInfo.Multiline = true;
            this.tb_messageInfo.Name = "tb_messageInfo";
            this.tb_messageInfo.ReadOnly = true;
            this.tb_messageInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_messageInfo.Size = new System.Drawing.Size(564, 384);
            this.tb_messageInfo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connected User";
            // 
            // lb_connectedUser
            // 
            this.lb_connectedUser.FormattingEnabled = true;
            this.lb_connectedUser.ItemHeight = 20;
            this.lb_connectedUser.Location = new System.Drawing.Point(696, 129);
            this.lb_connectedUser.Name = "lb_connectedUser";
            this.lb_connectedUser.Size = new System.Drawing.Size(304, 384);
            this.lb_connectedUser.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Message :";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 622);
            this.Controls.Add(this.lb_connectedUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_messageInfo);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.tb_serverIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_send);
            this.Name = "Form1";
            this.Text = "GS Test Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_send;
        private Label label1;
        private TextBox tb_serverIP;
        private Button btn_connect;
        private TextBox tb_message;
        private TextBox tb_messageInfo;
        private Label label2;
        private ListBox lb_connectedUser;
        private Label label3;
    }
}