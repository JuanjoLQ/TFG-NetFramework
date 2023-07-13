using capaDatos;
using capaEntidad;
using System.Collections;

namespace CapaNegocio
{
    public class cnWarehouse
    {
        cdWarehouse cdWarehouse = new cdWarehouse();
        public void addProductWarehouse(ceProduct product)
        {
            cdWarehouse.addProductWarehouse(product);
        }

        public int idWarehouse(string name)
        {
            return cdWarehouse.idWarehouse(name);
        }

        public void addWarehouse(ceWarehouse warehouse)
        {
            cdWarehouse.addWarehouse(warehouse);
        }

        public ArrayList getWarehouses()
        {
            return cdWarehouse.getWarehouses();
        }

        public ArrayList obtainProductsFromWarehouses(int idWarehouse)
        {
            return cdWarehouse.obtainProductsFromWarehouses(idWarehouse);
        }

        public ArrayList obtainAllProductsFromWarehouses()
        {
            return cdWarehouse.obtainAllProductsFromWarehouses();
        }

        public void productNoStoredToStored(int idProduct, int amount, string newWarehouse)
        {
            cdWarehouse.productNoStoredToStored(idProduct, amount, newWarehouse);
        }

        public void splitProductNoStoredAndStored(ceProduct p, int idProduct, int amount, int maxQt, string newWarehouse)
        {
            cdWarehouse.splitProductNoStoredAndStored(p, idProduct, amount, maxQt, newWarehouse);
        }

        public void transferProductOtherWarehouse(int idProduct, string warehouseOrigin, string destinationWarehouse, string fechaInicio, string fechaLlegada)
        {
            cdWarehouse.transferProductOtherWarehouse(idProduct, warehouseOrigin, destinationWarehouse, fechaInicio, fechaLlegada);
        }

        public void checkInTransitProducts()
        {
            cdWarehouse.checkInTransitProducts();
        }

    }
}
