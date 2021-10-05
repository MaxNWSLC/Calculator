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

        public static long Squared(int n)
        {
            return n * n;
        }
        public static long Cubed(int n)
        {
            return n * n * n;
        }

        private void keepMeDry(int n)
        {
            bool will;
            string response = "";
            int input = 0;
            try
            {
                input = Int32.Parse(textBox1.Text);
                will = true;
            }
            catch (FormatException)
            {
                response = $"Looks like we have a \nproblem did you forgot \nto give me a number?";
                will = false;
            }

            if (will)
            {
                switch (n)
                {
                    case 2:
                        response = Cubed(input).ToString();
                        break;
                    default:
                        response = Squared(input).ToString();
                        break;
                }
            }
            
            label2.Text = $"Result:\n\n {response}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            keepMeDry(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            keepMeDry(2);
        }
    }
}
