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

        //buttons
        private void calculateBtn(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void amount_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    
}
