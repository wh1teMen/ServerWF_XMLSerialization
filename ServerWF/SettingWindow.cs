using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerWF
{
    public class SettingWindow
    {
        static public void sizeWindow(Form1 form)
        {
            form.Width = 420;
            form.Height = 390;
            form.MinimumSize = form.MaximumSize = form.Size;

        }
    }
}
