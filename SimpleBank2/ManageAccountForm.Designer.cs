namespace SimpleBank2
{
    partial class ManageAccountForm
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
            this.listBoxAccountDisplay = new System.Windows.Forms.ListBox();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.textBoxWithdraw = new System.Windows.Forms.TextBox();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.groupBoxWithdraw = new System.Windows.Forms.GroupBox();
            this.labelWithdrawAmount = new System.Windows.Forms.Label();
            this.groupBoxDeposit = new System.Windows.Forms.GroupBox();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.comboBoxTransferFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTransferTo = new System.Windows.Forms.ComboBox();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.textBoxTransfer = new System.Windows.Forms.TextBox();
            this.groupBoxTransferFunds = new System.Windows.Forms.GroupBox();
            this.labelTransferAmount = new System.Windows.Forms.Label();
            this.labelTransferTo = new System.Windows.Forms.Label();
            this.labelYransferFrom = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyInterestToSelectedAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.backToCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxWithdraw.SuspendLayout();
            this.groupBoxDeposit.SuspendLayout();
            this.groupBoxTransferFunds.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAccountDisplay
            // 
            this.listBoxAccountDisplay.BackColor = System.Drawing.Color.Azure;
            this.listBoxAccountDisplay.FormattingEnabled = true;
            this.listBoxAccountDisplay.Location = new System.Drawing.Point(61, 99);
            this.listBoxAccountDisplay.Name = "listBoxAccountDisplay";
            this.listBoxAccountDisplay.Size = new System.Drawing.Size(446, 134);
            this.listBoxAccountDisplay.TabIndex = 1;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(44, 45);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(66, 23);
            this.buttonWithdraw.TabIndex = 2;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // textBoxWithdraw
            // 
            this.textBoxWithdraw.Location = new System.Drawing.Point(52, 19);
            this.textBoxWithdraw.Name = "textBoxWithdraw";
            this.textBoxWithdraw.Size = new System.Drawing.Size(58, 20);
            this.textBoxWithdraw.TabIndex = 3;
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Location = new System.Drawing.Point(52, 19);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(58, 20);
            this.textBoxDeposit.TabIndex = 4;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(44, 45);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(66, 23);
            this.buttonDeposit.TabIndex = 5;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // groupBoxWithdraw
            // 
            this.groupBoxWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxWithdraw.Controls.Add(this.labelWithdrawAmount);
            this.groupBoxWithdraw.Controls.Add(this.textBoxWithdraw);
            this.groupBoxWithdraw.Controls.Add(this.buttonWithdraw);
            this.groupBoxWithdraw.Location = new System.Drawing.Point(61, 251);
            this.groupBoxWithdraw.Name = "groupBoxWithdraw";
            this.groupBoxWithdraw.Size = new System.Drawing.Size(116, 80);
            this.groupBoxWithdraw.TabIndex = 6;
            this.groupBoxWithdraw.TabStop = false;
            this.groupBoxWithdraw.Text = "Withdrawal";
            // 
            // labelWithdrawAmount
            // 
            this.labelWithdrawAmount.AutoSize = true;
            this.labelWithdrawAmount.Location = new System.Drawing.Point(6, 22);
            this.labelWithdrawAmount.Name = "labelWithdrawAmount";
            this.labelWithdrawAmount.Size = new System.Drawing.Size(46, 13);
            this.labelWithdrawAmount.TabIndex = 4;
            this.labelWithdrawAmount.Text = "Amount:";
            // 
            // groupBoxDeposit
            // 
            this.groupBoxDeposit.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDeposit.Controls.Add(this.labelDeposit);
            this.groupBoxDeposit.Controls.Add(this.textBoxDeposit);
            this.groupBoxDeposit.Controls.Add(this.buttonDeposit);
            this.groupBoxDeposit.Location = new System.Drawing.Point(185, 251);
            this.groupBoxDeposit.Name = "groupBoxDeposit";
            this.groupBoxDeposit.Size = new System.Drawing.Size(116, 80);
            this.groupBoxDeposit.TabIndex = 7;
            this.groupBoxDeposit.TabStop = false;
            this.groupBoxDeposit.Text = "Deposit";
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Location = new System.Drawing.Point(6, 22);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(46, 13);
            this.labelDeposit.TabIndex = 6;
            this.labelDeposit.Text = "Amount:";
            // 
            // comboBoxTransferFrom
            // 
            this.comboBoxTransferFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransferFrom.FormattingEnabled = true;
            this.comboBoxTransferFrom.Location = new System.Drawing.Point(56, 22);
            this.comboBoxTransferFrom.Name = "comboBoxTransferFrom";
            this.comboBoxTransferFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTransferFrom.TabIndex = 9;
            // 
            // comboBoxTransferTo
            // 
            this.comboBoxTransferTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransferTo.FormattingEnabled = true;
            this.comboBoxTransferTo.Location = new System.Drawing.Point(56, 49);
            this.comboBoxTransferTo.Name = "comboBoxTransferTo";
            this.comboBoxTransferTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTransferTo.TabIndex = 10;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(118, 90);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(59, 23);
            this.buttonTransfer.TabIndex = 12;
            this.buttonTransfer.Text = "Transfer";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // textBoxTransfer
            // 
            this.textBoxTransfer.Location = new System.Drawing.Point(56, 92);
            this.textBoxTransfer.Name = "textBoxTransfer";
            this.textBoxTransfer.Size = new System.Drawing.Size(56, 20);
            this.textBoxTransfer.TabIndex = 13;
            // 
            // groupBoxTransferFunds
            // 
            this.groupBoxTransferFunds.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTransferFunds.Controls.Add(this.labelTransferAmount);
            this.groupBoxTransferFunds.Controls.Add(this.buttonTransfer);
            this.groupBoxTransferFunds.Controls.Add(this.labelTransferTo);
            this.groupBoxTransferFunds.Controls.Add(this.labelYransferFrom);
            this.groupBoxTransferFunds.Controls.Add(this.comboBoxTransferFrom);
            this.groupBoxTransferFunds.Controls.Add(this.textBoxTransfer);
            this.groupBoxTransferFunds.Controls.Add(this.comboBoxTransferTo);
            this.groupBoxTransferFunds.Location = new System.Drawing.Point(307, 251);
            this.groupBoxTransferFunds.Name = "groupBoxTransferFunds";
            this.groupBoxTransferFunds.Size = new System.Drawing.Size(200, 136);
            this.groupBoxTransferFunds.TabIndex = 14;
            this.groupBoxTransferFunds.TabStop = false;
            this.groupBoxTransferFunds.Text = "Transfer Funds";
            // 
            // labelTransferAmount
            // 
            this.labelTransferAmount.AutoSize = true;
            this.labelTransferAmount.Location = new System.Drawing.Point(8, 95);
            this.labelTransferAmount.Name = "labelTransferAmount";
            this.labelTransferAmount.Size = new System.Drawing.Size(46, 13);
            this.labelTransferAmount.TabIndex = 16;
            this.labelTransferAmount.Text = "Amount:";
            // 
            // labelTransferTo
            // 
            this.labelTransferTo.AutoSize = true;
            this.labelTransferTo.Location = new System.Drawing.Point(31, 52);
            this.labelTransferTo.Name = "labelTransferTo";
            this.labelTransferTo.Size = new System.Drawing.Size(23, 13);
            this.labelTransferTo.TabIndex = 15;
            this.labelTransferTo.Text = "To:";
            // 
            // labelYransferFrom
            // 
            this.labelYransferFrom.AutoSize = true;
            this.labelYransferFrom.Location = new System.Drawing.Point(21, 26);
            this.labelYransferFrom.Name = "labelYransferFrom";
            this.labelYransferFrom.Size = new System.Drawing.Size(33, 13);
            this.labelYransferFrom.TabIndex = 14;
            this.labelYransferFrom.Text = "From:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.newAccountToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyInterestToSelectedAccountToolStripMenuItem,
            this.toolStripMenuItem1,
            this.backToCustomersToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // applyInterestToSelectedAccountToolStripMenuItem
            // 
            this.applyInterestToSelectedAccountToolStripMenuItem.Name = "applyInterestToSelectedAccountToolStripMenuItem";
            this.applyInterestToSelectedAccountToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.applyInterestToSelectedAccountToolStripMenuItem.Text = "Apply Interest to selected account";
            this.applyInterestToSelectedAccountToolStripMenuItem.Click += new System.EventHandler(this.applyInterestToSelectedAccountToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 6);
            // 
            // backToCustomersToolStripMenuItem
            // 
            this.backToCustomersToolStripMenuItem.Name = "backToCustomersToolStripMenuItem";
            this.backToCustomersToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.backToCustomersToolStripMenuItem.Text = "Back to Customers";
            this.backToCustomersToolStripMenuItem.Click += new System.EventHandler(this.backToCustomersToolStripMenuItem_Click);
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAccountToolStripMenuItem});
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.newAccountToolStripMenuItem.Text = "New Account";
            // 
            // addNewAccountToolStripMenuItem
            // 
            this.addNewAccountToolStripMenuItem.Name = "addNewAccountToolStripMenuItem";
            this.addNewAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewAccountToolStripMenuItem.Text = "Add New Account";
            this.addNewAccountToolStripMenuItem.Click += new System.EventHandler(this.addNewAccountToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Manage Accounts";
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedAccountToolStripMenuItem});
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            // 
            // deleteSelectedAccountToolStripMenuItem
            // 
            this.deleteSelectedAccountToolStripMenuItem.Name = "deleteSelectedAccountToolStripMenuItem";
            this.deleteSelectedAccountToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.deleteSelectedAccountToolStripMenuItem.Text = "Delete Selected Account";
            this.deleteSelectedAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedAccountToolStripMenuItem_Click);
            // 
            // ManageAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTransferFunds);
            this.Controls.Add(this.groupBoxDeposit);
            this.Controls.Add(this.groupBoxWithdraw);
            this.Controls.Add(this.listBoxAccountDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageAccountForm";
            this.Text = "Manage Accounts";
            this.groupBoxWithdraw.ResumeLayout(false);
            this.groupBoxWithdraw.PerformLayout();
            this.groupBoxDeposit.ResumeLayout(false);
            this.groupBoxDeposit.PerformLayout();
            this.groupBoxTransferFunds.ResumeLayout(false);
            this.groupBoxTransferFunds.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAccountDisplay;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.TextBox textBoxWithdraw;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.GroupBox groupBoxWithdraw;
        private System.Windows.Forms.Label labelWithdrawAmount;
        private System.Windows.Forms.GroupBox groupBoxDeposit;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.ComboBox comboBoxTransferFrom;
        private System.Windows.Forms.ComboBox comboBoxTransferTo;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.TextBox textBoxTransfer;
        private System.Windows.Forms.GroupBox groupBoxTransferFunds;
        private System.Windows.Forms.Label labelTransferAmount;
        private System.Windows.Forms.Label labelTransferTo;
        private System.Windows.Forms.Label labelYransferFrom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyInterestToSelectedAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backToCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAccountToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedAccountToolStripMenuItem;
    }
}