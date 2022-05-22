using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppOOP_Abstract_Interface.AbstractEntities;
using WindowsFormsAppOOP_Abstract_Interface.Interfaces;

namespace WindowsFormsAppOOP_Abstract_Interface.Entities
{
    public class Kare : Sekil, IKosegenli,IAlanaSahiptir, ICevresiVar
    {
        #region Properties
        public int Kenar { get; set; }
              
        #endregion
        public double KosegenHesapla()
        {
           return 0d;
        }
        public double AlanHesapla()
        {
            try
            {
                return Math.Pow(Kenar, 2);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double CevreHesapla()
        {
            try
            {
                return 4 * Kenar;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
