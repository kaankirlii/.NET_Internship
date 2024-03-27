using System;
using System.Windows.Forms;

namespace WFAProje4
{
    public partial class Form1 : Form
    {
        bool a;

        int result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Make an operation 

            if(a == true)
            {
                if(Operator.Text == "+")
                {
                    result += Convert.ToInt32(textBox1.Text);
                    textBox1.Text = result.ToString();
                }else if(Operator.Text == "-")
                {
                    result -= Convert.ToInt32(textBox1.Text);
                    textBox1.Text = result.ToString();
                }else if(Operator.Text == "*")
                {
                    result *= Convert.ToInt32(textBox1.Text);
                    textBox1.Text = result.ToString();
                }else if (Operator.Text == "/")
                {
                    result /= Convert.ToInt32(textBox1.Text);
                    textBox1.Text = result.ToString();
                }else
                {
                    MessageBox.Show("Please enter an operator!");
                }


            }else
            {
                Convert.ToInt32(textBox1.Text);
                a = true;
            }

          

  
  

        }
    }
}

