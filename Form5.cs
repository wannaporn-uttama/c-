using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(t5.Text);//รายได้สุทธิ
            int help = int.Parse(numericUpDown1.Text);//ช้อปช่วยชาติ
            int studysport = int.Parse(numericUpDown2.Text);//ซื้อสินค้าการศึกษาและกีฬา
            int book = int.Parse(numericUpDown3.Text);//ซื้อหนังสือ
            int otop = int.Parse(numericUpDown4.Text);//ซื้อสินค้าโอทอป
            int travel1 = int.Parse(numericUpDown5.Text);//เที่ยวเมืองหลัก
            int travel2 = int.Parse(numericUpDown6.Text);//เที่ยวเมืองรอง
            int home = int.Parse(numericUpDown7.Text);//ค่าซ่อมบ้าน
            int car = int.Parse(numericUpDown8.Text);//ค่าซ่อมรถ
            int tax;//ภาษีที่ลดหย่อนได้
            int x = 0;
            int y = 0;
            int total;

            if ((travel1 + travel2) < 20000)
            {
                x = (travel1 + travel2);
            }
            else if ((travel1 + travel2) > 20001)
            {
                x = 20000;
            }
            if ((home + car) < 100000)
            {
                y = (home + car);
            }
            else if ((home + car) > 100001)
            {
                y = 100000;
            }

            tax = help + studysport + book + otop + x + y;//บริจาค
            textBox5.Text = tax.ToString();
          

            total = money - tax;
            tt4.Text = total.ToString();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.textBox101.Text = tt4.Text;
            a.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
