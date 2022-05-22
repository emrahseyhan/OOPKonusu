using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppOOP_Polymorphism.Entities
{
    public class MaviKart : Akbil
    {
        public override string AkbilBas()
        {
            return base.AkbilBas(); // mavi kart akbil sınıfındaki
            //AkbilBas isimli metot nasıl davranıyorsa öyle davranacak
            //Dipnot: Eğer kalıtım aldığı yerdeki metotla aynı işlemi yapacaksa override etmeye gerek kalmaz.
            //Yani bu metodu yazmasanız daha doğrusu override etmezseniz daha performanslı olur.
        }
    }
}
