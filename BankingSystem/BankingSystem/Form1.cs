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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int flag1=0,flag=0;

            string[] s =new string[] {"student", "dhyey"};
            string[] s1 =new string[]{"123" , "22111998"};

            if(textBox1.Text=="" || textBox2.Text==""){
                    MessageBox.Show("Enter valid Credentials");
                    return;
            }else{
                int i;
                for (i = 0; i < s.Length; i++)
                {
                    if (textBox1.Text == s[i])
                    {
                        flag = 1;
                        break;
                    }
                }
                    if(textBox2.Text == s1[i]){
                    flag1 = 1;
                    }
               
            }
            if(flag==1 && flag1==1){

                if (textBox1.Text == "student")
                {
                    Shared.bal = 12000.0;
                }
                else
                {
                    Shared.bal = 30000.0;

                }
               Form2 form2 = new Form2(textBox1.Text, textBox2.Text);
               form2.Show();
                this.Hide();
                
            }else{
                MessageBox.Show("Sorry! wrong usrname or password");
            }      

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public static class Shared
    {
        public static string usrname;
        public static string pass;
        public static double bal;
        public static double dep;
        public static double with;
        public static string[] s=new string[5];
        public static int count=0;
    }
    
}
