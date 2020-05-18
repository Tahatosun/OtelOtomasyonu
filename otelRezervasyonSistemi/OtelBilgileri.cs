using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelRezervasyonSistemi
{
	public class OtelBilgileri
	{
		public string OtelAdi { get; set; }
		public string Otelİl { get; set; }
		public string OtelIlce { get; set;}
		public IletisimBilgileri IletisimBilgileri { get; set; }
		public int YildizSayisi { get; set; }
		public int OdaSayisi { get; set; }
		public OtelOdaTipleri OtelOdaTipleri { get; set; }
		public int OtelPuani { get; set; }

	}
}
