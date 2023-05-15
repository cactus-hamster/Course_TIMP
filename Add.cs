using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Add : Form
    {
        Form1 form1;
        public Add(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains('/')|| textBox1.Text.Contains("|")||textBox1.Text.Contains('*')|| textBox1.Text.Contains('=')||
                textBox1.Text.Contains('=')|| textBox1.Text.Contains('%')|| textBox1.Text.Contains('!')|| textBox2.Text.Contains('/') || 
                textBox2.Text.Contains("|") || textBox2.Text.Contains('*') || textBox2.Text.Contains('=') ||
                textBox2.Text.Contains('=') || textBox2.Text.Contains('%') || textBox2.Text.Contains('!'))
            {
                MessageBox.Show("Недопусимые символы в строке - /, |, *, =");
                return;
            }
            try
            {
                textBox3.Text = Polinom.Polinom.AddPolinomials(textBox1.Text, textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в строке, пожалуйста, убедитесь в корректности ввода.");
                form1.output_errors(ex, "Add");
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
