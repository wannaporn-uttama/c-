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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(textBox1.Text);//รายรับ
            int other = int.Parse(textBox9.Text);
            int bonus = int.Parse(textBox10.Text);
            int total1;
            total1 = (salary * 12) + other + bonus;
            textBox11.Text = total1.ToString();


            int pay = int.Parse(textBox11.Text);//รายจ่าย
            int pay1;
            if (pay <= 200000)
            {
                pay1 = pay / 2;
                textBox7.Text = pay1.ToString();
            }
            else
            {
                textBox7.Text = "100000";
            }

            int a11 = int.Parse(numericUpDown1.Text);//บุตรเกิดก่อน61
            int a2 = int.Parse(numericUpDown2.Text);//บุตรเกิดหลัง61
            int a3 = int.Parse(textBox2.Text);//ค่าฝากครรภ์
            int a4 = int.Parse(textBox3.Text);//อุปการะคนพิการ
            int a5;
            int a6;
            int m = 0;
            int n = 0;
            int o = 0;
            int p = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int v = 0;
            int w = 0;
            int x = 60000;//ตนเอง
            int total;
            if (checkBox9.Checked)
            {
                m = 0;
            }
            if (checkBox10.Checked)
            {
                n = 0;
            }
            if (checkBox11.Checked)
            {
                o = 60000;
            }
            if (checkBox1.Checked)
            {
                p = 0;
            }
            if (checkBox4.Checked)
            {
                s = 0;
            }
            if (checkBox5.Checked)
            {
                t = 30000;
            }
            if (checkBox6.Checked)
            {
                u = 30000;
            }
            if (checkBox7.Checked)
            {
                v = 30000;
            }
            if (checkBox8.Checked)
            {
                w = 30000;
            }
            a5 = a11 * 30000;
            a6 = a2 * 60000;

            total = a3 + a4 + a5 + a6 + m + n + o + p + s + t + u + v + w + x;
            textBox4.Text = total.ToString();

            int b1 = int.Parse(textBox11.Text);//รายได้พึงประเมิน
            int b2 = int.Parse(textBox7.Text);//รายจ่าย / ปี
            int b3 = int.Parse(textBox4.Text); //ภาษีที่ลดหย่อนได้
            int outcome;
            outcome = (b1 - b2) - b3;
            t11.Text = outcome.ToString();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.t1.Text = t11.Text;
            a.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
