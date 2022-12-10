using SuperSimpleTcp;
using System.Text;

namespace GSTestClient
{
    public partial class Form1 : Form
    {

        SimpleTcpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if(client.IsConnected)
            {
                if(!string.IsNullOrEmpty(tb_message.Text))
                {
                    client.Send(tb_message.Text);
                    tb_messageInfo.Text += $"Me : {tb_message.Text} {Environment.NewLine}";
                    tb_message.Text = string.Empty;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new(tb_serverIP.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            btn_send.Enabled = false;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                btn_send.Enabled = true;
                btn_connect.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                tb_messageInfo.Text += $"Server Disconnected . . . {Environment.NewLine}";
            });
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                tb_messageInfo.Text += $"Server : {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                tb_messageInfo.Text += $"Server Connected . . . {Environment.NewLine}";
            });

        }
    }
}

















