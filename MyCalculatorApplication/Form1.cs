using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        double num1, num2;

        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();

            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
            cbOperator.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(txtBoxInput1.Text);
                num2 = Convert.ToDouble(txtBoxInput2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input! Please enter numbers only.");
                return;
            }

            string op = cbOperator.SelectedItem.ToString();
            double result = 0;

            switch (op)
            {
                case "+":
                    result = cal.GetSum(num1, num2);
                    break;
                case "-":
                    result = cal.GetDifference(num1, num2);
                    break;
                case "*":
                    result = cal.GetProduct(num1, num2);
                    break;
                case "/":
                    try
                    {
                        result = cal.GetQuotient(num1, num2);
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    break;
            }
                  lblDisplayTotal.Text = result.ToString();
        }
        }
    }

