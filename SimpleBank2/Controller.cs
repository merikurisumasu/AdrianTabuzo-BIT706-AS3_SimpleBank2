using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleBank2
{
    internal class Controller
    {
        // Declare a list to store customers.
        public List<Customers> customersList = new List<Customers>();

        public List<Accounts> accountsList = new List<Accounts>();

        /// <summary>
        /// Creates a new instance of a Customer and adds it to a list.
        /// </summary>
        /// <param name="name">Name of the new customer instance.</param>
        /// <param name="phone">Phone number of the new customer instance.</param>
        /// <param name="address">Address of the new customer instance.</param>
        /// <param name="feeReduction">Defalut as 1 but set to 0.5 if new customer is a staff.</param>
        public void AddCustomer(string name, string phone, string address, double feeReduction)
        {
            customersList.Add(new Customers(name, phone, address, feeReduction));
        }


        /// <summary>
        /// Takes a string parameter then search through the list to return the customer object then returns the Customer.
        /// </summary>
        /// <param name="name">Customer's name</param>
        /// <returns>Returns the customer or null if not found</returns>
        public Customers FindCustomersByName(string name)
        {
            foreach (Customers c in customersList)
            {
                if (c.Name == name) { return c; }
            }
            return null;
        }

        /// <summary>
        /// Takes an integer parameter to search the customer object within the list and returns the Customer if found.
        /// </summary>
        /// <param name="id">Customer's ID</param>
        /// <returns>Returns the customer or null if not found</returns>
        public Customers FindCustomerByID(int id)
        {
            foreach (Customers c in customersList)
                if (c.ID.Equals(id))
                    return c;
            return null;
        }

        /// <summary>
        /// Calls a method to search the customer then deletes the object from the list.
        /// </summary>
        /// <param name="name">Customer's name</param>
        // Remove from the list of customers.
        public void DeleteCustomer(string name)
        {
            customersList.Remove(FindCustomersByName(name));
        }  
        
        /// <summary>
        /// Takes customer's details as parameters then set as new customer's details.
        /// </summary>
        /// <param name="cust">Customer object</param>
        /// <param name="name">Customer's name</param>
        /// <param name="phone">Customer's phone</param>
        /// <param name="address">Customer's address</param>
        // Set new details for customer.
        public void EditCustomer(Customers cust, string name, string phone, string address)
        {
            cust.Name = name;
            cust.Phone = phone;
            cust.Address = address;
        }

        /// <summary>
        /// Takes new account parameters and determines the type of account then creates the object and adds into the list.
        /// </summary>
        /// <param name="accountType">Type of the new account</param>
        /// <param name="balance">The balance of the new account</param>
        /// <param name="customerID">ID of the customer who owns the new account</param>
        public void AddAccount (string accountType, decimal balance, int customerID)
        {
            switch (accountType)
            {
                case "Everyday":
                    accountsList.Add(new Everyday(balance, customerID)); break;
                case "Investment":
                    accountsList.Add(new Investment(balance, customerID)); break;
                case "Omni":
                    accountsList.Add(new Omni(balance, customerID)); break;
            }
        }

        /// <summary>
        /// Removes the object from the list.
        /// </summary>
        /// <param name="account">Account to be deleted</param>
        public void DeleteAccount (Accounts account)
        {
            accountsList.Remove(account);
        }

        /// <summary>
        /// Finds and returns the account by details which is printed on the list box displayed to the user from the list.
        /// </summary>
        /// <param name="details">The details of the account</param>
        /// <returns>Returns the Account or null if not found.</returns>
        public Accounts FindAccountByDetails(string details)
        {
            foreach (Accounts a in accountsList)
            {
                if (a.getAccountDetails().Equals(details))
                    return a;
            }
            return null;
        }

        /// <summary>
        /// Finds and returns the account through the type and ID received as a string. 
        /// </summary>
        /// <param name="s">The type and ID if the account</param>
        /// <returns>Returns the account or null if not found</returns>
        public Accounts FindAccountsByTypeAndID(string s)
        {
            foreach (Accounts a in accountsList)
                if ($"{a.accountType()} {a.ID}".Equals(s))
                    return a;
            return null;
        }

        /// <summary>
        /// Get the interest value to be addded to the balance of the account.
        /// Add the interest value to the balance.
        /// Update the list with the new balance by writing on the binary file.
        /// </summary>
        /// <param name="account">The account add the interest into</param>
        /// <returns>Returns a string for the transaction details.</returns>
        public string ApplyInterestToBalance(Accounts account)
        {
            // Get interest value.
            decimal InterestToAdd = account.interestValue();

            // Add interest value to balance.
            account.Deposit(InterestToAdd);

            // Update list with new balance.
            WriteBinaryAccountsData();

            return ($"Interest deposited to account: {InterestToAdd}");
            
        }

        /// <summary>
        /// Finds the Customer using the ID parameter passed.
        /// Calls a method to deduct the amount value from the account's balance.
        /// Update the binary file to save the new balance.
        /// </summary>
        /// <param name="account">Account object to deduct the amount from</param>
        /// <param name="amount">Value to be deducted from the balance</param>
        /// <param name="customerID">Customer ID to be passed to a method to search the customer object</param>
        public void AccountWithdraw(Accounts account, decimal amount, int customerID)
        {
            Customers customer = FindCustomerByID(customerID);
            account.Withdraw(amount, customer);

            // Update list with new balance.
            WriteBinaryAccountsData();
        }

        /// <summary>
        /// Receives the account object and the amount.
        /// Then calls the methd to add the amount to the balance.
        /// Update the binary file to save the new balance.
        /// </summary>
        /// <param name="account">Account object to add the amount to</param>
        /// <param name="amount">Value to be added to the balance</param>
        public void AccountDeposit(Accounts account, decimal amount)
        {
            account.Deposit(amount);

            // Update list with new balance.
            WriteBinaryAccountsData();
        }

        /// <summary>
        /// Finds the customer through the customer ID passed to the method.
        /// Finds the accounts transferring and receiving.
        /// Then deduct and add the amount from respective accounts using the withdraw and deposit method.
        /// Update the balance of account on the binary file. 
        /// </summary>
        /// <param name="accountFrom">Type and ID of the account transferring from as a string</param>
        /// <param name="accountTo">Type and ID of the account transferring to as a string</param>
        /// <param name="amount">Vaue to be transferred across the accounts.</param>
        /// <param name="customerID">Customer ID to be used to search the customer</param>
        /// <returns>Returns the transaction details and new balances of involve accounts</returns>
        public string AccountTransfer(string accountFrom, string accountTo, decimal amount, int customerID)
        {
            Customers customer = FindCustomerByID(customerID);

            // Get the accounts.
            Accounts AccountTransfer = FindAccountsByTypeAndID(accountFrom);
            Accounts AccountReceive = FindAccountsByTypeAndID(accountTo);

            // Do the transfer.
            // Deduct from the transferring account and add to the receiving account.
            try
            {
                AccountTransfer.Withdraw(amount, customer);
                AccountReceive.Deposit(amount);
            }
            catch (InsufficientBalanceException ex)
            {
                return (ex.Message);
            }            

            WriteBinaryAccountsData();

            // Returns string to print out to the user.
            return $"Transferred {amount} from Account: {accountFrom} to Account: {accountTo}. New balances below." +
                $"\n Account: {accountFrom} -  ${AccountTransfer.Balance}" +
                $"\n Account: {accountTo} - ${AccountReceive.Balance}";
        }






        // Serialise the data into a binary file.
        public void WriteBinaryCustomersData()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("objects.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, customersList);

            stream.Close();
        }
        // Read serialised data into the app.
        public void ReadBinaryCustomersData()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("objects.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            customersList = (List<Customers>)formatter.Deserialize(stream);

            stream.Close();
        }


        // Serialise the data into a binary file.
        public void WriteBinaryAccountsData()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("accountsObjects.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, accountsList);

            stream.Close();
        }
        // Read serialised data into the app.
        public void ReadBinaryAccountsData()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("accountsObjects.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            accountsList = (List<Accounts>)formatter.Deserialize(stream);

            stream.Close();
        }


        public void ReadBinarySingletonsData()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("CustomersID.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            SingletonData.setInstance((SingletonData)formatter.Deserialize(stream));

            stream.Close();
        }

        public void WriteBinarySingletonData()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("CustomersID.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, SingletonData.getInstance());

            stream.Close();
        }

        public void ReadBinarySingletonAccountID()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("AccountsID.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            SingletonAccountID.setInstance((SingletonAccountID)formatter.Deserialize(stream));

            stream.Close();
        }

        public void WriteBinarySingletonAccountID()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("AccountsID.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, SingletonAccountID.getInstance());

            stream.Close();
        }
    }
}
