using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppOOP_StructVeClassFarklari
{
    public struct OgrenciYapisi
    {
        //Struct yapı demektir
        //Bazı yönleriyle classa benzemektedir
        //Örn c#ta DateTime bir structtır.
        //structların içinde field, prop,ctor olabilir
        public string OgrAd { get; set; } 
        public string OgrSoyad { get; set; }
        
        public OgrenciYapisi(string ad, string soyad)
        {
            //Struct parametresiz default ctor denilen yapıyı alamaz
            OgrAd = ad;
            OgrSoyad = soyad;
            // ctor oluşturulacaksa struct içindeki propertylerin setlenmesi gerekiyor
        }
    }
}
