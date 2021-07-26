using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorapp
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text=="0")||(operation_pressed))
                textBox1.Clear();
            operation_pressed = false;
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = double.Parse(textBox1.Text);
            operation_pressed = true;
            label2.Text = value + " " + operation;
        }

        private void button_woc10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void button_woc11_Click(object sender, EventArgs e)
        {
            double d = 0;
            label2.Text = "";
            switch (operation)
            {
                case "+": 
                    textBox1.Text=(value+ double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                    break;
                case "cos":
                    value = 0;
                     d = double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Cos((d * 3.14) / 180)).ToString();
                    break;
                case "sin":
                    value = 0;
                    d = double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Sin((d * 3.14) / 180)).ToString();
                    break;
                case "tan":
                    value = 0;
                    d = double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Tan((d * 3.14) / 180)).ToString();
                    break;
                case "log":
                    value = 0;
                    d = double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Log((d * 3.14) / 180)).ToString();
                    break;
            }//end switch
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_woc22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button_woc21_Click(object sender, EventArgs e)
        {
            operation = "cos";
            textBox1.Text = "";
        }

        private void button_woc20_Click(object sender, EventArgs e)
        {
            operation = "sin";
            textBox1.Text = "";
        }

        private void button_woc19_Click(object sender, EventArgs e)
        {
            operation = "tan";
            textBox1.Text = "";
        }

        private void button_woc18_Click(object sender, EventArgs e)
        {
            operation = "log";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
