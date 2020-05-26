using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(textBox101.Text);
            int tax;
            if (salary <= 150000)
            {
                tax = 0;
                textBox202.Text = tax.ToString();
            }
            else if (salary <= 300000)
            {
                tax = (salary * 5) / 100;//5%
                textBox202.Text = tax.ToString();
            }
            else if (salary <= 500000)
            {
                tax = (salary * 10) / 100;//10%
                textBox202.Text = tax.ToString();
            }
            else if (salary <= 750000)
            {
                tax = (salary * 15) / 100; //15%
                textBox202.Text = tax.ToString();
            }
            else if (salary <= 1000000)
            {
                tax = (salary * 20) / 100; //20%
                textBox202.Text = tax.ToString();
            }
            else if (salary <= 2000000)
            {
                tax = (salary * 25) / 100; //25%
                textBox202.Text = tax.ToString();
            }
            else if (salary <= 5000000)
            {
                tax = (salary * 30) / 100;//30%
                textBox202.Text = tax.ToString();
            }
            else
            {
                tax = (salary * 35) / 100;//35%
                textBox202.Text = tax.ToString();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
