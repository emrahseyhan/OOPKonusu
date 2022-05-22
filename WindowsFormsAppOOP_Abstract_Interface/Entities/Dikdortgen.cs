using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppOOP_Abstract_Interface.AbstractEntities;
using WindowsFormsAppOOP_Abstract_Interface.Interfaces;

namespace WindowsFormsAppOOP_Abstract_Interface.Entities
{
    public class Dikdortgen : Sekil, IKosegenli, ICevresiVar, IAlanaSahiptir
    {
        //Bir class birden fazka classtan kalıtım alamaz
        //Bir class birden fazla interfaceden kalıtım alır.

        #region Properties
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }
        #endregion

        public double KosegenHesapla()
        {
            throw new NotImplementedException();
        }

        public double CevreHesapla()
        {
            try
            {
                return  2 * (KisaKenar+ UzunKenar);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double AlanHesapla()
        {
            try
            {
                return KisaKenar * UzunKenar;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
