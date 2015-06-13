using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ATM
{
    public partial class AddFunds : Form
    {
        public AddFunds()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int initial = BankAtm.GetBalance();
            BankAtm.IncreaseBalance(Convert.ToInt32(richTextBox1.Text));
            MessageBox.Show("Balance increased from " + initial.ToString("C") + " to " + BankAtm.GetBalance().ToString("C"));
            Hide();
        }

        public void richTextBox1_TextChanged(int initialDeposit)
        {
            
            
            
        }

        public static double _intialDeposit { get; set; }

        public static int Deposit { get; set; }
    }
}
