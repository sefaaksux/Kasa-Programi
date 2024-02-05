namespace AksuHaliEvi
{
    partial class ParaCikisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaCikisi));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_paraCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_odemeYontemi = new System.Windows.Forms.ComboBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(120, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "ÖDEME YÖNTEMİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(185, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "AÇIKLAMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(221, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "ZAMAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(231, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "TUTAR";
            // 
            // btn_paraCikis
            // 
            this.btn_paraCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paraCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paraCikis.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_paraCikis.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_paraCikis.Location = new System.Drawing.Point(183, 455);
            this.btn_paraCikis.Name = "btn_paraCikis";
            this.btn_paraCikis.Size = new System.Drawing.Size(506, 41);
            this.btn_paraCikis.TabIndex = 12;
            this.btn_paraCikis.Text = "PARA ÇIKIŞI";
            this.btn_paraCikis.UseVisualStyleBackColor = true;
            this.btn_paraCikis.Click += new System.EventHandler(this.btn_paraCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(326, 27);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(221, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "PARA ÇIKIŞI";
            // 
            // cmb_odemeYontemi
            // 
            this.cmb_odemeYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_odemeYontemi.FormattingEnabled = true;
            this.cmb_odemeYontemi.Items.AddRange(new object[] {
            "Seçiniz",
            "KREDİ KARTI",
            "NAKİT",
            "FİRMADAN ÇEKİŞ",
            "SENET TAHSİL"});
            this.cmb_odemeYontemi.Location = new System.Drawing.Point(332, 209);
            this.cmb_odemeYontemi.Name = "cmb_odemeYontemi";
            this.cmb_odemeYontemi.Size = new System.Drawing.Size(287, 28);
            this.cmb_odemeYontemi.TabIndex = 10;
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_tarih.Location = new System.Drawing.Point(332, 163);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(287, 27);
            this.dtp_tarih.TabIndex = 9;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aciklama.Location = new System.Drawing.Point(332, 250);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(287, 153);
            this.txt_aciklama.TabIndex = 8;
            // 
            // txt_tutar
            // 
            this.txt_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Location = new System.Drawing.Point(332, 116);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(287, 30);
            this.txt_tutar.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(639, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(636, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Copyright © 2024, CELAL SAFA AKSU";
            // 
            // ParaCikisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(859, 546);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_paraCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_odemeYontemi);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.txt_tutar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParaCikisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKSU HALI EVİ";
            this.Load += new System.EventHandler(this.ParaCikisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_paraCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_odemeYontemi;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}