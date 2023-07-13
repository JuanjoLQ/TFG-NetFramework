namespace capaEntidad
{
    public class ceProduct
    {

        public ceProduct(string name, float pricePerUnit, float amount, 
            string unitOfMeasure, string productCategory, string state)
        {
            this.name = name;
            this.pricePerUnit = pricePerUnit;
            this.amount = amount;
            this.unitOfMeasure = unitOfMeasure;
            this.productCategory = productCategory;
            this.state = state;
        }

        public ceProduct(int idProduct, string name, float pricePerUnit, 
            float amount, string unitOfMeasure, string productCategory, string state)
        {
            this.idProduct = idProduct;
            this.name = name;
            this.pricePerUnit = pricePerUnit;
            this.amount = amount;
            this.unitOfMeasure = unitOfMeasure;
            this.productCategory = productCategory;
            this.state = state;
        }

        public ceProduct(int idWarehouse, int idSale, string name, float pricePerUnit, 
            float amount, string unitOfMeasure, string productCategory, string state)
        {
            this.idWarehouse = idWarehouse;
            this.idSale = idSale;
            this.name = name;
            this.pricePerUnit = pricePerUnit;
            this.amount = amount;
            this.unitOfMeasure = unitOfMeasure;
            this.productCategory = productCategory;
            this.state = state;
        }

        // Constructor para eliminar una cantidad
        // de un determinado producto
        public ceProduct(int idProduct, float amount)
        {
            this.idProduct = idProduct;
            this.amount = amount;
        }

        public int idProduct { get; set; }
        public int idWarehouse { get; set; }
        public int idSale { get; set; }
        public string name { get; set; }
        public float pricePerUnit { get; set; }
        public float amount { get; set; }
        public string unitOfMeasure { get; set; }
        public string productCategory { get; set; }
        public string state { get; set; }



    }
}
