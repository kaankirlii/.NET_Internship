using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProje7FareButonOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void gicikdugme_MouseEnter(object sender, EventArgs e)
        {
              Random r = new Random();
            // gicikdugme.Left = r.Next(0, this.Width - 2 * gicikdugme.Width);  
            //gicikdugme.Top = r.Next(0, this.Height - 2* gicikdugme.Height);

        gicikdugme.Location = new Point((r.Next(Width - (2* gicikdugme.Width) )),
                (r.Next(Height - (2* gicikdugme.Height) )));
   
        }

    }
}




//  gicikdugme.Left = r.Next(0, Screen.PrimaryScreen.Bounds.Size);
// gicikdugme.Top = r.Next(0, this.Height - this.gicikdugme.Height);


//    Point coord = new Point(start.Width/2 , start.Height/2);  //koordinat başlangıcı en ve boyun yarısı
//   Point coord2 = start.PointToScreen(coord);  // aynı değişken 2 kez tanımlanamaz 
//  Cursor.Position = coord2; //kooordinat noktası pozisyon alır

//   Cursor.Position= start.PointToScreen(new Point(start.Width / 2, start.Height / 2));