﻿
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
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_KombinasyonHesaplama);
            this.Controls.Add(this.btn_ikinci_dereceden_denklem);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ikinci_dereceden_denklem;
        private System.Windows.Forms.Button btn_KombinasyonHesaplama;
    }
}

