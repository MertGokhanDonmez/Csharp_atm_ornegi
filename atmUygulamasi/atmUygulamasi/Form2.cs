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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 f1 = new Form1();
        int bakiye;

        // yatır düğmesi ile bakiye değerini arttırıyoruz
        private void btn_yatir_Click(object sender, EventArgs e)
        {
            int yatir = Int32.Parse(tbox_yatirilacak.Text);
            bakiye += yatir;
            lbl_bakiye.Text = bakiye.ToString();
        }

        // form2 oluştuğu anda gerçekleşecek kodlar
        public void Form2_Load(object sender, EventArgs e)
        {
            bakiye = f1.bakiye;
            lbl_bakiye.Text = bakiye.ToString();
        }
    }
}
