namespace Form1
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.OthersTooltips = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.TransactionsTooltips = new System.Windows.Forms.ToolStripMenuItem();
            this.DepositMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.WidthdrawManuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransferMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.FDformMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ViewTooltips = new System.Windows.Forms.ToolStripMenuItem();
            this.BalanceSheetMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewFDMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSearchAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.menuStrip4);
            this.panel1.Controls.Add(this.menuStrip3);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 569);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip4
            // 
            this.menuStrip4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.menuStrip4.AutoSize = false;
            this.menuStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OthersTooltips});
            this.menuStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip4.Location = new System.Drawing.Point(0, 284);
            this.menuStrip4.MdiWindowListItem = this.OthersTooltips;
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(198, 28);
            this.menuStrip4.TabIndex = 3;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // OthersTooltips
            // 
            this.OthersTooltips.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutMenuitem,
            this.ChangePasswordMenuitem});
            this.OthersTooltips.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OthersTooltips.Name = "OthersTooltips";
            this.OthersTooltips.Size = new System.Drawing.Size(191, 21);
            this.OthersTooltips.Text = "Others";
            // 
            // LogoutMenuitem
            // 
            this.LogoutMenuitem.Name = "LogoutMenuitem";
            this.LogoutMenuitem.Size = new System.Drawing.Size(168, 22);
            this.LogoutMenuitem.Text = "로그아웃";
            this.LogoutMenuitem.Click += new System.EventHandler(this.LogoutMenuitem_Click);
            // 
            // ChangePasswordMenuitem
            // 
            this.ChangePasswordMenuitem.Name = "ChangePasswordMenuitem";
            this.ChangePasswordMenuitem.Size = new System.Drawing.Size(168, 22);
            this.ChangePasswordMenuitem.Text = "비밀번호 변경";
            this.ChangePasswordMenuitem.Click += new System.EventHandler(this.ChangePasswordMenuitem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.menuStrip3.AutoSize = false;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransactionsTooltips});
            this.menuStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip3.Location = new System.Drawing.Point(0, 167);
            this.menuStrip3.MdiWindowListItem = this.TransactionsTooltips;
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(198, 28);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // TransactionsTooltips
            // 
            this.TransactionsTooltips.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DepositMenuitem,
            this.WidthdrawManuitem,
            this.TransferMenuitem,
            this.FDformMenuitem});
            this.TransactionsTooltips.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TransactionsTooltips.Name = "TransactionsTooltips";
            this.TransactionsTooltips.Size = new System.Drawing.Size(191, 21);
            this.TransactionsTooltips.Text = "거래";
            // 
            // DepositMenuitem
            // 
            this.DepositMenuitem.Name = "DepositMenuitem";
            this.DepositMenuitem.Size = new System.Drawing.Size(180, 22);
            this.DepositMenuitem.Text = "예치금";
            this.DepositMenuitem.Click += new System.EventHandler(this.DepositMenuitem_Click);
            // 
            // WidthdrawManuitem
            // 
            this.WidthdrawManuitem.Name = "WidthdrawManuitem";
            this.WidthdrawManuitem.Size = new System.Drawing.Size(180, 22);
            this.WidthdrawManuitem.Text = "인출";
            this.WidthdrawManuitem.Click += new System.EventHandler(this.WidthdrawManuitem_Click);
            // 
            // TransferMenuitem
            // 
            this.TransferMenuitem.Name = "TransferMenuitem";
            this.TransferMenuitem.Size = new System.Drawing.Size(180, 22);
            this.TransferMenuitem.Text = "송금";
            this.TransferMenuitem.Click += new System.EventHandler(this.TransferMenuitem_Click);
            // 
            // FDformMenuitem
            // 
            this.FDformMenuitem.Name = "FDformMenuitem";
            this.FDformMenuitem.Size = new System.Drawing.Size(180, 22);
            this.FDformMenuitem.Text = "정기예금";
            this.FDformMenuitem.Click += new System.EventHandler(this.FDformMenuitem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewTooltips});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 225);
            this.menuStrip2.MdiWindowListItem = this.ViewTooltips;
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(198, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ViewTooltips
            // 
            this.ViewTooltips.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BalanceSheetMenuitem,
            this.ViewFDMenuitem});
            this.ViewTooltips.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ViewTooltips.Name = "ViewTooltips";
            this.ViewTooltips.Size = new System.Drawing.Size(191, 21);
            this.ViewTooltips.Text = "View";
            // 
            // BalanceSheetMenuitem
            // 
            this.BalanceSheetMenuitem.Name = "BalanceSheetMenuitem";
            this.BalanceSheetMenuitem.Size = new System.Drawing.Size(175, 22);
            this.BalanceSheetMenuitem.Text = "Balance Sheet";
            this.BalanceSheetMenuitem.Click += new System.EventHandler(this.BalanceSheetMenuitem_Click);
            // 
            // ViewFDMenuitem
            // 
            this.ViewFDMenuitem.Name = "ViewFDMenuitem";
            this.ViewFDMenuitem.Size = new System.Drawing.Size(175, 22);
            this.ViewFDMenuitem.Text = "View FD";
            this.ViewFDMenuitem.Click += new System.EventHandler(this.ViewFDMenuitem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 110);
            this.menuStrip1.MdiWindowListItem = this.accountToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(198, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.updateSearchAccountToolStripMenuItem,
            this.allCustomerToolStripMenuItem});
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(191, 21);
            this.accountToolStripMenuItem.Text = "계좌";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newAccountToolStripMenuItem.Text = "새 개좌";
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
            // 
            // updateSearchAccountToolStripMenuItem
            // 
            this.updateSearchAccountToolStripMenuItem.Name = "updateSearchAccountToolStripMenuItem";
            this.updateSearchAccountToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.updateSearchAccountToolStripMenuItem.Text = "계좌 검색";
            this.updateSearchAccountToolStripMenuItem.Click += new System.EventHandler(this.updateSearchAccountToolStripMenuItem_Click);
            // 
            // allCustomerToolStripMenuItem
            // 
            this.allCustomerToolStripMenuItem.Name = "allCustomerToolStripMenuItem";
            this.allCustomerToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.allCustomerToolStripMenuItem.Text = "고객";
            this.allCustomerToolStripMenuItem.Click += new System.EventHandler(this.allCustomerToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSearchAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCustomerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem OthersTooltips;
        private System.Windows.Forms.ToolStripMenuItem LogoutMenuitem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordMenuitem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem TransactionsTooltips;
        private System.Windows.Forms.ToolStripMenuItem DepositMenuitem;
        private System.Windows.Forms.ToolStripMenuItem WidthdrawManuitem;
        private System.Windows.Forms.ToolStripMenuItem TransferMenuitem;
        private System.Windows.Forms.ToolStripMenuItem FDformMenuitem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ViewTooltips;
        private System.Windows.Forms.ToolStripMenuItem BalanceSheetMenuitem;
        private System.Windows.Forms.ToolStripMenuItem ViewFDMenuitem;
    }
}