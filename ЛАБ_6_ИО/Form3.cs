using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ЛАБ_6_ИО
{
    public partial class Form3 : Form
    {
        Thread th;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open(object obj)
        {
            Application.Run(new Form1());
        }

        double fact(double n)
        {
            double F = 1;
            if (n <= 0)
                return 1;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                    F = F * i;

            }
            return F;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            if (label12.Visible)
            {
                label12.Visible = false;
            }
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text)
                    && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))

            {
                double t = double.Parse(textBox1.Text.Replace(".", ","));
                double r = double.Parse(textBox2.Text.Replace(".", ","));
                double p1, N, Toch, Ns, Ts, K, Kd;
                double p0 = 0;

                double p = t * r;

                if (Math.Ceiling(p) <= 10)
                {

                    if (Math.Ceiling(p) == 1)
                    {
                        p0 = Math.Pow((1 + (p / fact(1)) + ((Math.Pow(p, 2)) / (fact(1) * (1 - p)))), -1);
                    }
                    if (Math.Ceiling(p) == 2)
                    {
                        p0 = Math.Pow((1 + (p / fact(1)) + (Math.Pow(p, 2) / fact(2)) + ((Math.Pow(p, 3)) / (fact(2) * (2 - p)))), -1);

                    }

                    if (Math.Ceiling(p) == 3)
                    {
                        p0 = Math.Pow((1 + (p / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + ((Math.Pow(p, 4)) / (fact(3) * (3 - p)))), -1);

                    }

                    if (Math.Ceiling(p) == 4)
                    {
                        p0 = Math.Pow((1 + (p / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + ((Math.Pow(p, 5)) / (fact(4) * (4 - p)))), -1);

                    }
                    if (Math.Ceiling(p) == 5)
                    {
                        p0 = Math.Pow((1 + (p / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + ((Math.Pow(p, 6)) / (fact(5) * (5 - p)))), -1);

                    }

                    if (Math.Ceiling(p) == 6)
                    {
                        p0 = Math.Pow((1 + (p / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + (Math.Pow(p, 6) / fact(6)) + ((Math.Pow(p, 7)) / (fact(6) * (6 - p)))), -1);

                    }

                    if (Math.Ceiling(p) == 7)
                    {
                        p0 = Math.Pow((1 + (p / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + (Math.Pow(p, 6) / fact(6)) + (Math.Pow(p, 7) / fact(7)) + ((Math.Pow(p, 8)) / (fact(7) * (7 - p)))), -1);

                    }

                    if (Math.Ceiling(p) == 8)
                    {
                        p0 = Math.Pow((1 + (p / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + (Math.Pow(p, 6) / fact(6)) + (Math.Pow(p, 7) / fact(7)) + (Math.Pow(p, 8) / fact(8)) + ((Math.Pow(p, 9)) / (fact(8) * (8 - p)))), -1);

                    }
                    if (Math.Ceiling(p) == 9)
                    {
                        p0 = Math.Pow((1 + (p / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + (Math.Pow(p, 6) / fact(6)) + (Math.Pow(p, 7) / fact(7)) + (Math.Pow(p, 8) / fact(8)) + (Math.Pow(p, 9) / fact(9)) + ((Math.Pow(p, 10)) / (fact(9) * (9 - p)))), -1);

                    }

                    if (Math.Ceiling(p) == 10)
                    {
                        p0 = Math.Pow((1 + (p / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + (Math.Pow(p, 6) / fact(6)) + (Math.Pow(p, 7) / fact(7)) + (Math.Pow(p, 8) / fact(8)) + (Math.Pow(p, 9) / fact(9)) + (Math.Pow(p, 10) / fact(10)) + ((Math.Pow(p, 11)) / (fact(10) * (10 - p)))), -1);

                    }




                    p1 = (Math.Pow(p, Math.Ceiling(p) + 1)) / (fact(Math.Ceiling(p)) * ((Math.Ceiling(p) - p))) * p0;

                    N = ((Math.Pow(p, Math.Ceiling(p) + 1)) * p0) / (Math.Ceiling(p) * fact(Math.Ceiling(p)) * (Math.Pow(1 - (p / Math.Ceiling(p)), 2)));

                    Toch = (1 / r) * N;

                    Ns = N + p;

                    Ts = (1 / r) * Ns;

                    K = r / (1 / t);

                    Kd = p / Math.Ceiling(p);



                    textBox6.Text = p0.ToString("0.000");
                    textBox3.Text = p1.ToString("0.000");
                    textBox4.Text = N.ToString("0.000");
                    textBox5.Text = Toch.ToString("0.000");
                    textBox7.Text = Ns.ToString("0.000");
                    textBox8.Text = Ts.ToString("0.000");
                    textBox9.Text = K.ToString("0.000");
                    textBox10.Text = Kd.ToString("0.000");
                    textBox11.Text = p.ToString("0.000");

                    if (p0 > 0 && Toch > 0 && K >0) {

                        textBox12.Text = String.Format("Абсолютная пропускная способность узла расчета А = {0} (1/мин), или {1} (1/ч), т. е. {1} покупатель в час. Анализ характеристик обслуживания свидетельствует о значительной перегрузке узла расчета при наличии {2} кассиров.", r, r * 60, Math.Ceiling(p));
                    }
                }
                else 
                {

                    label12.Visible = true;
                    label12.Text = "Мы пока не можем решить эту задачу!";
                }
            }
            

            else
            {
                label12.Visible = true;
                label12.Text = "Поля должны быть заполнены!";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //запрет на ввод цифр, кнопки BackSpace и запятой
        {
            char number = e.KeyChar;
            if ((e.KeyChar<=47 || e.KeyChar >= 58)&& number !=44 && number != 8 && number != 46)
            {
                e.Handled = true;

            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 44 && number != 8 && number != 46)
            {
                e.Handled = true;

            }
        }
    }
}
