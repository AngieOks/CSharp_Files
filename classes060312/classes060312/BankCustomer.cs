using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classes060312
{
    class BankCustomer
    {
       
        private int accountNum;
        private string firstName;
        private string lastName;
        private double balance;

        // first constructor
        public BankCustomer()
        {
            accountNum = 0;
            firstName = "";
            lastName = "";
            balance = 0.0;
        }

        // second constructor
        public BankCustomer(int accValue, string firstNameVal, 
                            string lastNameVal)
        {
            accountNum = accValue;
            firstName = firstNameVal;
            lastName = lastNameVal;
            balance = 0.0;
        }

        // third constructor
        public BankCustomer( int accValue, string firstNameVal, 
                             string lastNameVal, double balanceValue)
        {   accountNum = accValue;
            firstName = firstNameVal;
            lastName = lastNameVal;
            balance = balanceValue;
        }

        public int AccountNum
        {
            get
            {
                return accountNum;
            }

            set
            {
                accountNum = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string bankCustomerToString()
        {
            return (Convert.ToString(accountNum) + " " + firstName + 
                    " " + lastName + " " + Convert.ToString(balance));
        }

    }
}
