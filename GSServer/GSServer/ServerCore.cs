using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSimpleTcp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GSServer
{
    public class ServerCore
    {
        // 일단 지금은Set 컨테이너로 IP로만 관리
        // 추후 수정 방향 : 키/맵 컨테이너를 사용하여 <ID, UserInfo>로 유저 정보 관리
        // UserInfo에는 닉네임, IP주소 등이 사용됨
        HashSet<string> clients = new HashSet<string>();

        public SimpleTcpServer server;
        public ServerCore(string serverIP)
        {
            // Constructor
            InitializeServerCore(serverIP);
        }

        // Server Setting
        public void InitializeServerCore(string serverIP)
        {
            server = new SimpleTcpServer(serverIP);
        }

        public void ServerCoreStart()
        {
            server.Start();
        }


        // Managing Command -> CommandManager로 분리
        public void CallCoreMethodByCommand(string msg)
        {
            // 나중에 Function맵으로 관리.. 찾아볼수있다면
            string cmd = ParsingCommand(msg);

            switch(cmd)
            {

            }
        }

        public string ParsingCommand(string target)
        {
            // 메세지를 받으면 가장 먼저 호출되는 함수
            // 커맨드만 별도로 파싱한다.
            return "";
        }




        // Managing User -> 나중에 UserManager로 분리
        public void AddUser(string userIP)
        {
            clients.Add(userIP);
        }

        public void RemoveUser(string userIP)
        {
            clients.Remove(userIP);
        }

        public string GetUserIP()
        {
            return "";
        }

        // Chatting -> 나중에 MessageManager로 분리

        public string SendToMessage(string targetIP, string msg)
        {
            string send_result = "";

            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(targetIP) && !string.IsNullOrEmpty(msg))
                {
                    server.Send(targetIP, msg);
                    send_result = $"{msg}{Environment.NewLine}";
                }
            }

            return send_result;
        }

        public void SendToAllClients(string msg)
        {
            // 접속중인 모든 클라이언트에게 채팅을 보낸다.
            foreach (string clientIP in clients)
            {
                SendToMessage(clientIP, msg);
            }
        }

        public void SendWisdomToTarget(string callIP, string targetIP, string wisdomMSG)
        {
            // 클라이언트간 귓속말 채팅이다.
            // 클라이언트가 귓속말을 요청한 유저가 존재하는지 검사하는 로직 필요
            string wisdom = callIP + "'s Wisdom : " + wisdomMSG;
            SendToMessage(targetIP, wisdom);
        }

        public void SendMsgToClient(string targetIP, string msg)
        {
            // 서버가 단일 클라이언트에게 메세지를 보낼때 사용한다.
            string serverMSG = "Server : " + msg;
            SendToMessage(targetIP, serverMSG);
        }





    }
}
