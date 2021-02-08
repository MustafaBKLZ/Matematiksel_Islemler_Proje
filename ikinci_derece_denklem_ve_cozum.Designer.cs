
namespace Matematiksel_Islemler_Projesi
{
    partial class ikinci_derece_denklem_ve_cozum
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.list_sonuc = new System.Windows.Forms.ListBox();
            this.btn_coz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(125, 25);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 20);
            this.txt_a.TabIndex = 1;
            this.txt_a.Leave += new System.EventHandler(this.txt_a_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "c";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(125, 51);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 20);
            this.txt_b.TabIndex = 4;
            this.txt_b.Leave += new System.EventHandler(this.txt_b_Leave);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(125, 77);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(100, 20);
            this.txt_c.TabIndex = 5;
            this.txt_c.Leave += new System.EventHandler(this.txt_c_Leave);
            // 
            // list_sonuc
            // 
            this.list_sonuc.FormattingEnabled = true;
            this.list_sonuc.Location = new System.Drawing.Point(86, 103);
            this.list_sonuc.Name = "list_sonuc";
            this.list_sonuc.Size = new System.Drawing.Size(179, 186);
            this.list_sonuc.TabIndex = 6;
            // 
            // btn_coz
            // 
            this.btn_coz.Location = new System.Drawing.Point(86, 295);
            this.btn_coz.Name = "btn_coz";
            this.btn_coz.Size = new System.Drawing.Size(179, 56);
            this.btn_coz.TabIndex = 7;
            this.btn_coz.Text = "Çöz";
            this.btn_coz.UseVisualStyleBackColor = true;
            this.btn_coz.Click += new System.EventHandler(this.btn_coz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "2. dereceden denklem köklerini bulan ve ekranda gösteren program";
            // 
            // ikinci_derece_denklem_ve_cozum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_coz);
            this.Controls.Add(this.list_sonuc);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label1);
            this.Name = "ikinci_derece_denklem_ve_cozum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ikinci_derece_denklem_ve_cozum";
            this.Load += new System.EventHandler(this.Iki_Bilinmeyenli_Denklem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.ListBox list_sonuc;
        private System.Windows.Forms.Button btn_coz;
        private System.Windows.Forms.Label label4;
    }
}