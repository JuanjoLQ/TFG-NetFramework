using capaDatos;
using capaEntidad;
using System.Collections;

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

        public ArrayList obtainSoldProducts(int idSale)
        {
            return cdProduct.obtainSoldProducts(idSale);
        }

    }
}
