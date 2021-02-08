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
            txt_a.Text = "1";
            txt_b.Text = "0";
            txt_c.Text = "0";
        }

        int a, b, c;
        private void btn_coz_Click(object sender, EventArgs e)
        {
            list_sonuc.Items.Clear();

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

        private void txt_a_Leave(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(txt_a.Text);

                if (a == 0)
                {
                    this.ActiveControl = txt_a;
                    MessageBox.Show("a sayısı sıfır olamaz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txt_a.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                txt_a.BackColor = Color.Yellow;
                this.ActiveControl = txt_a;
                MessageBox.Show("Bir sayı girmelisiniz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_b_Leave(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToInt32(txt_b.Text);
                txt_b.BackColor = Color.White;
            }
            catch (FormatException)
            {
                txt_b.BackColor = Color.Yellow;
                this.ActiveControl = txt_b;
                MessageBox.Show("Bir sayı girmelisiniz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_c_Leave(object sender, EventArgs e)
        {
            try
            {
                c = Convert.ToInt32(txt_c.Text);
                txt_c.BackColor = Color.White;
            }
            catch (FormatException)
            {
                txt_c.BackColor = Color.Yellow;
                this.ActiveControl = txt_c;
                MessageBox.Show("Bir sayı girmelisiniz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
