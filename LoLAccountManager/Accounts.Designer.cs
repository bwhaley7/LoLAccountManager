
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.accountView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addAccount = new Guna.UI2.WinForms.Guna2Panel();
            this.loadFileButton = new Guna.UI2.WinForms.Guna2Button();
            this.addAccountButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountView)).BeginInit();
            this.addAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(144)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.accountView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.accountView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.accountView.ColumnHeadersHeight = 22;
            this.accountView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.accountView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountName,
            this.passwordColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountView.DefaultCellStyle = dataGridViewCellStyle3;
            this.accountView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            this.accountView.Location = new System.Drawing.Point(0, 0);
            this.accountView.Name = "accountView";
            this.accountView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(144)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.accountView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.accountView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            this.accountView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            this.accountView.Size = new System.Drawing.Size(600, 422);
            this.accountView.TabIndex = 0;
            this.accountView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            this.accountView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.accountView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.accountView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(144)))), ((int)(((byte)(59)))));
            this.accountView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.accountView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            this.accountView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            this.accountView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(24)))));
            this.accountView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.accountView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            this.accountView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.accountView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.accountView.ThemeStyle.HeaderStyle.Height = 22;
            this.accountView.ThemeStyle.ReadOnly = false;
            this.accountView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            this.accountView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.accountView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            this.accountView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.accountView.ThemeStyle.RowsStyle.Height = 22;
            this.accountView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(144)))), ((int)(((byte)(59)))));
            this.accountView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.accountView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountView_CellContentDoubleClick);
            // 
            // accountName
            // 
            this.accountName.HeaderText = "Account Name";
            this.accountName.Name = "accountName";
            // 
            // passwordColumn
            // 
            this.passwordColumn.HeaderText = "Password";
            this.passwordColumn.Name = "passwordColumn";
            this.passwordColumn.ReadOnly = true;
            this.passwordColumn.Visible = false;
            // 
            // addAccount
            // 
            this.addAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            this.addAccount.Controls.Add(this.loadFileButton);
            this.addAccount.Controls.Add(this.addAccountButton);
            this.addAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addAccount.Location = new System.Drawing.Point(0, 384);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(600, 38);
            this.addAccount.TabIndex = 1;
            // 
            // loadFileButton
            // 
            this.loadFileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadFileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loadFileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loadFileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loadFileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loadFileButton.ForeColor = System.Drawing.Color.White;
            this.loadFileButton.Location = new System.Drawing.Point(128, 5);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(119, 30);
            this.loadFileButton.TabIndex = 6;
            this.loadFileButton.Text = "Load";
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // addAccountButton
            // 
            this.addAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addAccountButton.ForeColor = System.Drawing.Color.White;
            this.addAccountButton.Location = new System.Drawing.Point(3, 5);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(119, 30);
            this.addAccountButton.TabIndex = 0;
            this.addAccountButton.Text = "Add Acount";
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView accountView;
        private Guna.UI2.WinForms.Guna2Panel addAccount;
        private Guna.UI2.WinForms.Guna2Button addAccountButton;
        private Guna.UI2.WinForms.Guna2Button loadFileButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColumn;
    }
}