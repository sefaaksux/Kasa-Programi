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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaCikisi));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_paraCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmb_odemeYontemi = new System.Windows.Forms.ComboBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 17F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(108, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "ÖDEME YÖNTEMİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(182, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "AÇIKLAMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 17F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(224, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "ZAMAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 17F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(234, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "TUTAR";
            // 
            // btn_paraCikis
            // 
            this.btn_paraCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paraCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paraCikis.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_paraCikis.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_paraCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_paraCikis.ImageKey = "paracikis.png";
            this.btn_paraCikis.ImageList = this.ımageList1;
            this.btn_paraCikis.Location = new System.Drawing.Point(286, 461);
            this.btn_paraCikis.Name = "btn_paraCikis";
            this.btn_paraCikis.Size = new System.Drawing.Size(384, 66);
            this.btn_paraCikis.TabIndex = 4;
            this.btn_paraCikis.Text = "PARA ÇIKIŞI";
            this.btn_paraCikis.UseVisualStyleBackColor = true;
            this.btn_paraCikis.Click += new System.EventHandler(this.btn_paraCikis_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "paracikis.png");
            // 
            // cmb_odemeYontemi
            // 
            this.cmb_odemeYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_odemeYontemi.FormattingEnabled = true;
            this.cmb_odemeYontemi.Items.AddRange(new object[] {
            "Seçiniz",
            "KREDİ KARTI",
            "NAKİT",
            "FİRMADAN ÇEKİŞ",
            "SENET TAHSİL"});
            this.cmb_odemeYontemi.Location = new System.Drawing.Point(344, 219);
            this.cmb_odemeYontemi.Name = "cmb_odemeYontemi";
            this.cmb_odemeYontemi.Size = new System.Drawing.Size(287, 37);
            this.cmb_odemeYontemi.TabIndex = 2;
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_tarih.Location = new System.Drawing.Point(344, 178);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(287, 28);
            this.dtp_tarih.TabIndex = 1;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aciklama.Location = new System.Drawing.Point(344, 271);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(287, 153);
            this.txt_aciklama.TabIndex = 3;
            // 
            // txt_tutar
            // 
            this.txt_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Location = new System.Drawing.Point(344, 131);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(287, 33);
            this.txt_tutar.TabIndex = 0;
            this.txt_tutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tutar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(646, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(694, 616);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Copyright © 2024, CELAL SAFA AKSU";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(917, 55);
            this.button1.TabIndex = 22;
            this.button1.Text = "PARA ÇIKIŞI";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ParaCikisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(917, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_paraCikis);
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
        private System.Windows.Forms.ComboBox cmb_odemeYontemi;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}