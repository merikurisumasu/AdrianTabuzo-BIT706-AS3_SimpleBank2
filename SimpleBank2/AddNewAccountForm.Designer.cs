namespace SimpleBank2
{
    partial class AddNewAccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAccountTypes = new System.Windows.Forms.GroupBox();
            this.radioButtonOmni = new System.Windows.Forms.RadioButton();
            this.radioButtonInvestment = new System.Windows.Forms.RadioButton();
            this.radioButtonEveryday = new System.Windows.Forms.RadioButton();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.backToAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAccountTypes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Account";
            // 
            // groupBoxAccountTypes
            // 
            this.groupBoxAccountTypes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAccountTypes.Controls.Add(this.radioButtonOmni);
            this.groupBoxAccountTypes.Controls.Add(this.radioButtonInvestment);
            this.groupBoxAccountTypes.Controls.Add(this.radioButtonEveryday);
            this.groupBoxAccountTypes.Location = new System.Drawing.Point(260, 125);
            this.groupBoxAccountTypes.Name = "groupBoxAccountTypes";
            this.groupBoxAccountTypes.Size = new System.Drawing.Size(155, 98);
            this.groupBoxAccountTypes.TabIndex = 1;
            this.groupBoxAccountTypes.TabStop = false;
            this.groupBoxAccountTypes.Text = "Account Type:";
            // 
            // radioButtonOmni
            // 
            this.radioButtonOmni.AutoSize = true;
            this.radioButtonOmni.Location = new System.Drawing.Point(11, 65);
            this.radioButtonOmni.Name = "radioButtonOmni";
            this.radioButtonOmni.Size = new System.Drawing.Size(92, 17);
            this.radioButtonOmni.TabIndex = 2;
            this.radioButtonOmni.TabStop = true;
            this.radioButtonOmni.Text = "Omni Account";
            this.radioButtonOmni.UseVisualStyleBackColor = true;
            // 
            // radioButtonInvestment
            // 
            this.radioButtonInvestment.AutoSize = true;
            this.radioButtonInvestment.Location = new System.Drawing.Point(11, 42);
            this.radioButtonInvestment.Name = "radioButtonInvestment";
            this.radioButtonInvestment.Size = new System.Drawing.Size(120, 17);
            this.radioButtonInvestment.TabIndex = 1;
            this.radioButtonInvestment.TabStop = true;
            this.radioButtonInvestment.Text = "Investment Account";
            this.radioButtonInvestment.UseVisualStyleBackColor = true;
            // 
            // radioButtonEveryday
            // 
            this.radioButtonEveryday.AutoSize = true;
            this.radioButtonEveryday.Location = new System.Drawing.Point(11, 19);
            this.radioButtonEveryday.Name = "radioButtonEveryday";
            this.radioButtonEveryday.Size = new System.Drawing.Size(112, 17);
            this.radioButtonEveryday.TabIndex = 0;
            this.radioButtonEveryday.TabStop = true;
            this.radioButtonEveryday.Text = "Everyday Account";
            this.radioButtonEveryday.UseVisualStyleBackColor = true;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(336, 239);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(79, 20);
            this.textBoxBalance.TabIndex = 5;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelBalance.Location = new System.Drawing.Point(266, 242);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(49, 13);
            this.labelBalance.TabIndex = 6;
            this.labelBalance.Text = "Balance:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.addAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripMenuItem1,
            this.backToAccountsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 6);
            // 
            // backToAccountsToolStripMenuItem
            // 
            this.backToAccountsToolStripMenuItem.Name = "backToAccountsToolStripMenuItem";
            this.backToAccountsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.backToAccountsToolStripMenuItem.Text = "Back to Accounts";
            this.backToAccountsToolStripMenuItem.Click += new System.EventHandler(this.backToAccountsToolStripMenuItem_Click);
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAccountToolStripMenuItem});
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            // 
            // addNewAccountToolStripMenuItem
            // 
            this.addNewAccountToolStripMenuItem.Name = "addNewAccountToolStripMenuItem";
            this.addNewAccountToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addNewAccountToolStripMenuItem.Text = "Add New Account";
            this.addNewAccountToolStripMenuItem.Click += new System.EventHandler(this.addNewAccountToolStripMenuItem_Click);
            // 
            // AddNewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.groupBoxAccountTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddNewAccountForm";
            this.Text = "Add New Account";
            this.groupBoxAccountTypes.ResumeLayout(false);
            this.groupBoxAccountTypes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAccountTypes;
        private System.Windows.Forms.RadioButton radioButtonOmni;
        private System.Windows.Forms.RadioButton radioButtonInvestment;
        private System.Windows.Forms.RadioButton radioButtonEveryday;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backToAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAccountToolStripMenuItem;
    }
}