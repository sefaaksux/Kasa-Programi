namespace AksuHaliEvi
{
    partial class ParaGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaGirisi));
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.cmb_odemeYontemi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_paraGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_tutar
            // 
            this.txt_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Location = new System.Drawing.Point(269, 101);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(165, 30);
            this.txt_tutar.TabIndex = 0;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aciklama.Location = new System.Drawing.Point(269, 236);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(194, 111);
            this.txt_aciklama.TabIndex = 1;
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_tarih.Location = new System.Drawing.Point(269, 148);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(194, 24);
            this.dtp_tarih.TabIndex = 2;
            // 
            // cmb_odemeYontemi
            // 
            this.cmb_odemeYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_odemeYontemi.FormattingEnabled = true;
            this.cmb_odemeYontemi.Items.AddRange(new object[] {
            "Seçiniz",
            "KREDİ KARTI",
            "NAKİT",
            "AVANS"});
            this.cmb_odemeYontemi.Location = new System.Drawing.Point(269, 195);
            this.cmb_odemeYontemi.Name = "cmb_odemeYontemi";
            this.cmb_odemeYontemi.Size = new System.Drawing.Size(194, 28);
            this.cmb_odemeYontemi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(221, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(242, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "PARA GİRİŞİ";
            // 
            // btn_paraGiris
            // 
            this.btn_paraGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paraGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paraGiris.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_paraGiris.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_paraGiris.Location = new System.Drawing.Point(122, 368);
            this.btn_paraGiris.Name = "btn_paraGiris";
            this.btn_paraGiris.Size = new System.Drawing.Size(425, 41);
            this.btn_paraGiris.TabIndex = 5;
            this.btn_paraGiris.Text = "PARA GİRİŞİ";
            this.btn_paraGiris.UseVisualStyleBackColor = true;
            this.btn_paraGiris.Click += new System.EventHandler(this.btn_paraGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "TUTAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "ZAMAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "AÇIKLAMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "ÖDEME YÖNTEMİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(440, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "₺";
            // 
            // ParaGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(169)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(706, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_paraGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_odemeYontemi);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.txt_tutar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParaGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKSU HALI EVİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.ComboBox cmb_odemeYontemi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_paraGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

