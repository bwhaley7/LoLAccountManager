using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoLAccountManager
{
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void accountView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InputHandler ih = new InputHandler();
            ih.FocusProcess();
            Thread.Sleep(1000);
            ih.moveMouseToUser();
            Thread.Sleep(1000);
            ih.doLogin(accountView.Rows[e.RowIndex].Cells[0].Value.ToString(), accountView.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAccount ac = new AddAccount();
            ac.Show();
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            loadAccounts();
        }

        public void loadAccounts()
        {
            string filename = @"D:\LoLAccountManager\accounts.txt";
            string str, user, pass = "";
            bool dupe = false;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    dupe = false;
                    str = reader.ReadLine();
                    user = str.Split(':')[0];
                    pass = str.Split(':')[1];
                    for (int row = 0; row < accountView.Rows.Count; row++)
                    {
                        if (accountView.Rows[row].Cells[0].Value != null && accountView.Rows[row].Cells[0].Value.Equals(user))
                        {
                            dupe = true;
                        }
                    }
                    if (!dupe)
                        accountView.Rows.Add(user, pass);

                }
            }
        }
    }
}
