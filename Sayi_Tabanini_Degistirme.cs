using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Matematiksel_Islemler_Projesi
{
    public partial class Sayi_Tabanini_Degistirme : Form
    {
        public Sayi_Tabanini_Degistirme()
        {
            InitializeComponent();
        }
        private void Sayi_Tabanini_Degistirme_Load(object sender, EventArgs e)
        {
            //https://mustafabukulmez.com/2019/03/20/c-sayi-tabanini-degistirme/
        }
        private void btn_donustur_Click(object sender, EventArgs e)
        {
            long x;
            int n;
            try
            {
                x = int.Parse(txt_sayi.Text);
                n = int.Parse(txt_taban.Text);
                txt_sonuc.Text = TabanCevir(x, n);
            }
            catch (Exception)
            {
                throw;
            }
        }
        string TabanCevir(long x, int n)
        {
            if (n < 2)
                return "-1";

            long b;
            string s = "";

            while (x >= n)
            {
                b = x % n;
                x = x / n;
                if (b > 9)
                    s = (char)(55 + b) + s;
                else
                    s = b + s;
            }
            if (x > 9)
                s = (char)(55 + x) + s;
            else
                s = x + s;
            return s;
        }

   
    }
}
