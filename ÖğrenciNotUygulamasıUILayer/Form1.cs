namespace ÖğrenciNotUygulamasıUILayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciEkle frm = new OgrenciEkle();
            frm.ShowDialog();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            DersEkle frm = new DersEkle();
            frm.ShowDialog();
        }

        private void btnnot_Click(object sender, EventArgs e)
        {
            OgrenciNotlariniEkle frm = new OgrenciNotlariniEkle();
            frm.ShowDialog();
        }
    }
}