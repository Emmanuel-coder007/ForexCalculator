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
    }
    
}
