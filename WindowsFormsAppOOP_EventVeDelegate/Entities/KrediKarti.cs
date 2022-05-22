using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppOOP_EventVeDelegate.Entities
{
    public class KrediKarti
    {
        public delegate void KalanLimitKontrolHandler();
        public event KalanLimitKontrolHandler KalanLimitEvent;

        public string KartSahibiAdSoyad { get; set; }

        private decimal _kullanilabilirLimit;
        public decimal KullanilabilirLimit {

            get
            {
                return _kullanilabilirLimit;
            }
            set
            {
                _kullanilabilirLimit = value;
                if (_kullanilabilirLimit <250 && KalanLimitEvent != null)
                {
                    KalanLimitEvent();
                }
            }
        }

        public void AlisverisYap(decimal tutar)
        {
            if (KullanilabilirLimit>250)
            {
                KullanilabilirLimit -= tutar;
                System.Windows.Forms.MessageBox.Show("KALAN LİMİT= " + KullanilabilirLimit);

            }
            else
            {
                KalanLimitEvent();
            }
        }
    }
}
