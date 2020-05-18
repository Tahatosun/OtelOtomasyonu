using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelRezervasyonSistemi
{
	public class OtelOdaTipleri
	{
		enum OdaTipleri
		{
			DenizManzaraliEkonomik = 1,
			DenizManzaraliLuks = 2,
			KaraManzaraliEkonomik = 3,
			KaraManzaraliLuks = 4,
			IcCepheEkonomik = 5,
			IcCepheLuks = 6
		}
	}
}
