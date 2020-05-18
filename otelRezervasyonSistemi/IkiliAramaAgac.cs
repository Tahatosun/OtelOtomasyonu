using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelRezervasyonSistemi
{
    public class IkiliAramaAgac
    {
        private IkiliAramaAgacDugumu kok;

        public IkiliAramaAgacDugumu Ara(string anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private IkiliAramaAgacDugumu AraInt(IkiliAramaAgacDugumu dugum,
                                            string anahtar)
        {
            if (dugum == null)
                return null;
            else if (string.Compare((dugum.veri as OtelAnaSınıf ).OtelBilgi.OtelAdi,anahtar)==0)
                return dugum;
            else if (string.Compare((dugum.veri as OtelAnaSınıf).OtelBilgi.OtelAdi, anahtar) == 1)
                return (AraInt(dugum.sol, anahtar));
            else
                return (AraInt(dugum.sag, anahtar));
        }

        public void Ekle(OtelAnaSınıf deger)
        {
            //Yeni eklenecek düğümün parent'ı
            IkiliAramaAgacDugumu tempParent = new IkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            IkiliAramaAgacDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (string.Compare(deger.OtelBilgi.OtelAdi, (tempSearch.veri as OtelAnaSınıf).OtelBilgi.OtelAdi)==0)
                    return;
                else if (string.Compare(deger.OtelBilgi.OtelAdi, (tempSearch.veri as OtelAnaSınıf).OtelBilgi.OtelAdi) == -1)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            IkiliAramaAgacDugumu eklenecek = new IkiliAramaAgacDugumu(deger);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;
            else if (string.Compare(deger.OtelBilgi.OtelAdi, (tempParent.veri as OtelAnaSınıf).OtelBilgi.OtelAdi) == -1)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }
        public void Guncelle(OtelAnaSınıf otel)
        {
             
                        
            IkiliAramaAgacDugumu tempSearch = kok;
            
            while (tempSearch != null)
            {
                if (string.Compare(otel.OtelBilgi.OtelAdi, (tempSearch.veri as OtelAnaSınıf).OtelBilgi.OtelAdi) == 0)
                {
                    tempSearch.veri = otel;
                    break;
                }
                else if (string.Compare(otel.OtelBilgi.OtelAdi, (tempSearch.veri as OtelAnaSınıf).OtelBilgi.OtelAdi) == -1)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
        }
        private IkiliAramaAgacDugumu Successor(IkiliAramaAgacDugumu silDugum)
        {
            IkiliAramaAgacDugumu successorParent = silDugum;
            IkiliAramaAgacDugumu successor = silDugum;
            IkiliAramaAgacDugumu current = silDugum.sag;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.sol;
            }
            if (successor != silDugum.sag)
            {
                successorParent.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;
        }
        public bool Sil(OtelAnaSınıf deger)
        {
            IkiliAramaAgacDugumu current = kok;
            IkiliAramaAgacDugumu parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL
            while (current.veri != deger)
            {
                parent = current;
                if (string.Compare(deger.OtelBilgi.OtelAdi,(current.veri as OtelAnaSınıf).OtelBilgi.OtelAdi)==-1)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                    kok = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sag = null;
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if (current == kok)
                    kok = current.sol;
                else if (issol)
                    parent.sol = current.sol;
                else
                    parent.sag = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kok)
                    kok = current.sag;
                else if (issol)
                    parent.sol = current.sag;
                else
                    parent.sag = current.sag;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                IkiliAramaAgacDugumu successor = Successor(current);
                if (current == kok)
                    kok = successor;
                else if (issol)
                    parent.sol = successor;
                else
                    parent.sag = successor;
                successor.sol = current.sol;
            }
            return true;
        }
    }
}
