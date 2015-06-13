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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            saveFileDialog1.Filter = @"Text Files | *.txt";
            saveFileDialog1.DefaultExt = "txt";

        }

        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void textBox3_TextChanged(object sender, EventArgs e){}
        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}

        //First Name is Entered
        private void Login1()
        {
            
            
        }
        

        //Second Name is Entered
        private void Login2()
        {
            
        }
        
        //Button
        private void button2_Click_1(object sender, EventArgs e)
        {
            string[] users = File.ReadAllLines(@"users.txt").ToArray();
            bool userFound = false;
            for(int i = 0; i < users.Length; i++)
            {
                string[] spiltString = users[i].Split('~');
                if(textBox1.Text == spiltString[0] && textBox2.Text == spiltString[1])
                {
                    userFound = true;
                    BankAtm.SetBalance(Convert.ToInt32(spiltString[2]));
                    BankAtm.Name = spiltString[0] + " " + spiltString[1];
                    break;
                }
            }

            if(userFound)
            {
                Customer main = new Customer();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }

    
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
       
    }
}
