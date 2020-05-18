using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelRezervasyonSistemi
{
	public class OtelDepartman
	{
		enum OnBuroEkibi
		{
			Vale = 1,
			IdariIşlerÇalısani = 2,
			Resepsiyonist = 3

		}
		enum ServisEkibi
		{
			Garson = 1,
			Barmen = 2,
			Aşçı = 3
		}
		enum GenelHizmet
		{
			KatTemizlikçisi = 1,
			ÇamaşırYıkamaGörevllisi = 2,
		}
		enum Eglence
		{
			Animator = 1,
			Müzisyen = 2
		}
	}
}
