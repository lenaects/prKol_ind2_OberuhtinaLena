using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practic15
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool complex(string number)
        {
            int bookI = 0;
            for (int i = 0; i < number.Length; i++)
            {
                char n = number[i];
                if (char.IsDigit(n) == false)
                {
                    if (n != 'i' || bookI == 1)
                    {
                        return false;
                    }
                    if (n == 'i') bookI = 1;
                }
            }
            if (bookI == 0)
            {
                return false;
            }
            if (bookI > 1) return false;
            return true;
        }
        public bool textbox()
        {
            bool cheak = true;
            if (complex(textBox1.Text) == false)
            {
                MessageBox.Show("Вы ввели неверно первое комплекснное число", "Ошибка");
                cheak = false;
            }
            if (complex(textBox2.Text) == false)
            {
                MessageBox.Show("Вы ввели неверно второе ккомплекснное число", "Ошибка");
                cheak = false;
            }
            return cheak;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox())
            {
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                if (comboBox1.SelectedIndex == 1)
                {
                    text1 = "-" + textBox1.Text;
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    text2 = "-" + textBox2.Text;
                }
                Complexnumb complexnumb = new Complexnumb(Convert.ToInt32(numericUpDown1.Value), text1, Convert.ToInt32(numericUpDown2.Value), text2);
                label1.Text = complexnumb.addition();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textbox())
            {
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                if (comboBox1.SelectedIndex == 1)
                {
                    text1 = "-" + textBox1.Text;
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    text2 = "-" + textBox2.Text;
                }
                Complexnumb complexnumb = new Complexnumb(Convert.ToInt32(numericUpDown1.Value), text1, Convert.ToInt32(numericUpDown2.Value), text2);
                label1.Text = complexnumb.subtraction();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textbox())
            {
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                if (comboBox1.SelectedIndex == 1)
                {
                    text1 = "-" + textBox1.Text;
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    text2 = "-" + textBox2.Text;
                }
                Complexnumb complexnumb = new Complexnumb(Convert.ToInt32(numericUpDown1.Value), text1, Convert.ToInt32(numericUpDown2.Value), text2);
                label1.Text = complexnumb.multiplication();

            }
        }
    }
}
