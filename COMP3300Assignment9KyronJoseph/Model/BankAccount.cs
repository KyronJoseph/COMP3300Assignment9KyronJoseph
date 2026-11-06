using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9KyronJoseph.Model
{
    /// <summary>
    /// this class will be a model to read in bank account information
    /// </summary>
    public class BankAccount
    {
        public String OwnerName { get; set; }

        public double CurrentBalance { get; set; }

        public String MonthOpened { get; set; }

        public String Type { get; set; }

        public Double MonthlyInterestRate { get; set; }

        /// <summary>
        /// constructor for Bank Account Class
        /// </summary>
        public BankAccount()
        {

        }

        /// <summary>
        /// this method will make a String representation of Bank Account
        /// </summary>
        /// <returns></returns>
        public String ToString()
        {
            return $"Name: {OwnerName}, Balance: {CurrentBalance}, Month Opened: {MonthOpened}, Monthly Interest Rate: {MonthlyInterestRate}";
        }

    }
}
