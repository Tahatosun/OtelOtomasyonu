using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelRezervasyonSistemi
{
	public partial class AnaEkran : MetroFramework.Forms.MetroForm
	{
		public AnaEkran()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void tileYetkiliGiris_Click(object sender, EventArgs e)
		{
			if (txtBoxYetkiliKAdi.Text == "admin" && txtBoxYetkiliSifre.Text == "1234")
			{
				yetkiliEkrani yEkran = new yetkiliEkrani();
				yEkran.Show();
			}
			else
				MessageBox.Show("Yanlış Kullanıcı Adı/Şifre Girdiniz.");
		}

		private void tileMusteriGiris_Click(object sender, EventArgs e)
		{
			if (txtBoxMusteriKAdi.Text == "kullanici" && txtBoxMusteriSifre.Text == "1234")
			{
				musteriEkrani mEkran = new musteriEkrani();
				mEkran.Show();
			}
			else
				MessageBox.Show("Yanlış Kullanıcı Adı/Şifre Girdiniz.");
		}
	}
}
