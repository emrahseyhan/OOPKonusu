using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppOOP_Polymorphism.Entities
{
    public class Akbil
    {
        public string SeriNumarasi { get; set; } //8 haneli olsun
        public DateTime SonGuncellestirmeTarihi { get; set; }
        public decimal Bakiye { get; set; } = 200;
        public KartTipleri KartTipi { get; set; } = KartTipleri.Standart;
        public decimal BirBiletlikUcret { get; set; } = 5;

        public virtual string AkbilBas()
        {
            Bakiye -= BirBiletlikUcret;
            return $"{KartTipi} tipteki bu akbilden {BirBiletlikUcret} lira ücret alındı.";
        }
    }

    public enum KartTipleri:byte
    {
        Standart=1,
        Ogrenci=2,
        Ogretmen=3,
        AnneKarti=4,
        YasliKarti=5,
        MaviKart=6
    }
}
