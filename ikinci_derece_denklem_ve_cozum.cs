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
    public partial class ikinci_derece_denklem_ve_cozum : Form
    {
        public ikinci_derece_denklem_ve_cozum()
        {
            InitializeComponent();
        }

        private void Iki_Bilinmeyenli_Denklem_Load(object sender, EventArgs e)
        {

        }

        private void btn_coz_Click(object sender, EventArgs e)
        {
            list_sonuc.Items.Clear();

            int a = Convert.ToInt32(txt_a.Text);
            int b = Convert.ToInt32(txt_b.Text);
            int c = Convert.ToInt32(txt_c.Text);

            double d = (b * b) - (4 * a * c);
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                list_sonuc.Items.Add("Denklemin İki Kökü Vardır = ");
                list_sonuc.Items.Add("x1 =" + x1);
                list_sonuc.Items.Add("x2 =" + x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                list_sonuc.Items.Add("Denklemin Bir Kökü Vardır = ");
                list_sonuc.Items.Add("x =" + x);
            }
            else
            {
                list_sonuc.Items.Add("Sanal Kök Vardır");
            }
        }
    }
}
