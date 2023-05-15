using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class dividecs : Form
    {
        Form1 form1;
        public dividecs(Form1 owner)
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
                if (Polinom.Polinom.StandardizePolynomial(textBox1.Text) == "0")
                {
                    MessageBox.Show("Делимое не может быть нулевым");
                    return;
                }
                if (Polinom.Polinom.StandardizePolynomial(textBox2.Text) == "0")
                {
                    MessageBox.Show("Делитель не может быть нулевым");
                    return;
                }
                if (Polinom.Polinom.ParsePolynomial(Polinom.Polinom.StandardizePolynomial(textBox1.Text)).Length < Polinom.Polinom.ParsePolynomial(Polinom.Polinom.StandardizePolynomial(textBox2.Text)).Length)
                {
                    MessageBox.Show("Степень делителя должна быть меньше или равна степени делимого!");
                    return;
                }
                Stopwatch stopwatch = new Stopwatch();
                //засекаем время начала операции
                stopwatch.Start();
                //выполняем какую-либо операцию
                string[] k = Polinom.Polinom.DividePolynomials(textBox1.Text, textBox2.Text);
                stopwatch.Stop();
                //смотрим сколько миллисекунд было затрачено на выполнение
                textBox3.Text += (stopwatch.ElapsedMilliseconds) + "\r\n";
                textBox3.Text += "Частное " + k[0] + " и остаток " + k[1];
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Непредвиденная ошибка, пожалуйста, убедитесь в корректности ввода.");
                form1.output_errors(ex, "dividecs");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
