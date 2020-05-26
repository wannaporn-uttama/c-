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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int home58 = int.Parse(numericUpDown2.Text);//ราคาบ้าน
            int taxhome = int.Parse(home.Text);//ดอกเบี้ยบ้าน
            int tax20;// 20%ของอสังหาริมทรัพย์
            int tax5;//ภาษีที่เฉลี่ย 5 ปี
            int taxtotal;//รวมภาษี
            int total;
            int salary = int.Parse(textBox1.Text);//รายได้สูทธิ

            tax20 = (home58 * 20) / 100;//ภาษีที่ลดหย่อนได้
            a.Text = tax20.ToString();
            tax5 = (tax20 / 5);//เฉลี่ย 5 ปี
            d.Text = tax5.ToString();
            taxtotal = (taxhome + tax5);//รวมลดหย่อนภาษี = ดอกเบี้ยบ้าน+ภาษีเฉลี่ย 5 ปี
            b.Text = taxtotal.ToString();
            total = salary - taxtotal;
            tt2.Text = total.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int home62 = int.Parse(numericUpDown3.Text);//ราคาบ้าน
            int taxhome = int.Parse(home.Text);//ดอกเบี้ยบ้าน
            int sal = int.Parse(textBox1.Text);//รายได้สุทธิ
            int tax;//ภาษีที่ลดหย่อน
            int taxtotal;//รวมภาษี
            int a = 0;
            int tot;

            if (home62 < 200000)
            {
                a = home62;
            }
            else if (home62 < 5000001)
            {
                a = 200000;
            }

            tax = a;//ภาษีที่ลดหย่อนได้
            x.Text = tax.ToString();
            taxtotal = taxhome + a;//รวมภาษีที่ลดหย่อนได้ = ดอกเบี้ยบ้าน+ภาษีที่ลดหย่อน
            y.Text = taxtotal.ToString();
            tot = sal - taxtotal;
            tt2.Text = tot.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.t44.Text = tt2.Text;
            a.Show();
            this.Hide();
        }
    }
}
