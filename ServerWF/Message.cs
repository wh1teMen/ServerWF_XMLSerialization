using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Drawing;
using System.Windows.Forms;

namespace ServerWF
{
    [Serializable]
    public class Message
    {

        [XmlAttribute]
        public string text;
        [XmlAttribute]
        public int size;
        [XmlAttribute]
        public string color;
        [XmlAttribute]
        public string font;

        public Message() { }

        public Message(string text, int size,string font, string color)
        {
            this.text = text;
            this.size = size;
            this.color = color;
            this.font = font;
        }       
      
       public static void Deserealize(string xmlFile, TextBox tx)
        {
            using (StringReader stringReader = new StringReader(Listener.xmmml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Message));
                Message me = (Message)serializer.Deserialize(stringReader);
                tx.Clear();
                Color mycolor = Color.FromName(me.color.ToString());
                tx.ForeColor = mycolor;
                Font dn = new Font(me.font, me.size);
                tx.Font = dn;
                tx.Text += me.text.ToString();
            }
        }
    }
}
