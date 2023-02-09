using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool IsPositife = true;
        bool txtClear = true;
        double result = 0;
        string operatorResult = "";

        private void Button_click(object sender, EventArgs e)
        {
            if (txtClear)
            {
                Netice.Clear();
            }

            if (viewOperations.Text == "0")
            {
                viewOperations.Text.Remove(0);
            }

            if (Netice.Text.StartsWith("0"))
            {
                Netice.Text += '.';
            }

            txtClear = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!Netice.Text.Contains("."))
                {
                    Netice.Text += button.Text;
                }
            }
            else
            {
                Netice.Text += button.Text;
            }
        }

        private void operatorClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string newOperator = button.Text;

            txtClear = true;

            if (operatorResult == "+")
            {
                Netice.Text = (result + Double.Parse(Netice.Text)).ToString();
            }
            else if (operatorResult == "-")
            {
                Netice.Text = (result - Double.Parse(Netice.Text)).ToString();
            }
            else if (operatorResult == "x")
            {
                Netice.Text = (result * Double.Parse(Netice.Text)).ToString();
            }
            else if (operatorResult == "/")
            {
                Netice.Text = (result / Double.Parse(Netice.Text)).ToString();
            }
            else if (operatorResult == "%")
            {
                Netice.Text = (result / Double.Parse(Netice.Text)).ToString();
            }

            result = Double.Parse(Netice.Text);
            viewOperations.Text = Netice.Text + " " + newOperator;
            Netice.Text = result.ToString();
            operatorResult = newOperator;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtClear = true;
            Netice.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Netice.Text = Netice.Text.Remove(Netice.Text.Length - 1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtClear = true;
            viewOperations.Text = "0";
            Netice.Text = "0";
            result = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewOperations.Text = "";

            if (operatorResult == "+")
            {
                Netice.Text = (result + Double.Parse(Netice.Text)).ToString();
            }
            else if (operatorResult == "-")
            {
                Netice.Text = (result - Double.Parse(Netice.Text)).ToString();
            }
            else if (operatorResult == "x")
            {
                Netice.Text = (result * Double.Parse(Netice.Text)).ToString();
            }
            else if (operatorResult == "/")
            {
                Netice.Text = (result / Double.Parse(Netice.Text)).ToString();
            }

            result = Double.Parse(Netice.Text);
            Netice.Text = result.ToString();
            operatorResult = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (IsPositife)
            {
                Netice.Text = (Double.Parse(Netice.Text)* - 1).ToString();
            }
            else
            {
                Netice.Text = (Double.Parse(Netice.Text) * -1).ToString();
            }
            IsPositife = !IsPositife;
        }
    }
}
