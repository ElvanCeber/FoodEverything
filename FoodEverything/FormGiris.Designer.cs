namespace FoodEverything
{
    partial class FormGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.ComboKullanici = new System.Windows.Forms.ComboBox();
            this.TextSifre = new System.Windows.Forms.TextBox();
            this.ButonGiris = new System.Windows.Forms.Button();
            this.ButonCikis = new System.Windows.Forms.Button();
            this.Baslık = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboKullanici
            // 
            this.ComboKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboKullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboKullanici.FormattingEnabled = true;
            this.ComboKullanici.Location = new System.Drawing.Point(604, 168);
            this.ComboKullanici.Name = "ComboKullanici";
            this.ComboKullanici.Size = new System.Drawing.Size(193, 32);
            this.ComboKullanici.TabIndex = 1;
            this.ComboKullanici.SelectedIndexChanged += new System.EventHandler(this.ComboKullanici_SelectedIndexChanged);
            // 
            // TextSifre
            // 
            this.TextSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextSifre.Location = new System.Drawing.Point(604, 206);
            this.TextSifre.Multiline = true;
            this.TextSifre.Name = "TextSifre";
            this.TextSifre.PasswordChar = '*';
            this.TextSifre.Size = new System.Drawing.Size(193, 37);
            this.TextSifre.TabIndex = 2;
            this.TextSifre.Text = "123456";
            this.TextSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButonGiris
            // 
            this.ButonGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButonGiris.BackgroundImage")));
            this.ButonGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButonGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButonGiris.Location = new System.Drawing.Point(652, 259);
            this.ButonGiris.Name = "ButonGiris";
            this.ButonGiris.Size = new System.Drawing.Size(90, 45);
            this.ButonGiris.TabIndex = 3;
            this.ButonGiris.UseVisualStyleBackColor = true;
            this.ButonGiris.Click += new System.EventHandler(this.ButonGiris_Click);
            // 
            // ButonCikis
            // 
            this.ButonCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButonCikis.BackgroundImage")));
            this.ButonCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButonCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButonCikis.Location = new System.Drawing.Point(748, 259);
            this.ButonCikis.Name = "ButonCikis";
            this.ButonCikis.Size = new System.Drawing.Size(49, 45);
            this.ButonCikis.TabIndex = 4;
            this.ButonCikis.UseVisualStyleBackColor = true;
            this.ButonCikis.Click += new System.EventHandler(this.ButonCikis_Click);
            // 
            // Baslık
            // 
            this.Baslık.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Baslık.BackgroundImage")));
            this.Baslık.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Baslık.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Baslık.Location = new System.Drawing.Point(455, 29);
            this.Baslık.Name = "Baslık";
            this.Baslık.Size = new System.Drawing.Size(342, 133);
            this.Baslık.TabIndex = 5;
            this.Baslık.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(460, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(540, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // FormGiris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Baslık);
            this.Controls.Add(this.ButonCikis);
            this.Controls.Add(this.ButonGiris);
            this.Controls.Add(this.TextSifre);
            this.Controls.Add(this.ComboKullanici);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPaneli";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboKullanici;
        private System.Windows.Forms.TextBox TextSifre;
        private System.Windows.Forms.Button ButonGiris;
        private System.Windows.Forms.Button ButonCikis;
        private System.Windows.Forms.Button Baslık;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

