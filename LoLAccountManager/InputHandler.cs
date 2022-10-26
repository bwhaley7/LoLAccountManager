using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLAccountManager
{
    class InputHandler
    {
        [DllImport("user32.dll",CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        internal static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public void moveMouseToUser()
        {
            Cursor.Position = new Point(141,255);
            doMouseClick();
        }

        public void doMouseClick()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public void doLogin(string user, string pass)
        {
            SendKeys.Send(user);
            SendKeys.Send("{Tab}");
            SendKeys.Send(pass);
            SendKeys.Send("{Enter}");
        }

        public void FocusProcess()
        {
            IntPtr hWnd;
            bool found = false;
            Process[] procRun = Process.GetProcesses();
            foreach (Process pr in procRun)
            {
                if(pr.ProcessName == "RiotClientUx")
                {
                    found = true;
                    hWnd = pr.MainWindowHandle;
                    ShowWindow(hWnd, 3);
                    SetForegroundWindow(hWnd);
                }
            }
            if(!found)
                MessageBox.Show("RiotClientUx process was not found. Please load client.", "Client not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
