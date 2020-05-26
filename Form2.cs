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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int Social = int.Parse(textBox4.Text);//ประกันสังคม
                if (Social <= 9000)
                {
                    a.Text = Social.ToString();
                }
                else
                {
                    a.Text = "9000";
                }
            }
            if (checkBox2.Checked)//ชีวิต
            {
                int Life = int.Parse(textBox5.Text);
                if (Life <= 100000)
                {
                    b.Text = Life.ToString();
                }
                else
                {
                    b.Text = "100000";
                }
            }
            if (checkBox3.Checked)
            {
                int health = int.Parse(b.Text);//สุขภาพ
                int Life;
                if (health <= 100000)
                {
                    Life = 100000 -health;
                    c.Text = Life.ToString();

                    if (Life <= 15000)
                    {
                        c.Text = Life.ToString();
                    }
                    else
                    {
                        c.Text = "15000";
                    }
                }
                if (checkBox4.Checked)
                {
                    int md = int.Parse(textBox7.Text);//พ่อแม่
                    if (md <= 15000)
                    {
                        d.Text = md.ToString();
                    }
                    else
                    {
                        d.Text = "15000";
                    }
                }
                if (checkBox5.Checked)//คู่สมรส
                {
                    int Spouse = int.Parse(textBox8.Text);
                    if (Spouse <= 10000)
                    {
                        e5.Text = Spouse.ToString();
                    }
                    else
                    {
                        e5.Text = "10000";
                    }
                }
                if (checkBox6.Checked)//เลี้ยงชีพ
                {
                    int live = int.Parse(textBox9.Text);
                    if (live <= 10000)
                    {
                        f.Text = live.ToString();
                    }
                    else
                    {
                        f.Text = "10000";
                    }
                }
                if (checkBox7.Checked)//กบข
                {
                    int gbk = int.Parse(textBox10.Text);
                    if (gbk <= 500000)
                    {
                        g.Text = gbk.ToString();
                    }
                    else
                    {
                        g.Text = "500000";
                    }
                }
                int p;
                int aa = int.Parse(a.Text);
                int ab = int.Parse(b.Text);
                int ac = int.Parse(c.Text);
                int ad = int.Parse(d.Text);
                int ae = int.Parse(e5.Text);
                int af = int.Parse(f.Text);
                int ag = int.Parse(g.Text);
                p = aa + ab + ac + ad + ae + af + ag;
                textBox11.Text = p.ToString();

                int a1 = int.Parse(t1.Text);//รายได้สุทธิ
                int tax = int.Parse(textBox11.Text);
                int tt;
                tt = a1 - tax;
                tt1.Text = tt.ToString();

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.textBox1.Text = tt1.Text;
            a.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox5.Enabled = false;
                textBox8.Enabled = false;
            }
            else
            {
                checkBox5.Enabled = true;
                textBox8.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkBox5.Enabled = false;
                textBox8.Enabled = false;
            }
            else
            {
                checkBox5.Enabled = true;
                textBox8.Enabled = true;
            }
        }
    }
}
