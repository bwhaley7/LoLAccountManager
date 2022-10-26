
namespace LoLAccountManager
{
    partial class Accounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.accountView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addAccount = new Guna.UI2.WinForms.Guna2Panel();
            this.passwordText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usernameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usernameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.addAccountButton = new Guna.UI2.WinForms.Guna2Button();
            this.loadFileButton = new Guna.UI2.WinForms.Guna2Button();
            this.saveAccountsButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountView)).BeginInit();
            this.addAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.accountView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.accountView.ColumnHeadersHeight = 15;
            this.accountView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.accountView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountName,
            this.accountPass,
            this.loginSend});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountView.DefaultCellStyle = dataGridViewCellStyle6;
            this.accountView.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.accountView.Location = new System.Drawing.Point(0, 0);
            this.accountView.Name = "accountView";
            this.accountView.RowHeadersVisible = false;
            this.accountView.Size = new System.Drawing.Size(600, 220);
            this.accountView.TabIndex = 0;
            this.accountView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.accountView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.accountView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.accountView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.accountView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.accountView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.accountView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.accountView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(24)))));
            this.accountView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.accountView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.accountView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.accountView.ThemeStyle.HeaderStyle.Height = 15;
            this.accountView.ThemeStyle.ReadOnly = false;
            this.accountView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.accountView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.accountView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.accountView.ThemeStyle.RowsStyle.Height = 22;
            this.accountView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.accountView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.accountView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountView_CellContentClick);
            // 
            // accountName
            // 
            this.accountName.HeaderText = "Account Name";
            this.accountName.Name = "accountName";
            // 
            // accountPass
            // 
            this.accountPass.HeaderText = "Account Password";
            this.accountPass.Name = "accountPass";
            // 
            // loginSend
            // 
            this.loginSend.HeaderText = "Login";
            this.loginSend.Name = "loginSend";
            this.loginSend.Text = "Login";
            // 
            // addAccount
            // 
            this.addAccount.Controls.Add(this.saveAccountsButton);
            this.addAccount.Controls.Add(this.loadFileButton);
            this.addAccount.Controls.Add(this.passwordText);
            this.addAccount.Controls.Add(this.guna2HtmlLabel2);
            this.addAccount.Controls.Add(this.usernameLabel);
            this.addAccount.Controls.Add(this.usernameText);
            this.addAccount.Controls.Add(this.addAccountButton);
            this.addAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAccount.Location = new System.Drawing.Point(0, 220);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(600, 202);
            this.addAccount.TabIndex = 1;
            // 
            // passwordText
            // 
            this.passwordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordText.DefaultText = "";
            this.passwordText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordText.Location = new System.Drawing.Point(69, 57);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '●';
            this.passwordText.PlaceholderText = "";
            this.passwordText.SelectedText = "";
            this.passwordText.Size = new System.Drawing.Size(154, 23);
            this.passwordText.TabIndex = 5;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(5, 57);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(58, 19);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(5, 23);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 19);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // usernameText
            // 
            this.usernameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameText.DefaultText = "";
            this.usernameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameText.Location = new System.Drawing.Point(70, 22);
            this.usernameText.Name = "usernameText";
            this.usernameText.PasswordChar = '\0';
            this.usernameText.PlaceholderText = "";
            this.usernameText.SelectedText = "";
            this.usernameText.Size = new System.Drawing.Size(154, 23);
            this.usernameText.TabIndex = 1;
            // 
            // addAccountButton
            // 
            this.addAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addAccountButton.ForeColor = System.Drawing.Color.White;
            this.addAccountButton.Location = new System.Drawing.Point(12, 109);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(119, 30);
            this.addAccountButton.TabIndex = 0;
            this.addAccountButton.Text = "Add Acount";
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // loadFileButton
            // 
            this.loadFileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadFileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loadFileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loadFileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loadFileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loadFileButton.ForeColor = System.Drawing.Color.White;
            this.loadFileButton.Location = new System.Drawing.Point(262, 109);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(119, 30);
            this.loadFileButton.TabIndex = 6;
            this.loadFileButton.Text = "Load";
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // saveAccountsButton
            // 
            this.saveAccountsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveAccountsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveAccountsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveAccountsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveAccountsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveAccountsButton.ForeColor = System.Drawing.Color.White;
            this.saveAccountsButton.Location = new System.Drawing.Point(137, 109);
            this.saveAccountsButton.Name = "saveAccountsButton";
            this.saveAccountsButton.Size = new System.Drawing.Size(119, 30);
            this.saveAccountsButton.TabIndex = 7;
            this.saveAccountsButton.Text = "Save";
            this.saveAccountsButton.Click += new System.EventHandler(this.saveAccountsButton_Click);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 422);
            this.Controls.Add(this.addAccount);
            this.Controls.Add(this.accountView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accounts";
            this.Text = "Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.accountView)).EndInit();
            this.addAccount.ResumeLayout(false);
            this.addAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView accountView;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountPass;
        private System.Windows.Forms.DataGridViewButtonColumn loginSend;
        private Guna.UI2.WinForms.Guna2Panel addAccount;
        private Guna.UI2.WinForms.Guna2TextBox passwordText;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel usernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameText;
        private Guna.UI2.WinForms.Guna2Button addAccountButton;
        private Guna.UI2.WinForms.Guna2Button loadFileButton;
        private Guna.UI2.WinForms.Guna2Button saveAccountsButton;
    }
}