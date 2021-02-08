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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btn_ikinci_dereceden_denklem_Click(object sender, EventArgs e)
        {
            new ikinci_derece_denklem_ve_cozum() { }.ShowDialog();
        }
    }
}
