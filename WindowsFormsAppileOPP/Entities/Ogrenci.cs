using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppileOPP.Entities
{
    public class Ogrenci  : Kisi //inheritance (kalıtım)
    {
        // class'n bir erişim belirleyecisi yoksa internal'dır. Sadece bulunduğu namespace içinde kullanılabilir.
        public static List<Ogrenci> Ogrenciler { get; set; }


        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
   
}
