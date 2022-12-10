namespace GSServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_connectedUser = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_serverIP = new System.Windows.Forms.TextBox();
            this.tb_messageInfo = new System.Windows.Forms.TextBox();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connected User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_connectedUser
            // 
            this.lb_connectedUser.FormattingEnabled = true;
            this.lb_connectedUser.ItemHeight = 20;
            this.lb_connectedUser.Location = new System.Drawing.Point(725, 88);
            this.lb_connectedUser.Name = "lb_connectedUser";
            this.lb_connectedUser.Size = new System.Drawing.Size(328, 464);
            this.lb_connectedUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_serverIP
            // 
            this.tb_serverIP.Location = new System.Drawing.Point(115, 41);
            this.tb_serverIP.Name = "tb_serverIP";
            this.tb_serverIP.Size = new System.Drawing.Size(529, 27);
            this.tb_serverIP.TabIndex = 2;
            this.tb_serverIP.Text = "127.0.0.1:9000";
            // 
            // tb_messageInfo
            // 
            this.tb_messageInfo.Location = new System.Drawing.Point(115, 104);
            this.tb_messageInfo.Multiline = true;
            this.tb_messageInfo.Name = "tb_messageInfo";
            this.tb_messageInfo.ReadOnly = true;
            this.tb_messageInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_messageInfo.Size = new System.Drawing.Size(529, 422);
            this.tb_messageInfo.TabIndex = 2;
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(115, 568);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(529, 27);
            this.tb_message.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(726, 572);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(151, 29);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(904, 572);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(149, 29);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Message :";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 687);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.tb_messageInfo);
            this.Controls.Add(this.tb_serverIP);
            this.Controls.Add(this.lb_connectedUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GS Server Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lb_connectedUser;
        private Label label2;
        private TextBox tb_serverIP;
        private TextBox tb_messageInfo;
        private TextBox tb_message;
        private Button btn_send;
        private Button btn_start;
        private Label label3;
    }
}