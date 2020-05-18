using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelRezervasyonSistemi
{
    public class IkiliAramaAgacDugumu
    {
        public object veri;
        public IkiliAramaAgacDugumu sol;
        public IkiliAramaAgacDugumu sag;
        public IkiliAramaAgacDugumu()
        {
        }

        public IkiliAramaAgacDugumu(object otelBilgi)
        {
            this.veri = otelBilgi;
            sol = null;
            sag = null;
        }
    }
}
