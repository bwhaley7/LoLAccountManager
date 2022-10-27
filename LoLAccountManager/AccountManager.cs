using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLAccountManager
{
    public class AccountManager
    {
        public List<Account> Accounts = new List<Account>();

        public void addAccount(string user, string pass, string rank)
        {
            Accounts.Add(new Account(user, pass, rank));
            Console.WriteLine(Accounts.Count.ToString());
        }

        public void importAccounts()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse import files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                using (System.IO.StreamReader reader = new System.IO.StreamReader(filename))
                {
                    string user, pass, temp;
                    while (!reader.EndOfStream)
                    {
                        temp = reader.ReadLine();
                        user = temp.Split(':')[0];
                        pass = temp.Split(':')[1];
                        Accounts.Add(new Account(user, pass, "NA"));
                    }
                }
                saveToFile();
            }
        }

        public void loadAccounts()
        {
            Accounts = JsonFileUtils.JsonRead(Accounts, @"D:\LoLAccountManager\accountsraw.txt");
        }

        public void saveToFile()
        {
            JsonFileUtils.JsonWrite(Accounts, @"D:\LoLAccountManager\accountsraw.txt");
        }
    }
}
