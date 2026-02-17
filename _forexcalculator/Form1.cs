using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _forexcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private string riskBtnValue = string.Empty;
        private string buyOrSellValue = string.Empty;

        private decimal riskPercentage;
        private decimal risk_Amount;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            accountBal.Clear();
            risk.Clear();
            slPrice.Clear();
            entryPrice.Clear();
            // Replace invalid curPair.Clear() with proper listbox reset:
            curPair.Items.Clear();
            curPair.Items.AddRange(new object[]
            {
                "EURUSD",
                "GBPUSD",
                "USDJPY",
                "GBPJPY",
                "EURJPY",
                "XAUUSD",
                "XAGUSD",
                "US100",
                "US30"
            });
            curPair.ClearSelected();// ensures no item is selected
            // alternatively: curPair.SelectedIndex = -1;
        }

        private void accountBal_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(accountBal.Text, out _))
            {
                MessageBox.Show("Please enter a valid decimal number for Account Balance.");
                accountBal.Clear();
            }
           
        }

        private void risk_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(risk.Text, out _))
            {
                MessageBox.Show("Please enter a valid decimal number less than or equal to 100 for Risk.");
                risk.Clear();
            }
            else if(riskBtnValue == "percentage" && (decimal.Parse(risk.Text) > 100 || decimal.Parse(risk.Text) < 1))
            {
                MessageBox.Show("Risk percentage cannot be greater than 100 or less than 1.");
                risk.Clear();
            }
        }

        private void entryPrice_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(entryPrice.Text, out _))
            {
                MessageBox.Show("Please enter a valid decimal number for Entry Price.");
                entryPrice.Clear();
            }
        }

        private void slPrice_TextChanged(object sender, EventArgs e)
        {
            if(!decimal.TryParse(slPrice.Text, out _))
            {
                MessageBox.Show("Please enter a valid decimal number for Stop Loss Price.");
                slPrice.Clear();
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void amount_CheckedChanged(object sender, EventArgs e)
        {
            riskBtnValue = "amount";
        }

        private void percentage_CheckedChanged(object sender, EventArgs e)
        {
            riskBtnValue = "percentage";
        }

        private void buy_CheckedChanged(object sender, EventArgs e)
        {
            buyOrSellValue = "buy";
        }

        private void sell_CheckedChanged(object sender, EventArgs e)
        {
            buyOrSellValue = "sell";
        }


        //buttons
        private void calculateBtn(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(accountBal.Text) || string.IsNullOrEmpty(risk.Text) || string.IsNullOrEmpty(entryPrice.Text))
            {
                MessageBox.Show("Please don't leave the important spaces empty calculating.");
                return;
            }
            switch (riskBtnValue)
            {
                case "amount":
                    // Implement calculation logic for amount-based risk here
                    MessageBox.Show("Calculating based on amount risk...");
                    risk_Amount = decimal.Parse(risk.Text); // Placeholder for actual calculated value
                    break;
                case "percentage":
                    // Implement calculation logic for percentage-based risk here
                    MessageBox.Show("Calculating based on percentage risk...");
                    riskPercentage = decimal.Parse(risk.Text) / 100 * decimal.Parse(accountBal.Text);
                    break;
                default:
                    MessageBox.Show("Please select a risk type (Amount or Percentage) before calculating.");
                    break;
            }
        }
    }
    
}
