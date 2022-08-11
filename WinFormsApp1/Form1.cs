using ClassLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            Class1 cls = new Class1();
            MessageBox.Show("Toplam = " + cls.Topla(Convert.ToInt16(textSayi1.Text), Convert.ToInt16(textSayi2.Text)));
        }
    }
}