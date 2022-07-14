namespace atmUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int bakiye = 500;

        private void Form1_Load(object sender, EventArgs e)
        {
            // ATM C# konsol uygulamasi

            //PARA ÇEKEN
            //YATIRAN
            //BAKÝYE GÖSTEREN
            //VE MENÜ ÞEKLÝNDE BU ÝÞLEMLERÝ KULLANICIDAN ALAN



            // Para cekme fonksiyonu

            lbl_bakiye.Text = bakiye.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}