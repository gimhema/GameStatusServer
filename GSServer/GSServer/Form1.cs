using SuperSimpleTcp;
using System.Text;

namespace GSServer
{
    public partial class Form1 : Form
    {
        SimpleTcpServer server;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            server.Start();
            tb_messageInfo.Text += $"Starting . . . . . {Environment.NewLine}";
            btn_start.Enabled = false;
            btn_send.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_send.Enabled = false;
            server = new SimpleTcpServer(tb_serverIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tb_messageInfo.Text += $"{e.IpPort} : {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }


        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tb_messageInfo.Text += $"{e.IpPort} Disconnected {Environment.NewLine}";
                lb_connectedUser.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tb_messageInfo.Text += $"{e.IpPort} Connected {Environment.NewLine}";
                lb_connectedUser.Items.Add(e.IpPort);
            });
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(tb_message.Text) && lb_connectedUser.SelectedItem != null)
                {
                    server.Send(lb_connectedUser.SelectedItem.ToString(), tb_message.Text);
                    tb_messageInfo.Text += $"Server : {tb_message.Text}{Environment.NewLine}";
                    tb_message.Text = string.Empty;
                }
            }
        }
    }
}


















