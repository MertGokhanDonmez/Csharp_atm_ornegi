using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmUygulamasi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // form 1 ile veri alışverişi ve pencere kontorlü için f1 nesnesini tanımladık
        Form1 f1 = new Form1();
        int bakiye;
        
        // form3 oluştuğu anda çalışacak kodlar
        private void Form3_Load(object sender, EventArgs e)
        {
            // form 1 deki bakiye değişkeninin değerini bu formdaki bakiye'ye aktardık. Değişkeni değil değerini!
            bakiye = f1.bakiye;
            lbl_bakiye.Text = bakiye.ToString();            
        }

        // çek düğmesi ile bakiye değerini azaltıyoruz
        private void btn_cek_Click(object sender, EventArgs e)
        {
            int cek = Int32.Parse(tbox_yatirilacak.Text);
            if (bakiye >= cek)
            {
               bakiye -= cek;
            }
            else
            {
                MessageBox.Show("Bakiyeniz yetersiz!!!");
            }
            
            lbl_bakiye.Text = bakiye.ToString();

        }
    }
}
