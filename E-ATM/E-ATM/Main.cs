using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ATM
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            saveFileDialog1.Filter = @"Text Files | *.txt";
            saveFileDialog1.DefaultExt = "txt";
            string content = File.ReadAllText(@"Login1.txt");
            Address.Text = content;
            lblName.Text = BankAtm.Name;
            TotalTxtBx.Text = BankAtm.GetBalance().ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void Information_TextChanged(object sender, EventArgs e)
        {
             
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            AddFunds addfunds = new AddFunds();
            addfunds.ShowDialog();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            TotalTxtBx.Text = BankAtm.GetBalance().ToString("C");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DecreaseFunds decreasefunds = new DecreaseFunds();
            decreasefunds.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Address_TextChanged(object sender, EventArgs e)
        {
            string location = @"Login1.txt";
            FileStream filestream = new FileStream(location, FileMode.Open, FileAccess.Read);
            byte[] buffer;
            int length = (int)filestream.Length;
            buffer = new byte[length];
            int count;
            int sum = 0;

            while ((count = filestream.Read(buffer, sum, length - sum)) > 0)
            {
                sum += count;
            }
        }

        
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = saveFileDialog1.FileName;
            FileStream wFile;
            wFile = new FileStream(fileName, FileMode.Create);
            byte[] byteData;
            var text = " " + "Total Amount" + TotalTxtBx.Text.Replace("\n", Environment.NewLine) + "\r\n " + "Account Number" + AccountNumber.Text.Replace("\n", Environment.NewLine) + "\r\n " + "Sort Code" + SortCode.Text.Replace("\n", Environment.NewLine);
            byteData = Encoding.ASCII.GetBytes(text);

            wFile.Write(byteData, 0, byteData.Length);
            saveFileDialog1.FileName = "";
            wFile.Close();
        }
    }
}
