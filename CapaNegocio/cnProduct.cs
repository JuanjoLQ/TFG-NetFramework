using capaDatos;
using capaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class cnProduct
    {
        cdProduct cdProduct = new cdProduct();
        public void addProduct(ceProduct product)
        {
            cdProduct.addProduct(product);
        }

        public void removeProduct(ceProduct product)
        {
            cdProduct.removeProduct(product);
        }

        public void modifyProductAmount(ceProduct product)
        {
            cdProduct.modifyProductAmount(product);
        }

        public ArrayList obtainNoStoredProducts()
        {
            return cdProduct.obtainNoStoredProducts();
        }

    }
}
