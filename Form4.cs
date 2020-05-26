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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(t44.Text);//รายได้สุทธิ
            int study = int.Parse(textBox5.Text);
            int government = int.Parse(textBox6.Text);
            int sport = int.Parse(textBox7.Text);
            int public1 = int.Parse(textBox8.Text);
            int pabuk = int.Parse(textBox9.Text);
            int general = int.Parse(textBox10.Text);
            int politics = int.Parse(numericUpDown1.Text);
            int a1;
            int a2;
            int a3;
            int a4;
            int a5;
            int a6;
            int a7;
            int vat;
            int total;
            int i = 0;

            a1 = (study * 2);
            textBox5.Text = a1.ToString();
            a2 = (government * 2);
            textBox6.Text = a2.ToString();
            a3 = (sport * 2);
            textBox7.Text = a3.ToString();
            a4 = (public1 * 2);
            textBox8.Text = a4.ToString();
            a5 = pabuk;
            textBox9.Text = a5.ToString();
            a6 = general;
            textBox10.Text = a6.ToString();
            a7 = politics;


            vat = (a1 + a2 + a3 + a4 + a5 + a6 + a7);//บริจาค
            int money;
            money = (salary  * 10) / 100;
            if(vat > money)
            {
                i = money;
            }    
            else if(vat < money)
            {
                i = vat;
            }
            textBox18.Text = i.ToString();

            total = salary - i;
            tt3.Text = total.ToString();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.t5.Text = tt3.Text;
            a.Show();
            this.Hide();
        }

        private void t44_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
