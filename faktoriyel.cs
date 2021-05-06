using System;
using System.Windows.Forms;

namespace Matematiksel_Islemler_Projesi
{
    public partial class faktoriyel : Form
    {
        public faktoriyel()
        {
            InitializeComponent();
        }
        private void faktoriyel_Load(object sender, EventArgs e)
        {
        }
        int Faktoriyel_Hesaplama(int sayi)
        {
            if (sayi == 0)
                return 1;
            else
                return sayi * Faktoriyel_Hesaplama(sayi - 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = Faktoriyel_Hesaplama(Convert.ToInt32(textBox1.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Sayı Giriniz.");
            }
        }
    }
}
