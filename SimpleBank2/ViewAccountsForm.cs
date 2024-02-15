using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBank2
{
    public partial class ViewAccountsForm : ParentForm
    {

        Controller control = new Controller();
        public ViewAccountsForm()
        {
            InitializeComponent();
            control.ReadBinaryAccountsData();
            DisplayAccounts();
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            IndexForm indexForm = new IndexForm();
            indexForm.Show();
            this.Hide();
        }

        private void DisplayAccounts()
        {
            foreach (Accounts a in control.accountsList)
            {
                listBoxViewAccounts.Items.Add(a.getAccountDetails());
            }
        }


    }
}
