namespace KasaProgramı
{
    partial class İslemDuzenlemeSecim
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
            this.btn_paragirisduzenle = new System.Windows.Forms.Button();
            this.btn_paracikisduzenle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_paragirisduzenle
            // 
            this.btn_paragirisduzenle.BackColor = System.Drawing.Color.Green;
            this.btn_paragirisduzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paragirisduzenle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_paragirisduzenle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_paragirisduzenle.Location = new System.Drawing.Point(105, 75);
            this.btn_paragirisduzenle.Name = "btn_paragirisduzenle";
            this.btn_paragirisduzenle.Size = new System.Drawing.Size(157, 57);
            this.btn_paragirisduzenle.TabIndex = 0;
            this.btn_paragirisduzenle.Text = "PARA GİRİŞİ";
            this.btn_paragirisduzenle.UseVisualStyleBackColor = false;
            this.btn_paragirisduzenle.Click += new System.EventHandler(this.btn_paragirisduzenle_Click);
            // 
            // btn_paracikisduzenle
            // 
            this.btn_paracikisduzenle.BackColor = System.Drawing.Color.Red;
            this.btn_paracikisduzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paracikisduzenle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_paracikisduzenle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_paracikisduzenle.Location = new System.Drawing.Point(305, 75);
            this.btn_paracikisduzenle.Name = "btn_paracikisduzenle";
            this.btn_paracikisduzenle.Size = new System.Drawing.Size(152, 57);
            this.btn_paracikisduzenle.TabIndex = 1;
            this.btn_paracikisduzenle.Text = "PARA ÇIKIŞI";
            this.btn_paracikisduzenle.UseVisualStyleBackColor = false;
            this.btn_paracikisduzenle.Click += new System.EventHandler(this.btn_paracikisduzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "HANGİ TABLO İÇİN DÜZENLEME YAPMAK İSTİYORSUN ?";
            // 
            // İslemDuzenlemeSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(560, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_paracikisduzenle);
            this.Controls.Add(this.btn_paragirisduzenle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "İslemDuzenlemeSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞLEM DÜZENLEME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_paragirisduzenle;
        private System.Windows.Forms.Button btn_paracikisduzenle;
        private System.Windows.Forms.Label label1;
    }
}