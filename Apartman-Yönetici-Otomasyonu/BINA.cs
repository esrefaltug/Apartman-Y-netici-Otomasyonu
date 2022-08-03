using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartman_Yönetici_Otomasyonu
{
    class BINA
    {
        public const int doludaireaidat = 40;
        
        public string BinaAdı { get; set; }
        public int ToplamDaireSayısı { get; set; }
        public int kasa { get; set; }
        public int DoluDaireSayısı { get; set; }
        public BINA(string _BinaAdı,int _ToplamDaireSayısı)
        {
            _BinaAdı = BinaAdı;
            _ToplamDaireSayısı = ToplamDaireSayısı;
        }
        public void aidatgiris()
        {
            kasa += doludaireaidat;
        }
        public void giderler(int gider)
        {
            kasa -= gider;
        }
        public int KasaSorgula()
        {
            return kasa;
        }
    }
}
