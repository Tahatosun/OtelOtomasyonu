namespace otelRezervasyonSistemi
{
	partial class musteriEkrani
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
            this.tileMusteriOtelListele = new MetroFramework.Controls.MetroTile();
            this.lblMEkranArama = new MetroFramework.Controls.MetroLabel();
            this.txtBoxAramaBilgisi = new MetroFramework.Controls.MetroTextBox();
            this.rdBtnMusteriİsimleArama = new MetroFramework.Controls.MetroRadioButton();
            this.rdBtnMusteriKonumlaAratma = new MetroFramework.Controls.MetroRadioButton();
            this.txtBoxOtelListesi = new MetroFramework.Controls.MetroTextBox();
            this.cmBoxListelemeTuru = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // tileMusteriOtelListele
            // 
            this.tileMusteriOtelListele.Location = new System.Drawing.Point(517, 112);
            this.tileMusteriOtelListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileMusteriOtelListele.Name = "tileMusteriOtelListele";
            this.tileMusteriOtelListele.Size = new System.Drawing.Size(227, 111);
            this.tileMusteriOtelListele.TabIndex = 0;
            this.tileMusteriOtelListele.Text = "Otelleri Listele";
            this.tileMusteriOtelListele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileMusteriOtelListele.Click += new System.EventHandler(this.tileMusteriOtelListele_Click);
            // 
            // lblMEkranArama
            // 
            this.lblMEkranArama.AutoSize = true;
            this.lblMEkranArama.Location = new System.Drawing.Point(31, 112);
            this.lblMEkranArama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMEkranArama.Name = "lblMEkranArama";
            this.lblMEkranArama.Size = new System.Drawing.Size(176, 20);
            this.lblMEkranArama.TabIndex = 1;
            this.lblMEkranArama.Text = "Otel İsmi, veya İl/İlçe Bilgisi:";
            // 
            // txtBoxAramaBilgisi
            // 
            this.txtBoxAramaBilgisi.Location = new System.Drawing.Point(32, 140);
            this.txtBoxAramaBilgisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxAramaBilgisi.Name = "txtBoxAramaBilgisi";
            this.txtBoxAramaBilgisi.Size = new System.Drawing.Size(395, 28);
            this.txtBoxAramaBilgisi.TabIndex = 2;
            // 
            // rdBtnMusteriİsimleArama
            // 
            this.rdBtnMusteriİsimleArama.AutoSize = true;
            this.rdBtnMusteriİsimleArama.Location = new System.Drawing.Point(32, 177);
            this.rdBtnMusteriİsimleArama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBtnMusteriİsimleArama.Name = "rdBtnMusteriİsimleArama";
            this.rdBtnMusteriİsimleArama.Size = new System.Drawing.Size(132, 17);
            this.rdBtnMusteriİsimleArama.TabIndex = 3;
            this.rdBtnMusteriİsimleArama.TabStop = true;
            this.rdBtnMusteriİsimleArama.Text = "Otel İsmi İle Arayın";
            this.rdBtnMusteriİsimleArama.UseVisualStyleBackColor = true;
            // 
            // rdBtnMusteriKonumlaAratma
            // 
            this.rdBtnMusteriKonumlaAratma.AutoSize = true;
            this.rdBtnMusteriKonumlaAratma.Location = new System.Drawing.Point(31, 204);
            this.rdBtnMusteriKonumlaAratma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBtnMusteriKonumlaAratma.Name = "rdBtnMusteriKonumlaAratma";
            this.rdBtnMusteriKonumlaAratma.Size = new System.Drawing.Size(243, 17);
            this.rdBtnMusteriKonumlaAratma.TabIndex = 4;
            this.rdBtnMusteriKonumlaAratma.TabStop = true;
            this.rdBtnMusteriKonumlaAratma.Text = "Otelin Bulunduğu İl/İlçeye Göre Arayın";
            this.rdBtnMusteriKonumlaAratma.UseVisualStyleBackColor = true;
            // 
            // txtBoxOtelListesi
            // 
            this.txtBoxOtelListesi.Location = new System.Drawing.Point(32, 279);
            this.txtBoxOtelListesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxOtelListesi.Multiline = true;
            this.txtBoxOtelListesi.Name = "txtBoxOtelListesi";
            this.txtBoxOtelListesi.Size = new System.Drawing.Size(1004, 246);
            this.txtBoxOtelListesi.TabIndex = 5;
            // 
            // cmBoxListelemeTuru
            // 
            this.cmBoxListelemeTuru.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cmBoxListelemeTuru.FormattingEnabled = true;
            this.cmBoxListelemeTuru.ItemHeight = 21;
            this.cmBoxListelemeTuru.Items.AddRange(new object[] {
            "Puan Bilgisine Göre",
            "Yıldız Sayısına Göre"});
            this.cmBoxListelemeTuru.Location = new System.Drawing.Point(789, 241);
            this.cmBoxListelemeTuru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmBoxListelemeTuru.Name = "cmBoxListelemeTuru";
            this.cmBoxListelemeTuru.Size = new System.Drawing.Size(245, 27);
            this.cmBoxListelemeTuru.TabIndex = 6;
            this.cmBoxListelemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmBoxListelemeTuru_SelectedIndexChanged);
            // 
            // musteriEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmBoxListelemeTuru);
            this.Controls.Add(this.txtBoxOtelListesi);
            this.Controls.Add(this.rdBtnMusteriKonumlaAratma);
            this.Controls.Add(this.rdBtnMusteriİsimleArama);
            this.Controls.Add(this.txtBoxAramaBilgisi);
            this.Controls.Add(this.lblMEkranArama);
            this.Controls.Add(this.tileMusteriOtelListele);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "musteriEkrani";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Hoş Geldiniz!";
            this.Load += new System.EventHandler(this.musteriEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTile tileMusteriOtelListele;
		private MetroFramework.Controls.MetroLabel lblMEkranArama;
		private MetroFramework.Controls.MetroTextBox txtBoxAramaBilgisi;
		private MetroFramework.Controls.MetroRadioButton rdBtnMusteriİsimleArama;
		private MetroFramework.Controls.MetroRadioButton rdBtnMusteriKonumlaAratma;
		private MetroFramework.Controls.MetroTextBox txtBoxOtelListesi;
		private MetroFramework.Controls.MetroComboBox cmBoxListelemeTuru;
	}
}