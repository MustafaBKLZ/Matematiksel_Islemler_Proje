
namespace Matematiksel_Islemler_Projesi
{
    partial class Sayi_Tabanini_Degistirme
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
            this.btn_donustur = new System.Windows.Forms.Button();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            this.txt_taban = new System.Windows.Forms.TextBox();
            this.txt_sayi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_donustur
            // 
            this.btn_donustur.Location = new System.Drawing.Point(206, 5);
            this.btn_donustur.Name = "btn_donustur";
            this.btn_donustur.Size = new System.Drawing.Size(149, 74);
            this.btn_donustur.TabIndex = 26;
            this.btn_donustur.Text = "Dönüştür";
            this.btn_donustur.UseVisualStyleBackColor = true;
            this.btn_donustur.Click += new System.EventHandler(this.btn_donustur_Click);
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.Location = new System.Drawing.Point(100, 58);
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.Size = new System.Drawing.Size(100, 20);
            this.txt_sonuc.TabIndex = 23;
            // 
            // txt_taban
            // 
            this.txt_taban.Location = new System.Drawing.Point(100, 32);
            this.txt_taban.Name = "txt_taban";
            this.txt_taban.Size = new System.Drawing.Size(100, 20);
            this.txt_taban.TabIndex = 22;
            // 
            // txt_sayi
            // 
            this.txt_sayi.Location = new System.Drawing.Point(100, 6);
            this.txt_sayi.Name = "txt_sayi";
            this.txt_sayi.Size = new System.Drawing.Size(100, 20);
            this.txt_sayi.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sonuç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Taban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sayı";
            // 
            // Sayi_Tabanini_Degistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 89);
            this.Controls.Add(this.btn_donustur);
            this.Controls.Add(this.txt_sonuc);
            this.Controls.Add(this.txt_taban);
            this.Controls.Add(this.txt_sayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sayi_Tabanini_Degistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayi_Tabanini_Degistirme";
            this.Load += new System.EventHandler(this.Sayi_Tabanini_Degistirme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_donustur;
        private System.Windows.Forms.TextBox txt_sonuc;
        private System.Windows.Forms.TextBox txt_taban;
        private System.Windows.Forms.TextBox txt_sayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}