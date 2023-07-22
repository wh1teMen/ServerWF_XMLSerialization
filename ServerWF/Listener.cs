using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ServerWF
{
   public class Listener
   {
       public static string xmmml;
        static Message objMessage=new Message();
        public Listener() { }
        public static  void SetListener(object _server,TextBox tx)
        {
           string xml=string.Empty;
            byte[] buffer_input = new byte[1024];
            while (true)
            {
                Socket ns = ((Server)_server)._socket.Accept();
                var currentTime = DateTime.Now.ToString("HH:mm:ss.fff");
                tx.Text += ("["+ns.RemoteEndPoint.ToString()+"]" + " " + currentTime+": ");
                ns.Send(Encoding.UTF8.GetBytes(currentTime));
                string text = string.Empty;
                var l = ns.Receive(buffer_input);
                text += "" + text;
                text += Encoding.UTF8.GetString(buffer_input, 0, l);
                xml = text;  
                xmmml = xml;
                Message.Deserealize(xmmml, tx);                
                ns.Shutdown(SocketShutdown.Both);
                ns.Close();
            }

        }
        
   }
}
