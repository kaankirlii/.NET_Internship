using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProje5DengeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          //  moveToStart();  //harekete başlat
        }

      
         private void finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Win!!! Congratulations!!!");   //biterse mesaj al   
            Close(); //uygulamayı kapatır
        }

       // private void moveToStart()
       // {

        //    Point coord = new Point(start.Width/2 , start.Height/2);  //koordinat başlangıcı en ve boyun yarısı
         //   Point coord2 = start.PointToScreen(coord);  // aynı değişken 2 kez tanımlanamaz 
          //  Cursor.Position = coord2; //kooordinat noktası pozisyon alır

         //   Cursor.Position= start.PointToScreen(new Point(start.Width / 2, start.Height / 2));

       // }

        private void start_MouseEnter(object sender, EventArgs e)
        {
            //   moveToStart();  //mouse enter, başlangıçtan itibaren harekete başlatır 
            Cursor.Position = start.PointToScreen(new Point(start.Width / 2, start.Height / 2)); 
        }


        //private void MouseEnter (object sender, EventArgs e)
        //{
        //    sender.GetType() == typeof(MouseEventArgs) ? finish_MouseEnter(sender, e) : start_MouseEnter(sender, e);

        //}

    }
}
