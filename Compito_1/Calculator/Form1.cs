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


//source code available at: https://www.instructables.com/Creating-a-Calculator-Visual-Studio-C/

namespace Calculator
{
    public partial class Form1 : Form
    {
                                        //String - A string is not a data type, it is an Object that
                                        //handles chains of characters.
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;                 //char - data type for holding any character like the letter 'c' or a star '*'.
        double result = 0.0;            //double - Data type for holding number values with a decimal..



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btZero_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += "0";
            this.tbInput.Text += input;
        }

        private void btDoubelZero_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += "00";
            this.tbInput.Text += input;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += "1";
            this.tbInput.Text += input;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += "2";
            this.tbInput.Text += input;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += "3";
            this.tbInput.Text += input;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += "4";
            this.tbInput.Text += input;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += "5";
            this.tbInput.Text += input;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += "6";
            this.tbInput.Text += input;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += "7";
            this.tbInput.Text += input;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += "8";
            this.tbInput.Text += input;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += "9";
            this.tbInput.Text += input;
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            input += ".";
            this.tbInput.Text += input;
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;

        }

        private void btMoltiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                tbInput.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                tbInput.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                tbInput.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    tbInput.Text = result.ToString();
                }
                else
                {
                    tbInput.Text = "DIV/Zero!";
                }

            }
        }

        private void btC_Click(object sender, EventArgs e)
        {
            this.tbInput.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if(operation == '+')
            {
                result = num1 + num2;
                tbInput.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                tbInput.Text = result.ToString();
            }
            else if(operation == '*')
            {
                result = num1 * num2;
                tbInput.Text = result.ToString();
            }
            else if(operation == '/')
            {
                if(num2 != 0)
                {
                    result = num1 + num2;
                    tbInput.Text = result.ToString();
                }
                else
                {
                    tbInput.Text = "Error: Div/Zero!";
                }
            }


        }


    }
}
