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
    public partial class Form4 : Form
    {
		Thread th;
		public Form4()
        {
            InitializeComponent();
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

			if (label16.Visible)
			{
				label16.Visible = false;
			}
			if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text)
					&& !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text)
					&& !string.IsNullOrEmpty(textBox12.Text) && !string.IsNullOrWhiteSpace(textBox12.Text)
					&& !string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrWhiteSpace(textBox13.Text))

			{

				double mm, potk, Q, A, N1, Toch, K, Ns, Ts;

				double t = double.Parse(textBox1.Text.Replace(".", ","));
				double r = double.Parse(textBox2.Text.Replace(".", ","));
				double n = double.Parse(textBox12.Text.Replace(".", ","));
				double m = double.Parse(textBox13.Text.Replace(".", ","));
				double p0 = 0;


				double p = t * r;
				if (Math.Ceiling(p) <= 10)
				{

					mm = 1 / t;
					if (n == 1)
					{
						p0 = Math.Pow(1 + (Math.Pow(p, 1) / fact(1)) + (Math.Pow(p, n + 1) * Math.Pow(1 - (p / n), m)) / (n * fact(n) * (1 - (p / n))), -1);
					}

					if (n == 2)
					{
						p0 = Math.Pow(1 + (Math.Pow(p, 1) / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, n + 1) * Math.Pow(1 - (p / n), m)) / (n * fact(n) * (1 - (p / n))), -1);
					}

					if (n == 3)
					{
						p0 = Math.Pow(1 + (Math.Pow(p, 1) / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, n + 1) * Math.Pow(1 - (p / n), m)) / (n * fact(n) * (1 - (p / n))), -1);
					}

					if (n == 4)
					{
						p0 = Math.Pow(1 + (Math.Pow(p, 1) / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, n + 1) * Math.Pow(1 - (p / n), m)) / (n * fact(n) * (1 - (p / n))), -1);
					}

					if (n == 5)
					{
						p0 = Math.Pow(1 + (Math.Pow(p, 1) / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + (Math.Pow(p, n + 1) * Math.Pow(1 - (p / n), m)) / (n * fact(n) * (1 - (p / n))), -1);
					}

					if (n == 6)
					{
						p0 = Math.Pow(1 + (Math.Pow(p, 1) / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + (Math.Pow(p, 6) / fact(6)) + (Math.Pow(p, n + 1) * Math.Pow(1 - (p / n), m)) / (n * fact(n) * (1 - (p / n))), -1);
					}

					if (n == 7)
					{
						p0 = Math.Pow(1 + (Math.Pow(p, 1) / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + (Math.Pow(p, 6) / fact(6)) + (Math.Pow(p, 7) / fact(7)) + (Math.Pow(p, n + 1) * Math.Pow(1 - (p / n), m)) / (n * fact(n) * (1 - (p / n))), -1);
					}

					if (n == 8)
					{
						p0 = Math.Pow(1 + (Math.Pow(p, 1) / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + (Math.Pow(p, 6) / fact(6)) + (Math.Pow(p, 7) / fact(7)) + (Math.Pow(p, 8) / fact(8)) + (Math.Pow(p, n + 1) * Math.Pow(1 - (p / n), m)) / (n * fact(n) * (1 - (p / n))), -1);
					}

					if (n == 9)
					{
						p0 = Math.Pow(1 + (Math.Pow(p, 1) / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + (Math.Pow(p, 6) / fact(6)) + (Math.Pow(p, 7) / fact(7)) + (Math.Pow(p, 8) / fact(8)) + (Math.Pow(p, 9) / fact(9)) + (Math.Pow(p, n + 1) * Math.Pow(1 - (p / n), m)) / (n * fact(n) * (1 - (p / n))), -1);
					}

					if (n == 10)
					{
						p0 = Math.Pow(1 + (Math.Pow(p, 1) / fact(1)) + (Math.Pow(p, 2) / fact(2)) + (Math.Pow(p, 3) / fact(3)) + (Math.Pow(p, 4) / fact(4)) + (Math.Pow(p, 5) / fact(5)) + (Math.Pow(p, 6) / fact(6)) + (Math.Pow(p, 7) / fact(7)) + (Math.Pow(p, 8) / fact(8)) + (Math.Pow(p, 9) / fact(9)) + (Math.Pow(p, 10) / fact(10)) + (Math.Pow(p, n + 1) * Math.Pow(1 - (p / n), m)) / (n * fact(n) * (1 - (p / n))), -1);
					}


					potk = (Math.Pow(p, n + m) / (Math.Pow(n, m) * fact(n))) * p0;

					Q = 1 - potk;

					A = r * Q;

					N1 = ((Math.Pow(p, n + 1) * p0) * (1 - (m + 1 - m * (p / n)) * (Math.Pow(p / n, m)))) / ((n * fact(n)) * (Math.Pow(1 - (p / n), 2)));

					Toch = N1 / r;

					K = p * ((1 - ((Math.Pow(p, m + n)) / (Math.Pow(n, m) * fact(n)) * p0)));

					Ns = N1 + K;

					Ts = Ns / r;


					textBox14.Text = mm.ToString("0.000");
					textBox11.Text = p.ToString("0.000");
					textBox6.Text = p0.ToString("0.000");
					textBox3.Text = potk.ToString("0.000");
					textBox4.Text = Q.ToString("0.000");
					textBox5.Text = A.ToString("0.000");
					textBox7.Text = N1.ToString("0.000");
					textBox8.Text = Toch.ToString("0.000");
					textBox9.Text = K.ToString("0.000");
					textBox10.Text = Ns.ToString("0.000");
					textBox15.Text = Ts.ToString("0.000");

					if (p0 > 0 && Toch > 0 && K > 0)
					{

						textBox16.Text = String.Format("Среднее время пребывания состава в ожидании разгрузки на другой станции невелико. Это говорит о нормальной работе выгрузочного узла.");
					}

				}
				else
				{

					label16.Visible = true;
					label16.Text = "Мы пока не можем решить эту задачу!";
				}

			}
			else
			{
				label16.Visible = true;
				label16.Text = "Поля должны быть заполнены!";
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

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
			char number = e.KeyChar;
			if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 44 && number != 8 && number != 46)
			{
				e.Handled = true;

			}
		}

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
			char number = e.KeyChar;
			if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 44 && number != 8 && number != 46)
			{
				e.Handled = true;

			}
		}


    }
}
