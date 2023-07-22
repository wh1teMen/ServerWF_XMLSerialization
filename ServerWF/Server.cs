using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerWF
{
    public class Server
    {
        IPAddress ip;
        IPEndPoint endPoint;
        Socket socket;
        public Server() { }        
        public Server(string ip, int port)
        {
            // Создание сокета 
            socket = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.IP);
            this.ip = IPAddress.Parse(ip);
            endPoint = new IPEndPoint(this.ip, port);
        }
        public Socket _socket { get { return socket; } }
        public EndPoint _endPoint { get { return endPoint; } }

        public static void GetIPv4(ComboBox box)
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip_addr in host.AddressList)
            {
                // Выводим только адреса ipV4
                if (ip_addr.AddressFamily == AddressFamily.InterNetwork)
                {
                   box.Items.Add(ip_addr.ToString());               
                }               
            }
            //добавляем стандартный ip
            box.Items.Add("127.0.0.1");

        }
    }
}
