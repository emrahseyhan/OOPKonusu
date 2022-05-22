using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppOOP_Abstract_Interface.Entities;

namespace WindowsFormsAppOOP_Abstract_Interface.AbstractEntities
{
    public abstract class Sekil
    {
        //abstract soyut demektir
        // abstract classlar new ile nesne üretilemeyen soyut yapılardır
        #region Properties 
        public string SeklinAdi { get; set; }

        #endregion


        public void Yazdir()
        {
            // bu metodun gövdesi var.

        }
    }
}
