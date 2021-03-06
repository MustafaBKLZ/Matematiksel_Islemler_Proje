﻿using System;
using System.Windows.Forms;
namespace Matematiksel_Islemler_Projesi
{
    public partial class fibonacci : Form
    {
        public fibonacci()
        {
            InitializeComponent();
        }
        private void fibonacci_Load(object sender, EventArgs e)
        {
            label3.Text = "Kaçıncı sıradaki fibonacci değerini görmek istiyorsunuz?";
        }
        int Fibonacci_Hesapla(int sayi)
        {
            if (sayi < 1)
                return 0;
            else if (sayi == 1)
                return 1;
            else
                return Fibonacci_Hesapla(sayi - 1) + Fibonacci_Hesapla(sayi - 2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            try
            {
                textBox2.Text += Fibonacci_Hesapla(Convert.ToInt32(textBox1.Text)).ToString() + Environment.NewLine;
            }
            catch
            {
                MessageBox.Show("Sayı Giriniz");
            }
        }
    }
}
