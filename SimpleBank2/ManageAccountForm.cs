using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBank2
{
    public partial class ManageAccountForm : ParentForm
    {
        Controller control = new Controller();
        private int currentCustomerID;
        public ManageAccountForm(int customerID)
        {
            InitializeComponent();
            control.ReadBinaryAccountsData();
            control.ReadBinaryCustomersData();
            currentCustomerID = customerID;
            DisplayAccounts();
        }

        private void DisplayAccounts()
        {
            listBoxAccountDisplay.Items.Clear();
            comboBoxTransferFrom.Items.Clear();
            comboBoxTransferTo.Items.Clear();

            foreach (Accounts a in control.accountsList)
            {
                if (a.CustomerID == currentCustomerID)
                {
                    listBoxAccountDisplay.Items.Add(a.getAccountDetails());
                    comboBoxTransferFrom.Items.Add($"{a.accountType()} {a.ID}");
                    comboBoxTransferTo.Items.Add($"{a.accountType()} {a.ID}");
                } 
            }
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                Accounts account = GetAccountSelected();
                decimal amount = decimal.Parse(textBoxWithdraw.Text);
                control.AccountWithdraw(account, amount, currentCustomerID);

                MessageBox.Show($"Withdrawn {amount} from {account.accountType()} {account.ID}!");
            }
            catch (NoAccountSelectedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid amount!");
                return;
            }
            catch (InsufficientBalanceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            control.WriteBinaryAccountsData();

            // Refresh the list in listbox.
            listBoxAccountDisplay.Items.Clear();
            DisplayAccounts();
            textBoxWithdraw.Clear();
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                Accounts account = GetAccountSelected();

                decimal amount = decimal.Parse(textBoxDeposit.Text);
                control.AccountDeposit(account, amount);

                MessageBox.Show($"Deposited {amount} to {account.accountType()} {account.ID}!");
            }
            catch (NoAccountSelectedException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid amount!");
                return;
            }

            control.WriteBinaryAccountsData();

            // Refresh the list in listbox.
            listBoxAccountDisplay.Items.Clear();
            DisplayAccounts();
            textBoxDeposit.Clear();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            decimal amount = 0m;
            
            if (comboBoxTransferFrom.SelectedItem == null || comboBoxTransferTo.SelectedItem == null 
                || comboBoxTransferFrom.SelectedItem.Equals(comboBoxTransferTo.SelectedItem))
            {
                MessageBox.Show("Please select correct accounts!");
                return;
            }

            if (!decimal.TryParse(textBoxTransfer.Text, out amount))
            {
                MessageBox.Show("Invalid amount!");
                return;
            }

            string returnMessage = control.AccountTransfer(comboBoxTransferFrom.SelectedItem.ToString(), comboBoxTransferTo.SelectedItem.ToString(), amount, currentCustomerID);

            control.WriteBinaryAccountsData();

            DisplayAccounts();
            textBoxTransfer.Clear();

            MessageBox.Show(returnMessage);
        }

        private void applyInterestToSelectedAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string transactionMessage = "";
            try
            {
                Accounts account = GetAccountSelected();

                // Pass it to controller to apply the interest.
                transactionMessage = control.ApplyInterestToBalance(account);
            }
            catch (NoAccountSelectedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            MessageBox.Show(transactionMessage);

            control.WriteBinaryAccountsData();

            // Refresh the list in listbox.
            listBoxAccountDisplay.Items.Clear();
            DisplayAccounts();
        }

        private void backToCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEditForm viewEditForm = new ViewEditForm();

            viewEditForm.Show();
            this.Hide();
        }

        private Accounts GetAccountSelected()
        {
            if (listBoxAccountDisplay.SelectedItem == null)
            {
                throw new NoAccountSelectedException("Please select an account!");
            }
            return control.FindAccountByDetails(listBoxAccountDisplay.SelectedItem.ToString());
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAccountForm addNewAccount = new AddNewAccountForm(currentCustomerID);
            addNewAccount.Show();
            this.Hide();
        }

        private void deleteSelectedAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete account?", "Confirmation!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                control.DeleteAccount(GetAccountSelected()  );
                DisplayAccounts();
                control.WriteBinaryAccountsData();

                MessageBox.Show("Account deleted!");
            }

            control.WriteBinaryAccountsData();
        }
    }
}
