using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String g = "Гость";
            String a = "Администратор";
            String p = "Пользователь";
            String lg = "gos";
            String la = "adm";
            String lp = "pol";
            String ap = "abc";
            String pp = "abc1";

            if (comboBox1.Text == g)
            {
                if (textBox2.Text == lg)
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
               
            }
            else if (comboBox1.Text == a)
            {
                if (textBox2.Text == la)
                {
                    if (textBox1.Text == ap)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                    }
                }
            }
            else if (comboBox1.Text == p)
            {
                if (textBox2.Text == lp)
                {
                    if (textBox1.Text == pp)
                    {
                        Form4 f4 = new Form4();
                        f4.Show();
                        this.Hide();
                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String g = "Гость";
            if (comboBox1.Text == g)
            {

                textBox1.ReadOnly = true;
            }
            else
            {
                textBox1.ReadOnly = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    

