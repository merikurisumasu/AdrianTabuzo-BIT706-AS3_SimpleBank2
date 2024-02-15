namespace SimpleBank2
{
    partial class ViewAccountsForm
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
            this.labelViewAccounts = new System.Windows.Forms.Label();
            this.listBoxViewAccounts = new System.Windows.Forms.ListBox();
            this.buttonReturnToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelViewAccounts
            // 
            this.labelViewAccounts.AutoSize = true;
            this.labelViewAccounts.BackColor = System.Drawing.Color.Transparent;
            this.labelViewAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewAccounts.Location = new System.Drawing.Point(12, 23);
            this.labelViewAccounts.Name = "labelViewAccounts";
            this.labelViewAccounts.Size = new System.Drawing.Size(241, 37);
            this.labelViewAccounts.TabIndex = 0;
            this.labelViewAccounts.Text = "View Accounts";
            // 
            // listBoxViewAccounts
            // 
            this.listBoxViewAccounts.FormattingEnabled = true;
            this.listBoxViewAccounts.Location = new System.Drawing.Point(146, 114);
            this.listBoxViewAccounts.Name = "listBoxViewAccounts";
            this.listBoxViewAccounts.Size = new System.Drawing.Size(426, 199);
            this.listBoxViewAccounts.TabIndex = 1;
            // 
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.Location = new System.Drawing.Point(497, 402);
            this.buttonReturnToMenu.Name = "buttonReturnToMenu";
            this.buttonReturnToMenu.Size = new System.Drawing.Size(75, 36);
            this.buttonReturnToMenu.TabIndex = 2;
            this.buttonReturnToMenu.Text = "Return To Menu";
            this.buttonReturnToMenu.UseVisualStyleBackColor = true;
            this.buttonReturnToMenu.Click += new System.EventHandler(this.buttonReturnToMenu_Click);
            // 
            // ViewAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.buttonReturnToMenu);
            this.Controls.Add(this.listBoxViewAccounts);
            this.Controls.Add(this.labelViewAccounts);
            this.Name = "ViewAccountsForm";
            this.Text = "ViewAccounts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelViewAccounts;
        private System.Windows.Forms.ListBox listBoxViewAccounts;
        private System.Windows.Forms.Button buttonReturnToMenu;
    }
}