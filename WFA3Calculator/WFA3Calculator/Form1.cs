using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA3Calculator
{
    public partial class Form1 : Form
    {

        bool plus = false;
        bool minus = false;
        bool multiply = false;
        bool divide = false; 
        
        int result;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // int totalNum = 0;
            String a = textBox1.Text; 
            
            //concatenation 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (plus==true)
            {
                result += Convert.ToInt32(textBox1.Text);
               textBox1.Text = result.ToString();
            }
            else
            {
                result = Convert.ToInt32(textBox1.Text);
                plus = true;
            }
            textBox1.Focus();
            deger = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (minus == true)
            {
                result -= Convert.ToInt32(textBox1.Text);
                textBox1.Text = result.ToString();
                
            }
            else
            {
                result = Convert.ToInt32(textBox1.Text);
                minus = true;
            }

            textBox1.Focus();
            deger = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (multiply == true)
            {
                result *= Convert.ToInt32(textBox1.Text);
                textBox1.Text = result.ToString();
            }
            else
            {
                result = Convert.ToInt32(textBox1.Text);
                multiply = true;
            }
            textBox1.Focus();
            deger = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (divide == true)
            {
                result /= Convert.ToInt32(textBox1.Text);
                textBox1.Text = result.ToString();
            }
            else
            {
                result = Convert.ToInt32(textBox1.Text);
                divide = true;
            }
            textBox1.Focus();
            deger = true;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            plus = minus = multiply = divide = false;

            textBox1.Text = ""; //clears the text
            textBox1.Tag = "";  //clears stored number

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
        bool deger;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (deger==true)
            {
 textBox1.Text = string.Empty;
            }

           
        }
    }

}
