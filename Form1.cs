using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorInCSharp
{
    public partial class Calculator : Form
    {
        //Variables
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
            label1.Text = "";
        }

        //Numbers
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(textBox1.Text == "0" || (isOperationPerformed))
            {
                textBox1.Clear();
            }
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else
            {
                textBox1.Text += button.Text;
            }
            
            isOperationPerformed = false;
        }

        //Operators
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            label1.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;

        }

        //Other Buttons
        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
            label1.Text = "";
        }

        private void buttonEqu_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed == false)
            {
                switch (operationPerformed)
                {
                    case "+":
                        textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                        break;
                }

                resultValue = Double.Parse(textBox1.Text);
                label1.Text = "";
                isOperationPerformed = true;
            }
            
        }

        
    }
}
