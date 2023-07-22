using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace ServerWF
{
    public partial class Form1 : Form
    {        
        Server Refserver = null;
        public Form1()
        {
            InitializeComponent();
            Server.GetIPv4(comboBox_ip);
            SettingWindow.sizeWindow(this);
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            var listener=new Listener();
            if (this.Refserver != null) return;
            // Создание сокета 
            Socket s = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.IP);
            var ip = comboBox_ip.SelectedItem.ToString();
            var port = int.Parse(maskedTextBox_port.Text);
            var server = new Server(ip, port);
            server._socket.Bind(server._endPoint);
            server._socket.Listen(10);          
            label_con.Text = "Соединение установлено...";
            label_con.ForeColor = Color.Green;
            Refserver = server;
            Task.Run(() =>Listener.SetListener(server,textBox_msg));

        }    
    }
}
