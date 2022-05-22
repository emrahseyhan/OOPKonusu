using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppOOP_Polymorphism.Entities
{
    public class OgrenciAkbili: Akbil
    {
        //Ctor Constructor: Yapıcı metot
        //Class'ın ismiyle aynı isimde geri dönüşti verilmeyen özel bir metotdur
        //Ne zaman çalışır? Bu classtan bir nesne türetileceği zaman çalışır
        //Yani classın içindeki herşeyi (field, prop metot vb) bellekte inşa eder.
        //Özetle nesneyi yaratan metottur
        //public OgrenciAkbili() // Erişim belirleyicisi Classismi()
        //{
        //    //Default ctor 
        //    //Her classın default ctoru vardır.
        //    //İster yazın ister yazmayın her classın default ctoru vardır.
        //    //Yazmadığınız zaman arka planda c# onu oluşturuyor.
        //    //Yazarsanız ctor içinde işlemleriniz varsa yapabilirsiniz
        //}
        public OgrenciAkbili(decimal birBiletlikUcret) // parametreli ctor
        {
            BirBiletlikUcret = birBiletlikUcret;
        }

        public override string AkbilBas()
        {
            //return base.AkbilBas(); // burayı base.AkbilBas(); olarak bırakırsak
            ////Bu metot atadaki AkbilBas içindeki kodları çalıştırır. Yani 5 lira akbil ücreti ödenir
            Bakiye -= BirBiletlikUcret;
            return $"Öğrenci tipteki bu akbilden {BirBiletlikUcret} lira ücret alındı.";
        }
    }
}
