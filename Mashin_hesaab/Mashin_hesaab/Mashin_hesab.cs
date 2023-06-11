using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mashin_hesaab
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationperformed = "";
        bool isoperationperformed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isoperationperformed))
                textBox_Result.Clear();

            isoperationperformed = false;
            Button button = (Button)sender;
            if(button.Text==".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;

            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button17.PerformClick();
                operationperformed = button.Text;
                labelCurrentOperation.Text = resultValue + "  " + operationperformed;
                isoperationperformed = true;
            }
            else
            {
                operationperformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + "  " + operationperformed;
                isoperationperformed = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch(operationperformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}