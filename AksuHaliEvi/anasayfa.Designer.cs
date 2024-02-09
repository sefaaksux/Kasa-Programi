namespace AksuHaliEvi
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_anasayfa = new System.Windows.Forms.Label();
            this.btn_borcDus = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_borcListele = new System.Windows.Forms.Button();
            this.btn_borcGir = new System.Windows.Forms.Button();
            this.btn_islemDuzenle = new System.Windows.Forms.Button();
            this.btn_kasa = new System.Windows.Forms.Button();
            this.btn_paracikisListe = new System.Windows.Forms.Button();
            this.btn_paracikisisayfa = new System.Windows.Forms.Button();
            this.btn_paragirisListe = new System.Windows.Forms.Button();
            this.btn_paragirisisayfa = new System.Windows.Forms.Button();
            this.hedefPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.hedefPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbl_anasayfa);
            this.panel1.Controls.Add(this.btn_borcDus);
            this.panel1.Controls.Add(this.btn_borcListele);
            this.panel1.Controls.Add(this.btn_borcGir);
            this.panel1.Controls.Add(this.btn_islemDuzenle);
            this.panel1.Controls.Add(this.btn_kasa);
            this.panel1.Controls.Add(this.btn_paracikisListe);
            this.panel1.Controls.Add(this.btn_paracikisisayfa);
            this.panel1.Controls.Add(this.btn_paragirisListe);
            this.panel1.Controls.Add(this.btn_paragirisisayfa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 640);
            this.panel1.TabIndex = 2;
            // 
            // lbl_anasayfa
            // 
            this.lbl_anasayfa.AutoSize = true;
            this.lbl_anasayfa.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_anasayfa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_anasayfa.Location = new System.Drawing.Point(104, 3);
            this.lbl_anasayfa.Name = "lbl_anasayfa";
            this.lbl_anasayfa.Size = new System.Drawing.Size(93, 18);
            this.lbl_anasayfa.TabIndex = 7;
            this.lbl_anasayfa.Text = "ANASAYFA";
            this.lbl_anasayfa.Click += new System.EventHandler(this.lbl_anasayfa_Click);
            // 
            // btn_borcDus
            // 
            this.btn_borcDus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_borcDus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borcDus.FlatAppearance.BorderSize = 0;
            this.btn_borcDus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borcDus.Font = new System.Drawing.Font("Cambria", 17F);
            this.btn_borcDus.ForeColor = System.Drawing.Color.Red;
            this.btn_borcDus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_borcDus.ImageKey = "debtDown.png";
            this.btn_borcDus.ImageList = this.ımageList1;
            this.btn_borcDus.Location = new System.Drawing.Point(11, 346);
            this.btn_borcDus.Name = "btn_borcDus";
            this.btn_borcDus.Size = new System.Drawing.Size(213, 57);
            this.btn_borcDus.TabIndex = 3;
            this.btn_borcDus.Text = "BORÇ DÜŞ";
            this.btn_borcDus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borcDus.UseVisualStyleBackColor = false;
            this.btn_borcDus.Click += new System.EventHandler(this.btn_borcDus_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add_icoı.png");
            this.ımageList1.Images.SetKeyName(1, "trash.png");
            this.ımageList1.Images.SetKeyName(2, "list.png");
            this.ımageList1.Images.SetKeyName(3, "delete_ico.png");
            this.ımageList1.Images.SetKeyName(4, "total.png");
            this.ımageList1.Images.SetKeyName(5, "debtDown.png");
            this.ımageList1.Images.SetKeyName(6, "debt.png");
            this.ımageList1.Images.SetKeyName(7, "edit.png");
            // 
            // btn_borcListele
            // 
            this.btn_borcListele.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_borcListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borcListele.FlatAppearance.BorderSize = 0;
            this.btn_borcListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borcListele.Font = new System.Drawing.Font("Cambria", 15.5F);
            this.btn_borcListele.ForeColor = System.Drawing.Color.Blue;
            this.btn_borcListele.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_borcListele.ImageKey = "list.png";
            this.btn_borcListele.ImageList = this.ımageList1;
            this.btn_borcListele.Location = new System.Drawing.Point(11, 409);
            this.btn_borcListele.Name = "btn_borcListele";
            this.btn_borcListele.Size = new System.Drawing.Size(213, 57);
            this.btn_borcListele.TabIndex = 4;
            this.btn_borcListele.Text = "BORÇ LİSTELE";
            this.btn_borcListele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borcListele.UseVisualStyleBackColor = false;
            this.btn_borcListele.Click += new System.EventHandler(this.btn_borcListele_Click);
            // 
            // btn_borcGir
            // 
            this.btn_borcGir.BackColor = System.Drawing.Color.Teal;
            this.btn_borcGir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borcGir.FlatAppearance.BorderSize = 0;
            this.btn_borcGir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borcGir.Font = new System.Drawing.Font("Cambria", 17F);
            this.btn_borcGir.ForeColor = System.Drawing.Color.White;
            this.btn_borcGir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_borcGir.ImageKey = "debt.png";
            this.btn_borcGir.ImageList = this.ımageList1;
            this.btn_borcGir.Location = new System.Drawing.Point(11, 283);
            this.btn_borcGir.Name = "btn_borcGir";
            this.btn_borcGir.Size = new System.Drawing.Size(213, 57);
            this.btn_borcGir.TabIndex = 2;
            this.btn_borcGir.Text = "BORÇ GİR";
            this.btn_borcGir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borcGir.UseVisualStyleBackColor = false;
            this.btn_borcGir.Click += new System.EventHandler(this.btn_borcGir_Click);
            // 
            // btn_islemDuzenle
            // 
            this.btn_islemDuzenle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_islemDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_islemDuzenle.FlatAppearance.BorderSize = 0;
            this.btn_islemDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_islemDuzenle.Font = new System.Drawing.Font("Cambria", 15F);
            this.btn_islemDuzenle.ForeColor = System.Drawing.Color.Black;
            this.btn_islemDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_islemDuzenle.ImageKey = "edit.png";
            this.btn_islemDuzenle.ImageList = this.ımageList1;
            this.btn_islemDuzenle.Location = new System.Drawing.Point(11, 494);
            this.btn_islemDuzenle.Name = "btn_islemDuzenle";
            this.btn_islemDuzenle.Size = new System.Drawing.Size(213, 57);
            this.btn_islemDuzenle.TabIndex = 5;
            this.btn_islemDuzenle.Text = "İŞLEM DÜZENLE";
            this.btn_islemDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_islemDuzenle.UseVisualStyleBackColor = false;
            this.btn_islemDuzenle.Click += new System.EventHandler(this.btn_islemDuzenle_Click);
            // 
            // btn_kasa
            // 
            this.btn_kasa.BackColor = System.Drawing.Color.DarkGray;
            this.btn_kasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kasa.FlatAppearance.BorderSize = 0;
            this.btn_kasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kasa.Font = new System.Drawing.Font("Cambria", 17F);
            this.btn_kasa.ForeColor = System.Drawing.Color.Black;
            this.btn_kasa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kasa.ImageKey = "total.png";
            this.btn_kasa.ImageList = this.ımageList1;
            this.btn_kasa.Location = new System.Drawing.Point(11, 557);
            this.btn_kasa.Name = "btn_kasa";
            this.btn_kasa.Padding = new System.Windows.Forms.Padding(9);
            this.btn_kasa.Size = new System.Drawing.Size(213, 74);
            this.btn_kasa.TabIndex = 6;
            this.btn_kasa.Text = "KASA";
            this.btn_kasa.UseVisualStyleBackColor = false;
            this.btn_kasa.Click += new System.EventHandler(this.btn_kasa_Click);
            // 
            // btn_paracikisListe
            // 
            this.btn_paracikisListe.BackColor = System.Drawing.Color.Crimson;
            this.btn_paracikisListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paracikisListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paracikisListe.Font = new System.Drawing.Font("Cambria", 17F);
            this.btn_paracikisListe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_paracikisListe.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_paracikisListe.ImageKey = "list.png";
            this.btn_paracikisListe.ImageList = this.ımageList1;
            this.btn_paracikisListe.Location = new System.Drawing.Point(11, 220);
            this.btn_paracikisListe.Name = "btn_paracikisListe";
            this.btn_paracikisListe.Size = new System.Drawing.Size(213, 45);
            this.btn_paracikisListe.TabIndex = 1;
            this.btn_paracikisListe.Text = "LİSTELE";
            this.btn_paracikisListe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_paracikisListe.UseVisualStyleBackColor = false;
            this.btn_paracikisListe.Click += new System.EventHandler(this.btn_paracikisListe_Click);
            // 
            // btn_paracikisisayfa
            // 
            this.btn_paracikisisayfa.BackColor = System.Drawing.Color.Crimson;
            this.btn_paracikisisayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paracikisisayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paracikisisayfa.Font = new System.Drawing.Font("Cambria", 17F);
            this.btn_paracikisisayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_paracikisisayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_paracikisisayfa.ImageKey = "trash.png";
            this.btn_paracikisisayfa.ImageList = this.ımageList1;
            this.btn_paracikisisayfa.Location = new System.Drawing.Point(11, 156);
            this.btn_paracikisisayfa.Name = "btn_paracikisisayfa";
            this.btn_paracikisisayfa.Size = new System.Drawing.Size(213, 59);
            this.btn_paracikisisayfa.TabIndex = 1;
            this.btn_paracikisisayfa.Text = "PARA ÇIKIŞI";
            this.btn_paracikisisayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_paracikisisayfa.UseVisualStyleBackColor = false;
            this.btn_paracikisisayfa.Click += new System.EventHandler(this.btn_paracikisisayfa_Click_1);
            // 
            // btn_paragirisListe
            // 
            this.btn_paragirisListe.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_paragirisListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paragirisListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paragirisListe.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paragirisListe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_paragirisListe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_paragirisListe.ImageKey = "list.png";
            this.btn_paragirisListe.ImageList = this.ımageList1;
            this.btn_paragirisListe.Location = new System.Drawing.Point(11, 92);
            this.btn_paragirisListe.Name = "btn_paragirisListe";
            this.btn_paragirisListe.Size = new System.Drawing.Size(213, 45);
            this.btn_paragirisListe.TabIndex = 0;
            this.btn_paragirisListe.Text = "LİSTELE";
            this.btn_paragirisListe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_paragirisListe.UseVisualStyleBackColor = false;
            this.btn_paragirisListe.Click += new System.EventHandler(this.btn_paragirisListe_Click);
            // 
            // btn_paragirisisayfa
            // 
            this.btn_paragirisisayfa.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_paragirisisayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paragirisisayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paragirisisayfa.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paragirisisayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_paragirisisayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_paragirisisayfa.ImageKey = "add_icoı.png";
            this.btn_paragirisisayfa.ImageList = this.ımageList1;
            this.btn_paragirisisayfa.Location = new System.Drawing.Point(11, 27);
            this.btn_paragirisisayfa.Name = "btn_paragirisisayfa";
            this.btn_paragirisisayfa.Size = new System.Drawing.Size(213, 59);
            this.btn_paragirisisayfa.TabIndex = 0;
            this.btn_paragirisisayfa.Text = "PARA GİRİŞİ";
            this.btn_paragirisisayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_paragirisisayfa.UseVisualStyleBackColor = false;
            this.btn_paragirisisayfa.Click += new System.EventHandler(this.btn_paragirisisayfa_Click_1);
            // 
            // hedefPanel
            // 
            this.hedefPanel.Controls.Add(this.label1);
            this.hedefPanel.Controls.Add(this.pictureBox1);
            this.hedefPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.hedefPanel.Location = new System.Drawing.Point(243, 0);
            this.hedefPanel.Name = "hedefPanel";
            this.hedefPanel.Size = new System.Drawing.Size(917, 640);
            this.hedefPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(636, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright © 2024, CELAL SAFA AKSU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(917, 640);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1160, 640);
            this.Controls.Add(this.hedefPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKSU HALI EVİ";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.hedefPanel.ResumeLayout(false);
            this.hedefPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_kasa;
        private System.Windows.Forms.Button btn_paracikisisayfa;
        private System.Windows.Forms.Button btn_paragirisisayfa;
        private System.Windows.Forms.Panel hedefPanel;
        private System.Windows.Forms.Label lbl_anasayfa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_islemDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_borcGir;
        private System.Windows.Forms.Button btn_borcDus;
        private System.Windows.Forms.Button btn_borcListele;
        private System.Windows.Forms.Button btn_paracikisListe;
        private System.Windows.Forms.Button btn_paragirisListe;
        private System.Windows.Forms.ImageList ımageList1;
    }
}