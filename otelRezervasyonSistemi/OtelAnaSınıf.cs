using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelRezervasyonSistemi
{
	public class OtelAnaSınıf
	{
		public OtelBilgileri OtelBilgi { get; set; }		
		public KullaniciYorum OtelYorum { get; set; }

        public List<OtelCalisanBilgileri> Personeller = new List<OtelCalisanBilgileri>();
        public void PersonelEkle(OtelCalisanBilgileri _personel)
        {
            Personeller.Add(_personel);
        }
        
	}
}
