using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProje6RandomGiris
{
    public partial class Form1 : Form
    {

       
        int h =3 ; //hak sayısı 

        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Layout(object sender, LayoutEventArgs e)
        {
            Console.WriteLine("Lütfen aşağıda görmüş olduğunuz karakterleri yazı alanına yazınız.."); //label yazısı 
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
                if(textBox2.Text == label3.Text)   //textbox labekl'a eşitse 
            {
                MessageBox.Show("Başarıyla girilmiştir!");
                Close();  //uygulamayı kapat 
           
            }   else
            {
                Random r = new Random();       //random belirlenir
                label3.Text = r.Next(10000, 99999) + ""; //label'da random sayı yazılır 

                if (h > 0)    //h > 0  hak sayısı 1 azalır
                {
                    MessageBox.Show("Yanlış Sayı"); //yanlış sayı mesajı
                    h--; // hak sayısı 1 azalır 
                    label4.Text = h.ToString();   //hak sayısı string'de "Kalan Hakkınız" 'ın yanında gözükür. 
                }
                if (h == 0) // hak sayısı bittiyse
                {
                    MessageBox.Show("Hakkınız Doldu!");   // hak doldu
                    clickButton.Enabled = false;   //buton kapandı
                }

            }

        
            }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = h.ToString();  //hak sayısı yazılır
            Random r = new Random();       //random belirlenir
            label3.Text = r.Next(10000, 99999) + "";   //label'da random sayı yazılır
            
        }

      
    }
}
