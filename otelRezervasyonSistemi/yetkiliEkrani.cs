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
	public partial class yetkiliEkrani : MetroFramework.Forms.MetroForm
	{
		public yetkiliEkrani()
		{
			InitializeComponent();
		}

        IkiliAramaAgac ikiliAramaAgaci;

        public OtelAnaSınıf OtelBilgileri()
        {
            OtelAnaSınıf otel = new OtelAnaSınıf();
            OtelBilgileri otelBilgileri = new OtelBilgileri();
            IletisimBilgileri iletisimBilgileri = new IletisimBilgileri();

            otelBilgileri.OtelAdi = txtBoxYetkiliOtelAdı.Text;
            otelBilgileri.OtelIlce = txtBoxYetkiliİlçe.Text;
            otelBilgileri.Otelİl = txtBoxYetkiliİl.Text;           
            //otelBilgileri.OtelOdaTipleri = txtBoxYetkiliOdaTipi.Text;
            otelBilgileri.OdaSayisi = Convert.ToInt16(txtBoxYetkiliOdaSayisi.Text);
            otelBilgileri.YildizSayisi = Convert.ToInt16(txtBoxYetkiliYıldızSayisi.Text);
            iletisimBilgileri.adres = txtBoxYetkiliAdres.Text;
            iletisimBilgileri.ePosta = txtBoxYetkiliEposta.Text;
            iletisimBilgileri.telefonNo = txtBoxYetkiliTelefon.Text;


            otel.OtelBilgi = otelBilgileri;
            otel.OtelBilgi.IletisimBilgileri = iletisimBilgileri;
            return otel;
        }
        public void OtelEkle(OtelAnaSınıf otel)
        {
            
            ikiliAramaAgaci.Ekle(otel);
            MessageBox.Show("Otel başarıyla eklendi.");


        }
        public OtelCalisanBilgileri PersonelBilgileri()
        {
            OtelCalisanBilgileri otelCalisanBilgileri = new OtelCalisanBilgileri();
            IletisimBilgileri iletisimBilgileri = new IletisimBilgileri();

            otelCalisanBilgileri.Ad = txtPersonelAd.Text;
            otelCalisanBilgileri.Soyad = txtPersonelSoyad.Text;
            otelCalisanBilgileri.CalisanTcKimlikNo = txtPersonelTC.Text;
            otelCalisanBilgileri.PersonelPuani = Convert.ToInt16(txtPersonelPuan.Text);
            iletisimBilgileri.adres = txtPersonelAdres.Text;            
            iletisimBilgileri.ePosta = txtPersonelEposta.Text;
            iletisimBilgileri.telefonNo = txtPersonelTelefon.Text;
            otelCalisanBilgileri.CalisanIletisimBilgileri = iletisimBilgileri;
            return otelCalisanBilgileri;
        }

        public void personelEkle(OtelCalisanBilgileri personel, string otel)
        {
            OtelAnaSınıf _otel =  (ikiliAramaAgaci.Ara(otel).veri as OtelAnaSınıf);
            _otel.PersonelEkle(personel);

            ikiliAramaAgaci.Guncelle(_otel);
           
        }
		private void yetkiliEkrani_Load(object sender, EventArgs e)
		{
            ikiliAramaAgaci = new IkiliAramaAgac();
        }

        public void GuncelleTextBoxDoldur(IkiliAramaAgacDugumu _dugum)
        {
            txtBoxYetkiliOtelAdı.Text = (_dugum.veri as OtelAnaSınıf).OtelBilgi.OtelAdi;
            txtBoxYetkiliİl.Text = (_dugum.veri as OtelAnaSınıf).OtelBilgi.Otelİl;
            txtBoxYetkiliİlçe.Text = (_dugum.veri as OtelAnaSınıf).OtelBilgi.OtelIlce;
            txtBoxYetkiliAdres.Text = (_dugum.veri as OtelAnaSınıf).OtelBilgi.IletisimBilgileri.adres;
            txtBoxYetkiliTelefon.Text = (_dugum.veri as OtelAnaSınıf).OtelBilgi.IletisimBilgileri.telefonNo;
            txtBoxYetkiliEposta.Text = (_dugum.veri as OtelAnaSınıf).OtelBilgi.IletisimBilgileri.ePosta;
            txtBoxYetkiliYıldızSayisi.Text = (_dugum.veri as OtelAnaSınıf).OtelBilgi.YildizSayisi.ToString();
            txtBoxYetkiliOdaSayisi.Text = (_dugum.veri as OtelAnaSınıf).OtelBilgi.OdaSayisi.ToString();
           // txtBoxYetkiliOdaTipi.Text= (_dugum.veri as OtelAnaSınıf).OtelBilgi.OtelOdaTipleri.ToString();
            txtBoxYetkiliOtelPuani.Text = (_dugum.veri as OtelAnaSınıf).OtelBilgi.OtelPuani.ToString();
        }


		private void metroTile3_Click(object sender, EventArgs e)
		{

		}		

        private void tileOtelEkle_Click(object sender, EventArgs e)
        {
            OtelEkle(OtelBilgileri());
        }

        private void tilePersonelListele_Click(object sender, EventArgs e)
        {

        }

        private void tilePersonelBul_Click(object sender, EventArgs e)
        {

        }

        private void tilePersonelEkle_Click(object sender, EventArgs e)
        {
            personelEkle(PersonelBilgileri(),txtPersonelOtel.Text);
        }

        private void tileYekiliOtelBul_Click(object sender, EventArgs e)
        {
            if(ikiliAramaAgaci.Ara(txtBoxYetkiliOtelAdiArama.Text)!=null)
            {
                
                GuncelleTextBoxDoldur(ikiliAramaAgaci.Ara(txtBoxYetkiliOtelAdiArama.Text));
            }
            else
            {
                MessageBox.Show("Aradığınız isimde bir otel bulunmamaktadır.");
            }
            
            
        }

        private void tileOtelGuncelle_Click(object sender, EventArgs e)
        {
            ikiliAramaAgaci.Guncelle(OtelBilgileri());
        }

        private void tilePersonelGuncelle_Click(object sender, EventArgs e)
        {

        }
        public void OtelSil(string silinecekOtel )
        {
            OtelAnaSınıf _otel = (ikiliAramaAgaci.Ara(silinecekOtel).veri as OtelAnaSınıf);
            ikiliAramaAgaci.Sil(_otel);
        }
        private void tileOtelSil_Click(object sender, EventArgs e)
        {

            OtelSil(txtBoxYetkiliOtelAdı.Text);

        }
    }
}
