
namespace Matematiksel_Islemler_Projesi
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ikinci_dereceden_denklem = new System.Windows.Forms.Button();
            this.btn_KombinasyonHesaplama = new System.Windows.Forms.Button();
            this.Permutasyon_Hesaplama = new System.Windows.Forms.Button();
            this.btn_Sayi_Tabanini_Degistirme = new System.Windows.Forms.Button();
            this.btn_faktoriyel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ikinci_dereceden_denklem
            // 
            this.btn_ikinci_dereceden_denklem.Location = new System.Drawing.Point(12, 12);
            this.btn_ikinci_dereceden_denklem.Name = "btn_ikinci_dereceden_denklem";
            this.btn_ikinci_dereceden_denklem.Size = new System.Drawing.Size(206, 39);
            this.btn_ikinci_dereceden_denklem.TabIndex = 0;
            this.btn_ikinci_dereceden_denklem.Text = "İkinci Dereceden Denklem";
            this.btn_ikinci_dereceden_denklem.UseVisualStyleBackColor = true;
            this.btn_ikinci_dereceden_denklem.Click += new System.EventHandler(this.btn_ikinci_dereceden_denklem_Click);
            // 
            // btn_KombinasyonHesaplama
            // 
            this.btn_KombinasyonHesaplama.Location = new System.Drawing.Point(12, 57);
            this.btn_KombinasyonHesaplama.Name = "btn_KombinasyonHesaplama";
            this.btn_KombinasyonHesaplama.Size = new System.Drawing.Size(206, 39);
            this.btn_KombinasyonHesaplama.TabIndex = 1;
            this.btn_KombinasyonHesaplama.Text = "Kombinasyon Hesaplama";
            this.btn_KombinasyonHesaplama.UseVisualStyleBackColor = true;
            this.btn_KombinasyonHesaplama.Click += new System.EventHandler(this.btn_KombinasyonHesaplama_Click);
            // 
            // Permutasyon_Hesaplama
            // 
            this.Permutasyon_Hesaplama.Location = new System.Drawing.Point(12, 102);
            this.Permutasyon_Hesaplama.Name = "Permutasyon_Hesaplama";
            this.Permutasyon_Hesaplama.Size = new System.Drawing.Size(206, 39);
            this.Permutasyon_Hesaplama.TabIndex = 2;
            this.Permutasyon_Hesaplama.Text = "Permütasyon Hesaplama";
            this.Permutasyon_Hesaplama.UseVisualStyleBackColor = true;
            this.Permutasyon_Hesaplama.Click += new System.EventHandler(this.Permutasyon_Hesaplama_Click);
            // 
            // btn_Sayi_Tabanini_Degistirme
            // 
            this.btn_Sayi_Tabanini_Degistirme.Location = new System.Drawing.Point(12, 147);
            this.btn_Sayi_Tabanini_Degistirme.Name = "btn_Sayi_Tabanini_Degistirme";
            this.btn_Sayi_Tabanini_Degistirme.Size = new System.Drawing.Size(206, 39);
            this.btn_Sayi_Tabanini_Degistirme.TabIndex = 2;
            this.btn_Sayi_Tabanini_Degistirme.Text = "Sayı Tabanını Değiştirme";
            this.btn_Sayi_Tabanini_Degistirme.UseVisualStyleBackColor = true;
            this.btn_Sayi_Tabanini_Degistirme.Click += new System.EventHandler(this.btn_Sayi_Tabanini_Degistirme_Click);
            // 
            // btn_faktoriyel
            // 
            this.btn_faktoriyel.Location = new System.Drawing.Point(12, 192);
            this.btn_faktoriyel.Name = "btn_faktoriyel";
            this.btn_faktoriyel.Size = new System.Drawing.Size(206, 39);
            this.btn_faktoriyel.TabIndex = 3;
            this.btn_faktoriyel.Text = "Faktoriyel";
            this.btn_faktoriyel.UseVisualStyleBackColor = true;
            this.btn_faktoriyel.Click += new System.EventHandler(this.btn_faktoriyel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fibonacci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_faktoriyel);
            this.Controls.Add(this.btn_Sayi_Tabanini_Degistirme);
            this.Controls.Add(this.Permutasyon_Hesaplama);
            this.Controls.Add(this.btn_KombinasyonHesaplama);
            this.Controls.Add(this.btn_ikinci_dereceden_denklem);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ikinci_dereceden_denklem;
        private System.Windows.Forms.Button btn_KombinasyonHesaplama;
        private System.Windows.Forms.Button Permutasyon_Hesaplama;
        private System.Windows.Forms.Button btn_Sayi_Tabanini_Degistirme;
        private System.Windows.Forms.Button btn_faktoriyel;
        private System.Windows.Forms.Button button1;
    }
}

