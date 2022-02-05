using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithdrawMoneyApp
{
    public class CustomerInformation
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }        
        public double Amount { get; set; }
        //public double TotalAmount { get; private set; }

        //public string CreateAccount()
        //{

        //}

        public CustomerInformation(string customerName, string customerAddress)
        {
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
        }

        public CustomerInformation(double amount)
        {
            this.Amount = amount;
        }
        public CustomerInformation()
        {

        }
        public double DepositMoney(double amount)
        {
            Amount = Amount + amount;
            return Amount;
        }

        public double WithdrawMoney(double amount)
        {
            Amount = Amount - amount;            
            return Amount;
        }
    }

}
