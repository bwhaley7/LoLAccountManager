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
        InputHandler ih = new InputHandler();
        RequestHandler rh = new RequestHandler();
        public AccountManager am = new AccountManager();
        public Accounts()
        {
            InitializeComponent();
        }

        private void accountView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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
            loadTable();
        }

        public void loadTable()
        {
            am.loadAccounts();
            bool dupe;
            if (am.Accounts != null)
            {
                foreach (Account ac in am.Accounts)
                {
                    dupe = false;
                    for (int row = 0; row < accountView.Rows.Count; row++)
                    {
                        if (accountView.Rows[row].Cells[0].Value != null && accountView.Rows[row].Cells[0].Value.Equals(ac.user))
                        {
                            dupe = true;
                        }
                    }
                    if (!dupe)
                        accountView.Rows.Add(ac.user, ac.pass, "NA", "NA");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            am.loadAccounts();
            am.saveToFile();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            am.loadAccounts();
            am.importAccounts();
        }
    }
}
