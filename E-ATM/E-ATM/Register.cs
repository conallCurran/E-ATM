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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string box1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string box2 = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string box3 = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string box4 = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string box5 = textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Text = textBox1.Text + "~" + textBox2.Text + "~" + textBox5.Text;
            string Line = textBox3.Text + " " + textBox4.Text;
            System.IO.File.WriteAllText(@"users.txt",Text);
            System.IO.File.WriteAllText(@"Login1.txt", Line);

            Login login = new Login();
            login.ShowDialog();
            this.Close();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        

        
    }
}
