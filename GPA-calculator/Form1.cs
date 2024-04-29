using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            noright();
            noexam();
            elb1 = main7.Text;
            elb2 = dop1.Text;
            elb3 = prof2.Text;
            elb4 = prof1.Text;
            elb5 = add1.Text;
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        
        string elb1, elb2, elb3, elb4, elb5;
        string[] gr = new string[65];
        float[] sm = new float[17];
        int[] exm = new int[11];
        float sum;
        int sum1;
        int nurasik, selector;
        int j, n = 0;
        int madi;


        private void m1_TextChanged(object sender, EventArgs e) { gr[1] = m1.Text; Console.WriteLine(gr[1]); }
        private void m2_TextChanged(object sender, EventArgs e) { gr[2] = m2.Text; }
        private void m3_TextChanged(object sender, EventArgs e) { gr[3] = m3.Text; }
        private void m4_TextChanged(object sender, EventArgs e) { gr[4] = m4.Text; }
        private void m5_TextChanged(object sender, EventArgs e) { gr[5] = m5.Text; }
        private void m6_TextChanged(object sender, EventArgs e) { gr[6] = m6.Text; }
        private void m7_TextChanged(object sender, EventArgs e) { gr[7] = m7.Text; }
        private void m8_TextChanged(object sender, EventArgs e) { gr[8] = m8.Text; }
        private void m9_TextChanged(object sender, EventArgs e) { gr[9] = m9.Text; }
        private void m10_TextChanged(object sender, EventArgs e) { gr[10] = m10.Text; }
        private void m11_TextChanged(object sender, EventArgs e) { gr[11] = m11.Text; }
        private void m12_TextChanged(object sender, EventArgs e) { gr[12] = m12.Text; }
        private void m13_TextChanged(object sender, EventArgs e) { gr[13] = m13.Text; }
        private void m14_TextChanged(object sender, EventArgs e) { gr[14] = m14.Text; }
        private void m15_TextChanged(object sender, EventArgs e) { gr[15] = m15.Text; }
        private void m16_TextChanged(object sender, EventArgs e) { gr[16] = m16.Text; }
        private void m17_TextChanged(object sender, EventArgs e) { gr[17] = m17.Text; }
        private void m18_TextChanged(object sender, EventArgs e) { gr[18] = m18.Text; }
        private void m19_TextChanged(object sender, EventArgs e) { gr[19] = m19.Text; }
        private void m20_TextChanged(object sender, EventArgs e) { gr[20] = m20.Text; }
        private void m21_TextChanged(object sender, EventArgs e) { gr[21] = m21.Text; }
        private void m22_TextChanged(object sender, EventArgs e) { gr[22] = m22.Text; }
        private void m23_TextChanged(object sender, EventArgs e) { gr[23] = m23.Text; }
        private void m24_TextChanged(object sender, EventArgs e) { gr[24] = m24.Text; }
        private void m25_TextChanged(object sender, EventArgs e) { gr[25] = m25.Text; }
        private void m26_TextChanged(object sender, EventArgs e) { gr[26] = m26.Text; }
        private void m27_TextChanged(object sender, EventArgs e) { gr[27] = m27.Text; }
        private void m28_TextChanged(object sender, EventArgs e) { gr[28] = m28.Text; }
        private void m29_TextChanged(object sender, EventArgs e) { gr[29] = m29.Text; }
        private void m30_TextChanged(object sender, EventArgs e) { gr[30] = m30.Text; }
        private void m31_TextChanged(object sender, EventArgs e) { gr[31] = m31.Text; }
        private void m32_TextChanged(object sender, EventArgs e) { gr[32] = m32.Text; }
        private void m33_TextChanged(object sender, EventArgs e) { gr[33] = m33.Text; }
        private void m34_TextChanged(object sender, EventArgs e) { gr[34] = m34.Text; }
        private void m35_TextChanged(object sender, EventArgs e) { gr[35] = m35.Text; }
        private void m36_TextChanged(object sender, EventArgs e) { gr[36] = m36.Text; }
        private void m37_TextChanged(object sender, EventArgs e) { gr[37] = m37.Text; }
        private void m38_TextChanged(object sender, EventArgs e) { gr[38] = m38.Text; }
        private void m39_TextChanged(object sender, EventArgs e) { gr[39] = m39.Text; }
        private void m40_TextChanged(object sender, EventArgs e) { gr[40] = m40.Text; }
        private void m41_TextChanged(object sender, EventArgs e) { gr[41] = m41.Text; }
        private void m42_TextChanged(object sender, EventArgs e) { gr[42] = m42.Text; }
        private void m43_TextChanged(object sender, EventArgs e) { gr[43] = m43.Text; }
        private void m44_TextChanged(object sender, EventArgs e) { gr[44] = m44.Text; }
        private void m45_TextChanged(object sender, EventArgs e) { gr[45] = m45.Text; }
        private void m46_TextChanged(object sender, EventArgs e) { gr[46] = m46.Text; }
        private void m47_TextChanged(object sender, EventArgs e) { gr[47] = m47.Text; }
        private void m48_TextChanged(object sender, EventArgs e) { gr[48] = m48.Text; }
        private void m49_TextChanged(object sender, EventArgs e) { gr[49] = m49.Text; }
        private void m50_TextChanged(object sender, EventArgs e) { gr[50] = m50.Text; }
        private void m51_TextChanged(object sender, EventArgs e) { gr[51] = m51.Text; }
        private void m52_TextChanged(object sender, EventArgs e) { gr[52] = m52.Text; }
        private void m53_TextChanged(object sender, EventArgs e) { gr[53] = m53.Text; }
        private void m54_TextChanged(object sender, EventArgs e) { gr[54] = m54.Text; }
        private void m55_TextChanged(object sender, EventArgs e) { gr[55] = m55.Text; }
        private void m56_TextChanged(object sender, EventArgs e) { gr[56] = m56.Text; }
        private void m57_TextChanged(object sender, EventArgs e) { gr[57] = m57.Text; }
        private void m58_TextChanged(object sender, EventArgs e) { gr[58] = m58.Text; }
        private void m59_TextChanged(object sender, EventArgs e) { gr[59] = m59.Text; }
        private void m60_TextChanged(object sender, EventArgs e) { gr[60] = m60.Text; }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    noright();
                    noexam();
                    defsubj();
                    break;
                case 1:
                    noright();
                    noexam();
                    defsubj();
                    break;
                case 2:
                    yesright();
                    noexam();
                    defsubj();
                    break;
                case 3:
                    noright();
                    yesexam();
                    defsubj();
                    break;
                case 4:
                    noright();
                    elevenexam();
                    elevensubj();
                    break;
                default:
                    break;
            }
        }

        private void defsubj()
        {
            main7.Text = elb1;
            dop1.Text = elb2;
            prof2.Text = elb3;
            prof1.Text = elb4;
            add1.Text = elb5;
            m45.Visible = true;
            m46.Visible = true;
            m47.Visible = true;
            m48.Visible = true;
            m49.Visible = true;
            m50.Visible = true;
            m51.Visible = true;
            m52.Visible = true;
            m53.Visible = true;
            m54.Visible = true;
            m55.Visible = true;
            m56.Visible = true;
            dop2.Visible = true;
            dop3.Visible = true;
            dop4.Visible = true;

        }
        private void elevensubj()
        {
            main7.Text = "Програмирование";
            dop1.Text = "НВП";
            prof2.Text = "Проф. 1";
            prof1.Text = "Проф. 2";
            add1.Text = "Доп. пред.";
            dop2.Visible = false;
            dop3.Visible = false;
            dop4.Visible = false;
            {
                m45.Visible = false;
                m46.Visible = false;
                m47.Visible = false;
                m48.Visible = false;
                m49.Visible = false;
                m50.Visible = false;
                m51.Visible = false;
                m52.Visible = false;
                m53.Visible = false;
                m54.Visible = false;
                m55.Visible = false;
                m56.Visible = false;
            }
        }

        private void elevenexam()
        {
            e1.Visible = true;
            e2.Visible = true;
            e3.Visible = false;
            e4.Visible = false;
            e5.Visible = false;
            z1.Visible = true;
            z2.Visible = true;
            z3.Visible = false;
            z4.Visible = false;
            z5.Visible = false;
            comboBox2.Visible = false;
            z2.Text = "Английский";
            main6.Text = "Английский";
            main2.Text = "История Каз.";
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex) 
            { 
                case 0: seveneight(); itog.Text = "Итог = " + finale(14).ToString(); break;
                case 1: seveneight(); itog.Text = "Итог = " + finale(14).ToString(); break;
                case 2: nine(); itog.Text = "Итог = " + finale(15).ToString(); break;
                case 3: ten(); itog.Text = "Итог = " + finale(14).ToString(); break;
                case 4: eleven(); itog.Text = "Итог = " + finale(11).ToString(); break;
                default: break;
            }
        }

        private void seveneight()
        {
            for (int i = 1; i <= 56; i++)
            {
                bool tf = string.IsNullOrEmpty(gr[i]);
                if (tf == true)
                {
                    MessageBox.Show("Введите все оценки!");
                    break;
                }
                n = 0;
                n = Convert.ToInt32(gr[i]);
                if (n > 5)
                {
                    MessageBox.Show("Недопустимое значение!");
                    break;
                }
                else if (n < 2)
                {
                    MessageBox.Show("Недопустимое значение!");
                    break;
                }
                sum += Convert.ToInt32(gr[i]);
                if (i % 4 == 0)
                {
                    j = i / 4;
                    if (sum > 17)
                    {
                        sm[j] = 5;
                    }
                    else if (sum > 13)
                    {
                        sm[j] = 4;
                    }
                    else if (sum > 9)
                    {
                        sm[j] = 3;
                    }
                    else
                    {
                        sm[j] = 2;
                    }
                    sum = 0;
                }
            }
        }

       public void nine()
        {
            for (int i = 1; i <= 60; i++)
            {
                bool tf = string.IsNullOrEmpty(gr[i]);
                if (tf == true)
                {
                    MessageBox.Show("Введите все оценки! " + i +" "+ gr[i]);
                    break;
                }
                n = 0;
                n = Convert.ToInt32(gr[i]);
                if (n > 5)
                {
                    MessageBox.Show("Недопустимое значение!");
                    break;
                }
                else if (n < 2)
                {
                    MessageBox.Show("Недопустимое значение!");
                    break;
                }
                sum += Convert.ToInt32(gr[i]);
                if (i % 4 == 0)
                {
                    j = i / 4;
                    if (sum > 17)
                    {
                        sm[j] = 5;
                    }
                    else if (sum > 13)
                    {
                        sm[j] = 4;
                    }
                    else if (sum > 9)
                    {
                        sm[j] = 3;
                    }
                    else
                    {
                        sm[j] = 2;
                    }
                    sum = 0;
                }
                
            }
            
        }

        public int selectedsubj;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedsubj = profsubj(comboBox2.SelectedIndex);
        }

        private void ten()
        {
            for (int i = 1; i <= 56; i++)
            {
                bool tf = string.IsNullOrEmpty(gr[i]);
                if (tf == true)
                {
                    MessageBox.Show("Введите все оценки!");
                    break;
                }
                n = 0;
                n = Convert.ToInt32(gr[i]);
                if (n > 5)
                {
                    MessageBox.Show("Недопустимое значение!");
                    break;
                }
                else if (n < 2)
                {
                    MessageBox.Show("Недопустимое значение!");
                    break;
                }
                sum += Convert.ToInt32(gr[i]);
                if (i % 4 == 0)
                {
                    sum1 = Convert.ToInt32(sum);
                    j = i / 4;
                    if (j < 5)
                    {
                        sm[j] = exgrfin(sum1, exm[j]);
                    }
                    else if (j == selectedsubj)
                    {
                        sm[j] = exgrfin(sum1, exm[5]);
                    }
                    else
                    {
                        if (sum > 17)
                        {
                            sm[j] = 5;
                        }
                        else if (sum > 13)
                        {
                            sm[j] = 4;
                        }
                        else if (sum > 9)
                        {
                            sm[j] = 3;
                        }
                        else
                        {
                            sm[j] = 2;
                        }
                    }
                    sum = 0;
                }
            }
        }

        private void eleven()
        {
            for (int i = 1; i <= 44; i++)
            {
                bool tf = string.IsNullOrEmpty(gr[i]);
                if (tf == true)
                {
                    MessageBox.Show("Введите все оценки!");
                    break;
                }
                n = 0;
                n = Convert.ToInt32(gr[i]);
                if (n > 5)
                {
                    MessageBox.Show("Недопустимое значение!");
                    break;
                }
                else if (n < 2)
                {
                    MessageBox.Show("Недопустимое значение!");
                    break;
                }
                sum += Convert.ToInt32(gr[i]);
                if (i % 4 == 0)
                {
                    sum1 = Convert.ToInt32(sum);
                    j = i / 4;
                    if (j < 3)
                    {
                        sm[j] = exgrfin(sum1, exm[j]);
                    }
                    else
                    {
                        if (sum > 17)
                        {
                            sm[j] = 5;
                        }
                        else if (sum > 13)
                        {
                            sm[j] = 4;
                        }
                        else if (sum > 9)
                        {
                            sm[j] = 3;
                        }
                        else 
                        { 
                            sm[j] = 2;
                        }
                    }
                    sum = 0;
                }
                
            }
        }
        private void noright()
        {
            dop5.Visible = false;
            m57.Visible = false;
            m58.Visible = false;
            m59.Visible = false;
            m60.Visible = false;
        }
        private void yesright()
        {
            dop5.Visible = true;
            m57.Visible = true;
            m58.Visible = true;
            m59.Visible = true;
            m60.Visible = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void noexam()
        {
            e1.Visible = false;
            e2.Visible = false;
            e3.Visible = false;
            e4.Visible = false;
            e5.Visible = false;
            z4.Visible = false;
            z3.Visible = false;
            z1.Visible = false;
            z2.Visible = false;
            z5.Visible = false;
            comboBox2.Visible = false;
        }

        private void e1_SelectedIndexChanged(object sender, EventArgs e)
        {
            exm[1] = exgr(e1.SelectedIndex);
        }

        private int exgr(int n)
        {
            switch (n)
            {
                case 0: return 5;
                case 1: return 5;
                case 2: return 5;
                case 3: return 4;
                case 4: return 3;
                case 5: return 2;
                case 6: return 2;
                default: return 0;
            }
        }
        private int exgrfin(int sum, int exam)
        {
            if (exam == 5 && sum > 17)
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case 5 5");
                return 5;
            }
            else if (exam == 5 && sum > 11)
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case 5 4");
                return 4;
            }
            else if (exam == 5 && sum < 12)
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case 5 3");
                return 3;
            }
            else if (exam == 4 && sum > 18)
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case 4 5");
                return 5;
            }
            else if (exam == 4 && sum > 13)
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case 4 4");
                return 4;
            }
            else if (exam == 4 && sum < 14)
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case 4 3");
                return 3;
            }
            else if (exam == 3 && sum > 14)
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case 3 4");
                return 4;
            }
            else if (exam == 3 && sum < 15)
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case 3 3");
                return 3;
            }
            else if (exam == 2 && sum > 16)
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case 2 4");
                return 4;
            }
            else if (exam == 2 && sum > 10)
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case 2 3");
                return 3;
            }
            else if (exam == 2 && sum < 11)
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case 2 2");
                return 2;
            }
            else
            {
                Console.WriteLine(sum + " / " + exam + " / " + "case default");
                return 0;
            }
        }

        private void z2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + ". " + exm[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 1;i <= 60; i++)
            {
                gr[i] = "5";
            }
        }

        private void e2_SelectedIndexChanged(object sender, EventArgs e)
        {
            exm[2] = exgr(e2.SelectedIndex);

        }

        private void e3_SelectedIndexChanged(object sender, EventArgs e)
        {
            exm[3] = exgr(e3.SelectedIndex);
        }

        private void e4_SelectedIndexChanged(object sender, EventArgs e)
        {
            exm[4] = exgr(e4.SelectedIndex);
        }

        private void e5_SelectedIndexChanged(object sender, EventArgs e)
        {
            exm[5] = exgr(e5.SelectedIndex);
        }

        private void yesexam()
        {
            e1.Visible = true;
            e2.Visible = true;
            e3.Visible = true;
            e4.Visible = true;
            e5.Visible = true;
            z4.Visible = true;
            z3.Visible = true;
            z1.Visible = true;
            z2.Visible = true;
            z5.Visible = true;
            comboBox2.Visible = true;
            z2.Text = "История Каз.";
            main2.Text = "Английский";
            main6.Text = "История Каз.";
        }

        private float finale(int madi)
        {
            float kain = 0;
            Console.WriteLine(kain);
            for (int i = 1; i <= madi; i++) 
            {
                kain += sm[i];
            }
            kain /= madi;
            decimal aiba = Math.Round((decimal)kain, 2);
            return (float)aiba;
        }

        private int profsubj (int nurasik)
        {
            int arman = 0;
            switch (nurasik)
            {
                case 0: arman = 7; z5.Text = "Информатика"; break;
                case 1: arman = 8; z5.Text = "Физика"; break;
                case 2: arman = 9; z5.Text = "Химия"; break;
                case 3: arman = 10; z5.Text = "Биология"; break;
                default: break;
            }
            return arman;
        }
    }
}

