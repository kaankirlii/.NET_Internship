using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAListBoxVeriGirisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Proje 9 

          //int intdeger;
          //string stringdeger;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int intdeger;
            string stringdeger;


            //stringdeger = textBox1.Text;    //stringdeger textBox'ta görünür
            // if (textBox1.Text ==  )
            //  listBox1.Items.Add(textBox1.Text);


            //textBox1.Text = intdeger.ToString(); //textBox'ta int string'e dönüşür 
            //textBox1.Text = stringdeger;         
            try
            {
                // stringdeger = textBox1.Text;
                // textBox1.Text = intdeger.ToString();
                intdeger = Convert.ToInt32(textBox1.Text);  
                textBox1.Text = intdeger.ToString(); //textBox'ta int string'e dönüşür       
               // textBox1.Text = button1.ToString();

                listBox1.Items.Add(intdeger);  //listBox1'e intdegerler eklenir
                textBox1.Clear();  //textBox temizlenir

               // BooleanConverter
               

            } catch (FormatException ex)
            {

                listBox2.Items.Add(textBox1.Text);   //listbox2'ye string değerleri eklenir

                // listBox2.Items.Add(stringdeger);
             // MessageBox.Show("Cannot format");
                textBox1.Clear();  //textBox temizlenir

            } catch 
            {
                
            }
                      

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}


//private void textBox1_TextChanged(object sender, EventArgs e)
//{
//    // int totalNum = 0;
//    String a = textBox1.Text;

//    //concatenation 
//}

//private void button1_Click(object sender, EventArgs e)
//{
//    if (plus == true)
//    {
//        result += Convert.ToInt32(textBox1.Text);
//        textBox1.Text = result.ToString();
//    }
//    else
//    {
//        result = Convert.ToInt32(textBox1.Text);
//        plus = true;
//    }
//    textBox1.Focus();
//    deger = true;


//}