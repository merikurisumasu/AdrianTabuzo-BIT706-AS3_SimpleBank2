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
    public partial class AddNewAccountForm : ParentForm
    {
        Controller control = new Controller();
        private int currentCustomerID;
        public AddNewAccountForm(int customerID)
        {
            InitializeComponent();
            currentCustomerID = customerID;
            control.ReadBinaryAccountsData();
            control.ReadBinarySingletonAccountID();

        }

        private void backToAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAccountForm manageAccountForm = new ManageAccountForm(currentCustomerID);
            manageAccountForm.Show();
            this.Hide();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxBalance.Clear();
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Apply Singleton Pattern and populate ID.
            // Check balance textbox input.
            // Add new account through Controller class.
            // Serialise accounts and the singleton data.

            string accountType = "";
            decimal amount;
            if (radioButtonEveryday.Checked)
            {
                accountType = "Everyday";
            }
            else if (radioButtonInvestment.Checked)
            {
                accountType = "Investment";
            }
            else if (radioButtonOmni.Checked)
            {
                accountType = "Omni";
            }

            try
            {
                amount = decimal.Parse(textBoxBalance.Text);
            }

            catch (FormatException)
            {
                MessageBox.Show("Invalid amount!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Confirm details?", "Confirmation!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                control.AddAccount(accountType, amount, currentCustomerID);
                MessageBox.Show("Added new account!");
                control.WriteBinaryAccountsData();
                control.WriteBinarySingletonAccountID(); // Serialise the current ID as well after adding new Customer entry.
            }

            textBoxBalance.Clear();
        }
    }
}
