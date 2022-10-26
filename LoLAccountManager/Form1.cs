using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLAccountManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Accounts acView = new Accounts();
            acView.TopLevel = false;
            switchViewPanel.Controls.Add(acView);
            acView.BringToFront();
            acView.Show();
        }

        private void loadClientButton_Click(object sender, EventArgs e)
        {
            Process[] procs = Process.GetProcessesByName("RiotClientServices");
            if (procs.Length == 0)
                Process.Start(@"E:\Riot Games\League of Legends\LeagueClient.exe");
            else
                MessageBox.Show("LeagueClient process already running!", "Cap", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
