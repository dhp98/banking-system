using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class Form2 : Form
    {
        public Form2(string u , string p)
        {
            Shared.usrname = u;
            Shared.pass = p;
            InitializeComponent();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Shared.usrname;
            label2.Text = Shared.pass;

            if (Shared.usrname == "student")
            {

                textBox1.Text = (Shared.bal).ToString();

            }
            if (Shared.usrname == "dhyey")
            {
                textBox1.Text = (Shared.bal).ToString();
            }

         
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                Shared.dep = 0;
            }
            if (textBox1.Text == "")
            {
                Shared.with = 0;
            }
            Shared.bal = Shared.bal - Shared.with;
            Shared.bal = Shared.bal + Shared.dep;
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                Shared.with = Convert.ToDouble(textBox3.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text!="")
            {
                Shared.dep = Convert.ToDouble(textBox2.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
