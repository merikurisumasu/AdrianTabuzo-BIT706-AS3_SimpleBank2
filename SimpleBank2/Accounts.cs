using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank2
{
    using System;
    using System.Security.Cryptography;
    using System.Windows.Forms;

    [Serializable]
    public abstract class Accounts
    {
        protected const decimal FEE = 10m;
        protected const double INTERESTRATE = 0.04;
        protected const decimal OVERDRAFT = 200m;

        // Declare attributes.
        protected static int nextID = 1;
        protected int _id;
        private decimal _balance;
        private int _customerID;

        // Constructor.
        public Accounts()
        {
            _id = SingletonAccountID.NextAccountID;
            //nextID++;
        }

        public Accounts(decimal balance, int customerID) : this()
        {
            _balance = balance;
            _customerID = customerID;
        }

        // Read-only
        public int ID { get => _id; }

        // Public properties to access the private attributes within the class.
        public decimal Balance { get => _balance; set => _balance = value; }
        public int CustomerID { get => _customerID; set => _customerID = value; }


        // Simple deposit method generalised for each account type.
        public virtual decimal Deposit(decimal deposit)
        {
            return Balance += deposit;
        }

        // Simkple Withdraw method which is override by each types for specialisation.
        public virtual decimal Withdraw(decimal withdraw, Customers customer)
        {
            return Balance -= withdraw;
        }

        // Declared abstract for specialisation of description since accounts have
        //  different attributes to print out to the user.
        public abstract string getAccountDetails();

        public abstract decimal interestValue();

        public abstract string accountType();
    }

    [Serializable]
    // Subclasses to inherit from Accounts super/base class.
    public class Everyday : Accounts
    {
        // No interest, no overdraft, no fees.
        // Constructor
        public Everyday(decimal balance, int customerID)
            : base(balance, customerID)
        {
        }

        // Withdrawing cannot exceed their balance.
        // Override the normal withdraw method to check if amount > balance.
        public override decimal Withdraw(decimal amount, Customers customer)
        {
            if (amount > Balance)
                // Throw exception with appropriate message with account type..
                throw new InsufficientBalanceException("Insufficient balance from your Everyday account!");

            return base.Withdraw(amount, customer);
        }

        public override decimal interestValue()
        {
            return 0m;
        }

        public override decimal Deposit(decimal amount)
        {
            return base.Deposit(amount);
        }

        public override string getAccountDetails()
        {
            return ($"Everyday {ID} | Balance: {Balance}");
        }

        public override string accountType()
        {
            return "Everyday";
        }
    }


    [Serializable]

    // Interest rates, no overdraft, fee for failed transaction.
    public class Investment : Accounts
    {
        // Constructor.
        public Investment(decimal balance, int customerID)
            : base(balance, customerID)
        {
        }

        public override decimal Withdraw(decimal amount, Customers customer)
        {            
            if (amount > Balance)
            {
                base.Withdraw(FEE * (decimal)customer.FeeReduction, customer);
                // Throw exception with appropriate message with account type..
                throw new InsufficientBalanceException($"Insufficient balance from your Investment account! \n Failed transaction fee applied $ {FEE * (decimal)customer.FeeReduction}");
            }

            return base.Withdraw(amount, customer);
        }
        public override decimal Deposit(decimal amount)
        {
            return base.Deposit(amount);
        }
        
        public override decimal interestValue()
        {
            return (Balance * (decimal)INTERESTRATE);
        }

        public override string getAccountDetails()
        {
            return ($"Investment {ID} | Balance: {Balance} | Interest Rate: {INTERESTRATE} | Fee {FEE}");
        }

        public override string accountType()
        {
            return "Investment";
        }
    }

    [Serializable]

    // Interest rates paid only on balances over $1000, overdraft permitted, 
    //  fee for failed transaction.
    public class Omni : Accounts
    {
        public Omni(decimal balance, int customerID)
            : base(balance, customerID)
        {
        }

        // Withdraws the amount provided from the balance.
        // Calculates the fee for invlalid transaction and determines whether customer type has fee reduction.
        public override decimal Withdraw(decimal amount, Customers customer)
        {
            // Incur a fee when amount > balance including overdraft.
            if (amount > Balance + OVERDRAFT)
            {           
                base.Withdraw(FEE * (decimal)customer.FeeReduction, customer);
                // Throw exception with appropriate message with account type..
                throw new InsufficientBalanceException($"Insufficient balance from your Omni account! \n Failed transaction fee applied $ {FEE * (decimal)customer.FeeReduction}");
            }
            return base.Withdraw(amount, customer);
        }

        // Simple deposit method and prints the current account info.
        public override decimal Deposit(decimal amount)
        {
            return base.Deposit(amount);
        }

        // Adds interest for the account when balance is more than 1000.
        public override decimal interestValue()
        {
            decimal interest = 0m;
            if (Balance > 1000m)
                interest = (Balance * (decimal)INTERESTRATE);
            return interest;
        }

        // Prints out the account info.
        // Shows the type of the account, the balance, the interest rate as well as the fee for invalid transactions.
        public override string getAccountDetails()
        {
            return ($"Omni {ID} | Balance: {Balance} | Interest Rate: {INTERESTRATE} | Fee {FEE} | Overdraft {OVERDRAFT}");
        }

        public override string accountType()
        {
            return "Omni";
        }
    }

    /// <summary>
    /// For testing purposes only of the abstract Accounts class.
    /// </summary>
    public class AccountsTestClass : Accounts
    {
        public override string getAccountDetails()
        {
            return "";
        }

        public override decimal interestValue()
        {
            return 0m;
        }

        public override string accountType()
        {
            return "";
        }
    }
}
