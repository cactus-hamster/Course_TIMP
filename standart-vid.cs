using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polinom;

namespace Курсовая
{
    public partial class standart_vid : Form
    {
        Form1 form1;
        public standart_vid(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (textBox1.Text.Contains('/') || textBox1.Text.Contains("|") || textBox1.Text.Contains('*') || textBox1.Text.Contains('=') ||
                textBox1.Text.Contains('=') || textBox1.Text.Contains('%') || textBox1.Text.Contains('!') || textBox2.Text.Contains('/') ||
                textBox2.Text.Contains("|") || textBox2.Text.Contains('*') || textBox2.Text.Contains('=') ||
                textBox2.Text.Contains('=') || textBox2.Text.Contains('%') || textBox2.Text.Contains('!'))
            {
                MessageBox.Show("Недопусимые символы в строке - /, |, *, =");
                return;
            }
            try
            {
                textBox1.Text += Polinom.Polinom.StandardizePolynomial(textBox2.Text) + "\r\n";
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Непредвиденная ошибка, пожалуйста, убедитесь в корректности ввода.");
                form1.output_errors(ex, "standart-vid");
            }

        }
    }
}
