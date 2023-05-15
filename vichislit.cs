using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class vichislit : Form
    {
        Form1 form1;
        public vichislit(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
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
                textBox3.Clear();
                double k = Convert.ToDouble(textBox2.Text.Replace(".", ","));
                textBox3.Text = Polinom.Polinom.CalculatePolinomials(textBox1.Text, k).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка, пожалуйста, убедитесь в корректности ввода");
                form1.output_errors(ex, "subtract");
            }
        }
                   
    }
}
