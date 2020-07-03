using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Drob a;
        Drob b;
        char znak;

        private Drob Fill()
        {
            Drob c;
            if (whole.Text != "")
            {
                c = new Drob(Convert.ToDouble(whole.Text), Convert.ToDouble(numerator.Text),
                    Convert.ToDouble(denominator.Text));
            }
            else
            {
                c = new Drob(Convert.ToDouble(numerator.Text),
                    Convert.ToDouble(denominator.Text));
            }
            return c;
        }
        private void Amount_Click(object sender, EventArgs e) // +
        {
            znak = '+';
            a = Fill();
            string rezult = a.ToString() + " + ";
            rez.Text = rezult;
            whole.Clear();
            numerator.Clear();
            denominator.Clear();
        }

        private void Result_Click(object sender, EventArgs e) // =
        {
            Drob d = new Drob ();
            switch (znak)
            {
                case '+':
                    b = Fill();
                    d = a + b;
                    Drob.SetFormat(d);
                    rez.Text += b.ToString() + " = " + d.ToString();
                    break;

                case '-':
                    b = Fill();
                    d = a - b;
                    Drob.SetFormat(d);
                    rez.Text += b.ToString() + " = " + d.ToString();
                    break;

                case '*':
                    b = Fill();
                    d = a * b;
                    Drob.SetFormat(d);
                    rez.Text += b.ToString() + " = " + d.ToString();
                    break;

                case '/':
                    b = Fill();
                    d = a / b;
                    Drob.SetFormat(d);
                    rez.Text += b.ToString() + " = " + d.ToString();
                    break;

                case '√':
                    d = a.sqrt();
                    rez.Text += " = " + d.ToString();
                    break;

                case '^':
                    int u = Convert.ToInt32(pow.Text);
                    d = a.Pow(u);
                    rez.Text += u.ToString() + " = " + d.ToString();
                    break;
            }
        }

        private void Sqrt_Click(object sender, EventArgs e) // корень
        {
            znak = '√';
            a = Fill();
            string rezult = "√ " + a.ToString();
            rez.Text = rezult;
        }

        private void Power_Click(object sender, EventArgs e) // степень 
        {
            znak = '^';
            a = Fill();
            pow.Enabled = true;
            string rezult = a.ToString() + "^";
            rez.Text = rezult;
        }

        private void Difference_Click(object sender, EventArgs e) // -
        {
            znak = '-';
            a = Fill();
            string rezult = a.ToString() + " - ";
            rez.Text = rezult;
            whole.Clear();
            numerator.Clear();
            denominator.Clear();
        }

        private void Composition_Click(object sender, EventArgs e) // *
        {
            znak = '*';
            a = Fill();
            string rezult = a.ToString() + " * ";
            rez.Text = rezult;
            whole.Clear();
            numerator.Clear();
            denominator.Clear();
        }

        private void Private_Click(object sender, EventArgs e) // /
        {
            znak = '/';
            a = Fill();
            string rezult = a.ToString() + " /";
            rez.Text = rezult;
            whole.Clear();
            numerator.Clear();
            denominator.Clear();
        }

        private void Clear_Click(object sender, EventArgs e) // очистить 
        {
            whole.Clear();
            numerator.Clear();
            denominator.Clear();
            pow.Clear();
            rez.Clear();
        }
    }
}
