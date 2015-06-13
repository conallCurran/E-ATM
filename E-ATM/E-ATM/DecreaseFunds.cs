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
    public partial class DecreaseFunds : Form
    {
        public DecreaseFunds()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int initial = BankAtm.GetBalance();
            BankAtm.DecreaseBalance(Convert.ToInt32(richTextBox1.Text));
            MessageBox.Show("Balance Decreased from " + initial.ToString("C") + " to " + BankAtm.GetBalance().ToString("C"));
            Hide();
        }

        public static double _intialDeposit { get; set; }

        public static int Deposit { get; set; }
    }
}
