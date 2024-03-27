using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProje11Barbut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //int sayi1;
        //int sayi2;

        Random rand = new Random();  // Random belirlenir

        private void button1_Click(object sender, EventArgs e)
        {
           
                try
            {
                 timer1.Start();
                timer1.Interval = 3000;

                skor1.Text = rand.Next(1, 7) + ""; /* Her butona basılınca 1 ile 7 arasındaki (7 dahil değil) sayılardan biri rastgele çıkar 
                                                ve string'e dönüşerek label'da görünür */
                skor2.Text = rand.Next(1, 7) + "";

                timer1.Stop();
            } catch
            {

            }

           // MessageBox.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
             timer1.Start();
                timer1.Interval = 3000;

                //Random rand2 = new Random(); //Random belirlenir  
                skor2.Text = rand.Next(1, 7) +""; /* Her butona basılınca 1 ile 7 arasındaki sayılardan (7 dahil değil) biri rastgele çıkar 
                                                ve string'e dönüşerek label'da görünür */

            skor1.Text = rand.Next(1, 7) + "";
                timer1.Stop();

            } catch
            {


            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
            timer1.Interval = 3000;
            timer1.Stop();



            //if (sayi1 > sayi2)
            //{
            //    MessageBox.Show("1. Oyuncu Galip!");
            //}else if(sayi2> sayi1)
            //{
            //    MessageBox.Show("2. Oyuncu Galip!");
            //}else if(sayi1 == sayi2)
            //{
            //   // MessageBox.Show("Berabere!");
            //}
            

            try
            {
             
                

            }catch
            {
                MessageBox.Show("Fazla girdiniz");
            }


 
        }
    }
}


//
//label4.Text = h.ToString();  //hak sayısı yazılır
  //          Random r = new Random();       //random belirlenir
//label3.Text = r.Next(10000, 99999) + "";   //label'da random sayı yazılır