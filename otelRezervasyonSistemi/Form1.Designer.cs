namespace otelRezervasyonSistemi
{
	partial class AnaEkran
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
			this.girisEkrani = new MetroFramework.Controls.MetroTabControl();
			this.musteriGirisi = new MetroFramework.Controls.MetroTabPage();
			this.tileMusteriGiris = new MetroFramework.Controls.MetroTile();
			this.txtBoxMusteriSifre = new MetroFramework.Controls.MetroTextBox();
			this.txtBoxMusteriKAdi = new MetroFramework.Controls.MetroTextBox();
			this.lblSifre = new MetroFramework.Controls.MetroLabel();
			this.lblKAdi = new MetroFramework.Controls.MetroLabel();
			this.yetkiliGirisi = new MetroFramework.Controls.MetroTabPage();
			this.tileYetkiliGiris = new MetroFramework.Controls.MetroTile();
			this.txtBoxYetkiliSifre = new MetroFramework.Controls.MetroTextBox();
			this.txtBoxYetkiliKAdi = new MetroFramework.Controls.MetroTextBox();
			this.lblSifre2 = new MetroFramework.Controls.MetroLabel();
			this.lblKAdi2 = new MetroFramework.Controls.MetroLabel();
			this.girisEkrani.SuspendLayout();
			this.musteriGirisi.SuspendLayout();
			this.yetkiliGirisi.SuspendLayout();
			this.SuspendLayout();
			// 
			// girisEkrani
			// 
			this.girisEkrani.Controls.Add(this.musteriGirisi);
			this.girisEkrani.Controls.Add(this.yetkiliGirisi);
			this.girisEkrani.Location = new System.Drawing.Point(23, 63);
			this.girisEkrani.Name = "girisEkrani";
			this.girisEkrani.SelectedIndex = 1;
			this.girisEkrani.Size = new System.Drawing.Size(743, 348);
			this.girisEkrani.TabIndex = 0;
			// 
			// musteriGirisi
			// 
			this.musteriGirisi.Controls.Add(this.tileMusteriGiris);
			this.musteriGirisi.Controls.Add(this.txtBoxMusteriSifre);
			this.musteriGirisi.Controls.Add(this.txtBoxMusteriKAdi);
			this.musteriGirisi.Controls.Add(this.lblSifre);
			this.musteriGirisi.Controls.Add(this.lblKAdi);
			this.musteriGirisi.HorizontalScrollbarBarColor = true;
			this.musteriGirisi.Location = new System.Drawing.Point(4, 35);
			this.musteriGirisi.Name = "musteriGirisi";
			this.musteriGirisi.Size = new System.Drawing.Size(735, 309);
			this.musteriGirisi.TabIndex = 0;
			this.musteriGirisi.Text = "Müşteri Girişi";
			this.musteriGirisi.VerticalScrollbarBarColor = true;
			// 
			// tileMusteriGiris
			// 
			this.tileMusteriGiris.Location = new System.Drawing.Point(264, 177);
			this.tileMusteriGiris.Name = "tileMusteriGiris";
			this.tileMusteriGiris.Size = new System.Drawing.Size(139, 26);
			this.tileMusteriGiris.TabIndex = 6;
			this.tileMusteriGiris.Text = "Giriş";
			this.tileMusteriGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileMusteriGiris.Click += new System.EventHandler(this.tileMusteriGiris_Click);
			// 
			// txtBoxMusteriSifre
			// 
			this.txtBoxMusteriSifre.Location = new System.Drawing.Point(264, 113);
			this.txtBoxMusteriSifre.Name = "txtBoxMusteriSifre";
			this.txtBoxMusteriSifre.PasswordChar = '*';
			this.txtBoxMusteriSifre.Size = new System.Drawing.Size(139, 23);
			this.txtBoxMusteriSifre.TabIndex = 5;
			// 
			// txtBoxMusteriKAdi
			// 
			this.txtBoxMusteriKAdi.Location = new System.Drawing.Point(264, 67);
			this.txtBoxMusteriKAdi.Name = "txtBoxMusteriKAdi";
			this.txtBoxMusteriKAdi.Size = new System.Drawing.Size(139, 23);
			this.txtBoxMusteriKAdi.TabIndex = 4;
			// 
			// lblSifre
			// 
			this.lblSifre.AutoSize = true;
			this.lblSifre.Location = new System.Drawing.Point(219, 113);
			this.lblSifre.Name = "lblSifre";
			this.lblSifre.Size = new System.Drawing.Size(38, 19);
			this.lblSifre.TabIndex = 3;
			this.lblSifre.Text = "Şifre:";
			// 
			// lblKAdi
			// 
			this.lblKAdi.AutoSize = true;
			this.lblKAdi.Location = new System.Drawing.Point(175, 72);
			this.lblKAdi.Name = "lblKAdi";
			this.lblKAdi.Size = new System.Drawing.Size(82, 19);
			this.lblKAdi.TabIndex = 2;
			this.lblKAdi.Text = "Kullanıcı Adı:";
			// 
			// yetkiliGirisi
			// 
			this.yetkiliGirisi.Controls.Add(this.tileYetkiliGiris);
			this.yetkiliGirisi.Controls.Add(this.txtBoxYetkiliSifre);
			this.yetkiliGirisi.Controls.Add(this.txtBoxYetkiliKAdi);
			this.yetkiliGirisi.Controls.Add(this.lblSifre2);
			this.yetkiliGirisi.Controls.Add(this.lblKAdi2);
			this.yetkiliGirisi.HorizontalScrollbarBarColor = true;
			this.yetkiliGirisi.Location = new System.Drawing.Point(4, 35);
			this.yetkiliGirisi.Name = "yetkiliGirisi";
			this.yetkiliGirisi.Size = new System.Drawing.Size(735, 309);
			this.yetkiliGirisi.TabIndex = 1;
			this.yetkiliGirisi.Text = "Yetkili Girişi";
			this.yetkiliGirisi.VerticalScrollbarBarColor = true;
			// 
			// tileYetkiliGiris
			// 
			this.tileYetkiliGiris.Location = new System.Drawing.Point(264, 177);
			this.tileYetkiliGiris.Name = "tileYetkiliGiris";
			this.tileYetkiliGiris.Size = new System.Drawing.Size(139, 26);
			this.tileYetkiliGiris.TabIndex = 8;
			this.tileYetkiliGiris.Text = "Giriş";
			this.tileYetkiliGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileYetkiliGiris.Click += new System.EventHandler(this.tileYetkiliGiris_Click);
			// 
			// txtBoxYetkiliSifre
			// 
			this.txtBoxYetkiliSifre.Location = new System.Drawing.Point(264, 113);
			this.txtBoxYetkiliSifre.Name = "txtBoxYetkiliSifre";
			this.txtBoxYetkiliSifre.PasswordChar = '*';
			this.txtBoxYetkiliSifre.Size = new System.Drawing.Size(139, 23);
			this.txtBoxYetkiliSifre.TabIndex = 7;
			// 
			// txtBoxYetkiliKAdi
			// 
			this.txtBoxYetkiliKAdi.Location = new System.Drawing.Point(264, 67);
			this.txtBoxYetkiliKAdi.Name = "txtBoxYetkiliKAdi";
			this.txtBoxYetkiliKAdi.Size = new System.Drawing.Size(139, 23);
			this.txtBoxYetkiliKAdi.TabIndex = 6;
			// 
			// lblSifre2
			// 
			this.lblSifre2.AutoSize = true;
			this.lblSifre2.Location = new System.Drawing.Point(219, 113);
			this.lblSifre2.Name = "lblSifre2";
			this.lblSifre2.Size = new System.Drawing.Size(38, 19);
			this.lblSifre2.TabIndex = 5;
			this.lblSifre2.Text = "Şifre:";
			// 
			// lblKAdi2
			// 
			this.lblKAdi2.AutoSize = true;
			this.lblKAdi2.Location = new System.Drawing.Point(175, 72);
			this.lblKAdi2.Name = "lblKAdi2";
			this.lblKAdi2.Size = new System.Drawing.Size(82, 19);
			this.lblKAdi2.TabIndex = 4;
			this.lblKAdi2.Text = "Kullanıcı Adı:";
			// 
			// AnaEkran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.girisEkrani);
			this.Name = "AnaEkran";
			this.Text = "Otel Bilgi Sistemi";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.girisEkrani.ResumeLayout(false);
			this.musteriGirisi.ResumeLayout(false);
			this.musteriGirisi.PerformLayout();
			this.yetkiliGirisi.ResumeLayout(false);
			this.yetkiliGirisi.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl girisEkrani;
		private MetroFramework.Controls.MetroTabPage musteriGirisi;
		private MetroFramework.Controls.MetroTabPage yetkiliGirisi;
		private MetroFramework.Controls.MetroTile tileMusteriGiris;
		private MetroFramework.Controls.MetroTextBox txtBoxMusteriSifre;
		private MetroFramework.Controls.MetroTextBox txtBoxMusteriKAdi;
		private MetroFramework.Controls.MetroLabel lblSifre;
		private MetroFramework.Controls.MetroLabel lblKAdi;
		private MetroFramework.Controls.MetroTile tileYetkiliGiris;
		private MetroFramework.Controls.MetroTextBox txtBoxYetkiliSifre;
		private MetroFramework.Controls.MetroTextBox txtBoxYetkiliKAdi;
		private MetroFramework.Controls.MetroLabel lblSifre2;
		private MetroFramework.Controls.MetroLabel lblKAdi2;
	}
}

