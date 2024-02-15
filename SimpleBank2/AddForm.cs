using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBank2
{
    public partial class AddForm : ParentForm
    {
        Controller control = new Controller();
        public AddForm()
        {
            InitializeComponent();
            control.ReadBinaryCustomersData();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            ViewEditForm viewEditForm = new ViewEditForm();
            viewEditForm.Show();
            this.Hide();
        }

        private void buttonSaveCustomer_Click(object sender, EventArgs e)
        {
            double feeReduction = 1;
            if (checkTextBoxes())
            {
                MessageBox.Show("Please provide all info!");
                return;
            }

            if (checkBoxStaff.Checked)
                feeReduction = 0.5;

            DialogResult dialogResult = MessageBox.Show("Confirm details?", "Confirmation!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                control.AddCustomer(textBoxName.Text, textBoxPhone.Text, textBoxAddress.Text, feeReduction);
                Clear();
                MessageBox.Show("Added new customer");
                control.WriteBinaryCustomersData();
                control.WriteBinarySingletonData(); // Serialise the current ID as well after adding new Customer entry.
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private bool checkTextBoxes()
        {
            if (textBoxName.Text == "" || textBoxPhone.Text == "" || textBoxAddress.Text == "")
            {
                return true;
            }
            return false;
        }

        private void Clear()
        {
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxAddress.Clear();
        }

        private void WriteTextFile()
        {
            //open file
            var myfile = new StreamWriter("../../data.txt", true);

            foreach (Customers cst in control.customersList)
            {
                myfile.WriteLine(cst.Name + "," + cst.Phone + "," + cst.Address);
            }
            myfile.Close();
        }
    }
}