using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLAccountManager
{
    class InputHandler
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlag, int cButtons, int dwExtraInfo);

        public const int MOUSE_LEFTDOWN = 0x02;
        public const int MOUSE_LEFTUP = 0x04;

        public void moveMouseToUser()
        {
            Cursor.Position = new Point(120,550);
            mouse_event(MOUSE_LEFTDOWN, 0, 0);
            mouse_event(MOUSE_LEFTUP, 0, 0);
        }

        public void enterUsername(string user)
        {
            SendKeys.Send(user);
        }
    }
}
