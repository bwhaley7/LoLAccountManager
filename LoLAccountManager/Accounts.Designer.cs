
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
            this.addAccount = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.loadFileButton = new Guna.UI2.WinForms.Guna2Button();
            this.addAccountButton = new Guna.UI2.WinForms.Guna2Button();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summonerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.passwordColumn,
            this.summonerName,
            this.rank});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountView.DefaultCellStyle = dataGridViewCellStyle3;
            this.accountView.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.accountView.Size = new System.Drawing.Size(600, 385);
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
            // addAccount
            // 
            this.addAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            this.addAccount.Controls.Add(this.guna2Button2);
            this.addAccount.Controls.Add(this.guna2Button1);
            this.addAccount.Controls.Add(this.guna2ImageButton1);
            this.addAccount.Controls.Add(this.loadFileButton);
            this.addAccount.Controls.Add(this.addAccountButton);
            this.addAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addAccount.Location = new System.Drawing.Point(0, 384);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(600, 38);
            this.addAccount.TabIndex = 1;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(144)))), ((int)(((byte)(59)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(221, 5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(64, 30);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "Import";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(144)))), ((int)(((byte)(59)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(161, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(54, 30);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Save";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::LoLAccountManager.Properties.Resources.rotate;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton1.Location = new System.Drawing.Point(533, 7);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(23, 23);
            this.guna2ImageButton1.TabIndex = 2;
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // loadFileButton
            // 
            this.loadFileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadFileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loadFileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loadFileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loadFileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(144)))), ((int)(((byte)(59)))));
            this.loadFileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loadFileButton.ForeColor = System.Drawing.Color.White;
            this.loadFileButton.Location = new System.Drawing.Point(101, 5);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(54, 30);
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
            this.addAccountButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(144)))), ((int)(((byte)(59)))));
            this.addAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addAccountButton.ForeColor = System.Drawing.Color.White;
            this.addAccountButton.Location = new System.Drawing.Point(3, 5);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(92, 30);
            this.addAccountButton.TabIndex = 0;
            this.addAccountButton.Text = "Add Acount";
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
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
            // summonerName
            // 
            this.summonerName.HeaderText = "Summoner Name";
            this.summonerName.Name = "summonerName";
            // 
            // rank
            // 
            this.rank.HeaderText = "Rank";
            this.rank.Name = "rank";
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
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summonerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
    }
}