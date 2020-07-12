using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        calc c;
        public static double A = 0;
        public static double B = 0;
        public Form1()
        {
            InitializeComponent();

            c = new calc();
            

           
        }

        class calc 
        {
            public double Multiplication(double a, double b)//умножение
            {
                return a * b;
            }
            public double Division(double a, double b)//деление
            {
                return a / b;
            }
            public double Sum(double a, double b)// сумма
            {
                return a + b;
            }
            public double Subtraction(double a, double b) //вычитание
            {
                return a - b;
            }

        }
        private bool CanPress()
        {
            if (!button1.Enabled)
                return false;

            if (!button2.Enabled)
                return false;

            if (!button3.Enabled)
                return false;

            if (!button4.Enabled)
                return false;

           

            return true;
        }
        private void FreeButtons()
        {

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            


        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;

            }

        }
     
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!button1.Enabled) 
                textBox3.Text = c.Multiplication(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();

            FreeButtons();

        }
    }
}
