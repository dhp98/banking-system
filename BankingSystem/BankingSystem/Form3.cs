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
    public partial class Form3 : Form
    {

        //ministatement
        double b, d, w;
        public Form3()
        {
            b = Shared.bal;
            d = Shared.dep;
            w = Shared.with;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        { 

            
                listBox1.Items.Add("Balance :" + b);
                listBox1.Items.Add("Deposit:" + d);
                listBox1.Items.Add("Withdraw : " + w);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Thank You for using this bank");
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(Shared.usrname, Shared.pass);
            f2.Show();
            this.Close();
        }
    }
}
