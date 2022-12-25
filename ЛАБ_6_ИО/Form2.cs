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
    public partial class Form2 : Form
    {

        Thread th;
        public Form2()
        {
            InitializeComponent();
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
                double mm, p, N1, p0, pz, Ns, Toch, Ts;
                double t = double.Parse(textBox1.Text.Replace(".", ","));
                double r = double.Parse(textBox2.Text.Replace(".", ","));

                mm = 1 / t;
                p = r / mm;
                N1 = (Math.Pow(p, 2)) / (1 - p);
                p0 = 1 - p;
                pz = 1 - p0;
                Ns = p / (1 - p);
                Toch = Math.Pow(p, 2) / (r * (1 - p));
                Ts = 1 / (mm * (1 - p));

                textBox3.Text = mm.ToString("0.000");
                textBox4.Text = p.ToString("0.000");
                textBox5.Text = N1.ToString("0.000");
                textBox6.Text = p0.ToString("0.000");
                textBox7.Text = pz.ToString("0.000");
                textBox8.Text = Ns.ToString("0.000");
                textBox9.Text = Toch.ToString("0.000");
                textBox10.Text = Ts.ToString("0.000");
               
                if (Toch > t)
                {
                    textBox12.Text = String.Format("Очевидно, что скорость обслуживания составов на сортировочной станции невысокая, так как время на ожидание обслуживания ({0} ч) превышает время на обслуживание ({1} ч). Для повышения эффективности работы сортировочной горки необходимо уменьшить время обслуживания одного состава или увеличить число сортировочных станций.", Toch.ToString("0.00"), t);
                }
                if (Toch < t)
                {
                    textBox12.Text = String.Format("Очевидно, что скорость обслуживания составов на сортировочной станции высокая, так как время на ожидание обслуживания ({0} ч) не превышает время на обслуживание ({1} ч). Для повышения эффективности работы сортировочной горки необходимо увеличить время обслуживания одного состава или уменьшить число сортировочных станций.", Toch.ToString("0.00"), t);
                }
                }
            else
            {
                label12.Visible = true;
                label12.Text = "Поля должны быть заполнены!";
            }



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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 44 && number != 8 && number != 46)
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
