using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppileOPP.Entities
{
    public class Kisi
    {
        #region Properties
        private string _tcKimlik;
        public string TCKimlik
        {
            get
            {
                return _tcKimlik;
            }
            set
            {
                // gelen değer 11 haneli mi? değilse exception fırlasın
                // gelen değerde numeric ifade yoksa exception fırlasın
                if (!IstenilenKarakterKadarMisin(value))
                {
                    throw new Exception("TC Kimlik numarası 11 haneli oluşmalıdır!");
                }

                if (!TumKarakterlerRakamMi(value))
                {
                    throw new Exception("TC Kimlik numarası sadece rakamlardan oluşmalıdır!");
                }

                _tcKimlik = value;
            }
       }

        private string _ad;
        public string Ad
        {
            get
            {
                return _ad;
            }
            set
            {
                // Ad boş geçilmesin!
                if (value.Length==0)
                {
                    throw new Exception("HATA! Ad alanı boş geçilemez!");
                }
                if (value.Length <2 || value.Length >30)
                {
                    throw new Exception("HATA! Ad alanı en az 2 en fazla 30 karakter olmalıdır!");
                }
                _ad = value;
            }
        
        }
        public string Soyad { get; set; } // Soyad özelliğini siz kapsülleyiniz. Şartlatr boş geçilemez en az 2 en fazla 50 karakter olsun.
        public DateTime? DogumTarihi { get; set; } // herkes d.tarihini söylemek zorunda mı? HAYIR
        private byte _yas;
        public byte Yas
        {
            get
            {
                if (DogumTarihi!=null)
                {
                    _yas = Convert.ToByte(DateTime.Now.Year - DogumTarihi.Value.Year);
                }
                return _yas;
            }
        
        
        } //read-only property
        public Cinsiyet Cinsiyeti { get; set; }
        private string _telefon;
        public string Telefon
        {
            get
            {
                return _telefon;
            }
            set
            {
                // buraya geri döneceğiz....
                if (!IstenilenKarakterKadarMisin(value,10))
                {
                    throw new Exception("Telefon numarasını 5XXXXXXXXX şeklinde 10 haneli olarak giriniz!");
                }

                if (TumKarakterlerRakamMi(value)==false)
                {
                    throw new Exception("Telefon numarası sadece rakamlardan oluşmalıdır!");
                }
                _telefon = value;
            }
        
        }
        #endregion
        


        static bool IstenilenKarakterKadarMisin(string metin, byte karakterSayisi=11) 
        {
            if (metin.Length != karakterSayisi)
            {
                return false;
            }
            return true;
        }
        static bool TumKarakterlerRakamMi(string metin) //IsAllCharacterDigit
        {
            foreach (var item in metin)
            {
                if (!char.IsDigit(item)) // bu karakter digit mi? 
                {
                    return false;
                }
            }

            return true;
        }

    }
    public enum Cinsiyet : byte
    {
        Bay = 0,
        Bayan = 1,
        Belirtilmemis = 2
    }
}
