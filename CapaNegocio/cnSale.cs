using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class cnSale
    {
        cdSale cdSale = new cdSale();

        public void addSale(int idProduct, int idSale) 
        {
            cdSale.addSale(idProduct, idSale);
        }

        public void createSale(string datetime)
        {
            cdSale.createSale(datetime);
        }

        public int idSale(string datetime)
        {
            return cdSale.idSale(datetime);
        }


    }
}
