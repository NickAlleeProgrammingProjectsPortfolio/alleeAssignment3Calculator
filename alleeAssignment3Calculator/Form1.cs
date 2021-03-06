﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alleeAssignment3Calculator
{
    public partial class Form1 : Form
    {
        double firstOperand = 0;
        double secondOperand = 0;
        int operationNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!")
            {
                if (display.Text == "0" && display.Text != null)
                {
                    display.Text = "1";
                }
                else
                {
                    display.Text += "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!")
            {
                if (display.Text == "0" && display.Text != null)
                {
                    display.Text = "2";
                }
                else
                {
                    display.Text += "2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!")
            {
                if (display.Text == "0" && display.Text != null)
                {
                    display.Text = "3";
                }
                else
                {
                    display.Text += "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!")
            {
                if (display.Text == "0" && display.Text != null)
                {
                    display.Text = "4";
                }
                else
                {
                    display.Text += "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!")
            {
                if (display.Text == "0" && display.Text != null)
                {
                    display.Text = "5";
                }
                else
                {
                    display.Text += "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!")
            {
                if (display.Text == "0" && display.Text != null)
                {
                    display.Text = "6";
                }
                else
                {
                    display.Text += "6";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!")
            {
                if (display.Text == "0" && display.Text != null)
                {
                    display.Text = "7";
                }
                else
                {
                    display.Text += "7";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!")
            {
                if (display.Text == "0" && display.Text != null)
                {
                    display.Text = "8";
                }
                else
                {
                    display.Text += "8";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!")
            {
                if (display.Text == "0" && display.Text != null)
                {
                    display.Text = "9";
                }
                else
                {
                    display.Text += "9";
                }
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!")
            {
                if (display.Text != "0")
                {
                    display.Text += "0";
                }
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearall();
            display.Text = "0";
        }
        private void clearall()
        {
            firstOperand = 0;
            secondOperand = 0;
            operationNumber = 0;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!")
            {
                if (display.Text != "0")
                {
                    secondOperand = Double.Parse(display.Text);
                    double answer = operationFn();
                    // need to typecast double to string and display it
                    clearall();
                    display.Text = answer.ToString();
                    firstOperand = answer;
                }
                if (display.Text == "0" && operationNumber == 4)
                {
                    display.Text = "Cannot Divide By 0!!!";
                    clearall();
                }
            }
        }

        // this gets called by the equals button
        private double operationFn() 
        {
            double answer = 0;
                
                if (operationNumber == 1)
                {
                    answer = firstOperand + secondOperand;

                }
                if (operationNumber == 2)
                {
                    answer = firstOperand - secondOperand;
                }
                if (operationNumber == 3)
                {
                    answer = firstOperand * secondOperand;

                }
                if (operationNumber == 4)
                {
                    answer = firstOperand / secondOperand;
                }
                if (operationNumber == 5)
                {
                    answer = firstOperand % secondOperand;
                }
            return answer;
        }


        private void add_Click(object sender, EventArgs e)
        {
                if (secondOperand == 0 && display.Text != "Cannot Divide By 0!!!")
                 {
                     firstOperand = Double.Parse(display.Text);
                     display.Text = "0";
                     operationNumber = 1;
                 }
        }

        private void subtract_Click(object sender, EventArgs e)
        {
                if (secondOperand == 0 && display.Text != "Cannot Divide By 0!!!")
                {
                    firstOperand = Double.Parse(display.Text);
                    display.Text = "0";
                    operationNumber = 2;
                }
        }
        

        private void multiply_Click(object sender, EventArgs e)
        {
                if (secondOperand == 0 && display.Text != "Cannot Divide By 0!!!")
                {
                    firstOperand = Double.Parse(display.Text);
                    display.Text = "0";
                    operationNumber = 3;
                }
        }
        private void divide_Click(object sender, EventArgs e)
        {
            if (secondOperand == 0 && display.Text != "Cannot Divide By 0!!!")
            {
                {
                    firstOperand = Double.Parse(display.Text);
                    display.Text = "0";
                    operationNumber = 4;
                }
            }
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = ".";
            }
            else
            {
                display.Text += ".";
            }

        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            if (display.Text != "Cannot Divide By 0!!!" && display.Text != "0" && display.Text != "-1")
            {
                double num = Convert.ToDouble(display.Text);
                double result = Math.Sqrt(num);
                display.Text = Convert.ToString(result);
            }
        }

        private void moduloButton_Click(object sender, EventArgs e)
        {
            if (secondOperand == 0 && display.Text != "Cannot Divide By 0!!!")
            {
                firstOperand = Double.Parse(display.Text);
                display.Text = "0";
                operationNumber = 5;
            }

        }
    }
}
