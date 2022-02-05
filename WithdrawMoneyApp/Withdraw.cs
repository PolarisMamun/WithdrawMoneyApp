using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithdrawMoneyApp
{
    public partial class Withdraw : Form
    {
        CustomerInformation customerInformation = new CustomerInformation();
        
        
        public Withdraw()
        {
            
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerNametextBox.Text) && string.IsNullOrEmpty(customerAddresstextBox.Text))
            {
                MessageBox.Show("Please Enter Customer Information");
            }
            else if (string.IsNullOrEmpty(customerNametextBox.Text))
            {
                MessageBox.Show("Please Enter Customer Name");
            }
            else if (string.IsNullOrEmpty(customerAddresstextBox.Text))
            {
                MessageBox.Show("Please Enter Customer Address");
            }
            
            else
            {
                customerInformation.CustomerName = customerNametextBox.Text;
                customerInformation.CustomerAddress = customerAddresstextBox.Text;
                amountTextBox.Enabled = true;
                withdrawButton.Enabled = true;
                depositButton.Enabled = true;
            }
            
            
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(amountTextBox.Text))
            {
                MessageBox.Show("Please Enter Amount");
            }
            else
            {
                customerInformation.DepositMoney(Convert.ToDouble(amountTextBox.Text));
                totalAmounttextBox.Text = customerInformation.Amount.ToString();
            }
            
            
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amountTextBox.Text))
            {
                MessageBox.Show("Please Deposit Amount");
            }
           else if (customerInformation.Amount > 0)
            {
                customerInformation.WithdrawMoney(Convert.ToDouble(amountTextBox.Text));
                totalAmounttextBox.Text = customerInformation.Amount.ToString();
            }
            else
            {
                MessageBox.Show("No Amount Available");
            }
            
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            amountTextBox.Enabled = false;
            withdrawButton.Enabled = false;
            depositButton.Enabled = false;
        }
    }
}
