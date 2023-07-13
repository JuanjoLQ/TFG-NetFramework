using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdWarehouse
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        public void addProductWarehouse(ceProduct p)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("insert into Product (Name, PricePerUnit, Amount, " +
                "UnitOfMeasure, ProductCategory, State, Warehouses_idWarehouses) " +
                "values(@name, @pricePerUnit, @amount, @unitOfMeasure, @productCategory, @state, @idWarehouse);", conn))
                {
                    cmd.Parameters.AddWithValue("@name", p.name);
                    cmd.Parameters.AddWithValue("@pricePerUnit", p.pricePerUnit);
                    cmd.Parameters.AddWithValue("@amount", p.amount);
                    cmd.Parameters.AddWithValue("@unitOfMeasure", p.unitOfMeasure);
                    cmd.Parameters.AddWithValue("@productCategory", p.productCategory);
                    cmd.Parameters.AddWithValue("@state", p.state);
                    cmd.Parameters.AddWithValue("@idWarehouse", p.idWarehouse);
                    MessageBox.Show("Id del warehouse: " + p.idWarehouse);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Product añadido al Warehouse", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int idWarehouse(string name)
        {
            int idWarehouse = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idWarehouses FROM warehouses WHERE name = ?nameWarehouse;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?nameWarehouse", name);

                var row = command.ExecuteReader();
                
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        idWarehouse = int.Parse(row["idWarehouses"].ToString());                        
                    }
                }
                else
                {
                    MessageBox.Show("No hay warehouses correspondientes al indicado.");
                }                

                row.Close();// Close reader.
                conn.Close();// Close connection.
                
                return idWarehouse;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            return idWarehouse;
        }

        public void addWarehouse(ceWarehouse w)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("insert into Warehouses (idWarehouses, Name) " +
                "values(@idWarehouses, @name);", conn))
                {
                    cmd.Parameters.AddWithValue("@idWarehouses", w.idWarehouse);
                    cmd.Parameters.AddWithValue("@name", w.Name);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Warehouse añadido", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ArrayList getWarehouses()
        {
            ArrayList array = new ArrayList();
            
            try
            {
                array.Clear();
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idWarehouses, Name FROM Warehouses;";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();
                int idWarehouse;
                string nameWarehouse = string.Empty;
                ceWarehouse warehouse = null;
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        idWarehouse = int.Parse(row["idWarehouses"].ToString());
                        nameWarehouse = row["Name"].ToString();
                        warehouse = new ceWarehouse(idWarehouse, nameWarehouse);
                        array.Add(warehouse);
                    }
                }
                else
                {
                    //MessageBox.Show("No hay Warehouses.");
                }
                array.Add(new ceWarehouse(0, "No stored"));

                row.Close();// Close reader.
                conn.Close();// Close connection.

                return array;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            return array;
        }

        public ArrayList obtainProductsFromWarehouses(int idToFind)
        {
            ArrayList array = new ArrayList();
            try
            {
                array.Clear();
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idProduct, Name, PricePerUnit, Amount, UnitOfMeasure, ProductCategory, State FROM Product " +
                    "WHERE Warehouses_idWarehouses = ?idWarehouse;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?idWarehouse", idToFind);

                var row = command.ExecuteReader();
                int idProduct;
                string nameProduct = string.Empty;
                float pricePerUnit;
                float amount;
                string unitOfMeasure = string.Empty;
                string productCategory = string.Empty;
                string state = string.Empty;

                ceProduct p = null;
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        idProduct = int.Parse(row["idProduct"].ToString());
                        nameProduct = row["Name"].ToString();
                        pricePerUnit = float.Parse(row["PricePerUnit"].ToString());
                        amount = float.Parse(row["Amount"].ToString());
                        unitOfMeasure = row["UnitOfMeasure"].ToString();
                        productCategory = row["ProductCategory"].ToString();
                        state = row["state"].ToString();

                        p = new ceProduct(idProduct, nameProduct, pricePerUnit, amount, unitOfMeasure, productCategory, state);
                        array.Add(p);
                    }
                }
                else
                {
                    MessageBox.Show("No hay productos en este Warehouse.");
                }

                row.Close();// Close reader.
                conn.Close();// Close connection.

                return array;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            return array;
        }

        public void productNoStoredToStored(int idProduct, int amount, string newWarehouse)
        {
            int idWar = idWarehouse(newWarehouse);

            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("UPDATE Product SET Warehouses_idWarehouses = @newWarehouse, State = @state WHERE idProduct = @idProduct;", conn))
                {
                    cmd.Parameters.AddWithValue("@newWarehouse", idWar);
                    cmd.Parameters.AddWithValue("@state", "Stored");
                    cmd.Parameters.AddWithValue("@idProduct", idProduct);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Product alamcenado en warehouse", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void splitProductNoStoredAndStored(ceProduct p, int idProduct, int amount, int maxQt, string newWarehouse)
        {
            int idWar = idWarehouse(newWarehouse);
            int amountNoStored = maxQt - amount;

            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("UPDATE Product SET amount = @newAmount WHERE idProduct = @idProduct;", conn))
                {
                    cmd.Parameters.AddWithValue("@newAmount", amountNoStored);
                    cmd.Parameters.AddWithValue("@idProduct", idProduct);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Product almacenado en warehouse", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                p.idWarehouse = idWar;
                p.amount = maxQt - amountNoStored;
                addProductWarehouse(p);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public ArrayList obtainAllProductsFromWarehouses()
        {
            ArrayList array = new ArrayList();
            try
            {
                array.Clear();
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idProduct, Name, PricePerUnit, Amount, UnitOfMeasure, ProductCategory, State FROM Product " +
                    "WHERE State = ?state;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?state", "Stored");

                var row = command.ExecuteReader();
                int idProduct;
                string nameProduct = string.Empty;
                float pricePerUnit;
                float amount;
                string unitOfMeasure = string.Empty;
                string productCategory = string.Empty;
                string state = string.Empty;

                ceProduct p = null;
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        idProduct = int.Parse(row["idProduct"].ToString());
                        nameProduct = row["Name"].ToString();
                        pricePerUnit = float.Parse(row["PricePerUnit"].ToString());
                        amount = float.Parse(row["Amount"].ToString());
                        unitOfMeasure = row["UnitOfMeasure"].ToString();
                        productCategory = row["ProductCategory"].ToString();
                        state = row["state"].ToString();

                        p = new ceProduct(idProduct, nameProduct, pricePerUnit, amount, unitOfMeasure, productCategory, state);
                        array.Add(p);
                    }
                }
                else
                {
                    MessageBox.Show("No hay productos en este Warehouse.");
                }

                row.Close();// Close reader.
                conn.Close();// Close connection.

                return array;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            return array;
        }

        public bool checkExistProductInTransit(int idProduct)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idProductsInTransit FROM ProductsInTransit WHERE Product_idProduct = ?idProduct;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?idProduct", idProduct);

                var row = command.ExecuteReader();
                int idProductInTransit = 0;
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        idProductInTransit = int.Parse(row["idProductsInTransit"].ToString());

                    }
                }
                
                row.Close();// Close reader.
                conn.Close();// Close connection.

                if (idProductInTransit == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            return false;
        }

        public void createProductInTransit(int idProduct)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("insert into ProductsInTransit (Product_idProduct, EnTransito) " +
                "values(@idProduct, @enTransito);", conn))
                {
                    cmd.Parameters.AddWithValue("@idProduct", idProduct);
                    cmd.Parameters.AddWithValue("@enTransito", false);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("ProductInTransit añadido", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void transferProductOtherWarehouse(int idProduct, string warehouseOrigin, string destinationWarehouse, string fechaInicio, string fechaLlegada)
        {
            int idWarehouseDestination = idWarehouse(destinationWarehouse);

            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                // Si no existe el productoInTransit se crea
                if (!checkExistProductInTransit(idProduct))
                {
                    createProductInTransit(idProduct);
                }





                MessageBox.Show(warehouseOrigin);

                using (cmd = new MySqlCommand("UPDATE ProductsInTransit SET Origen = @Origen, Destino = @Destino, " +
                    "FechaInicioTransporte = @FechaInicioTransporte, FechaFinalTransporte = @FechaFinalTransporte, " +
                    "EnTransito = @EnTransito WHERE Product_idProduct = Product_idProduct; ", conn))
                {
                    cmd.Parameters.AddWithValue("@Origen", warehouseOrigin);
                    cmd.Parameters.AddWithValue("@Destino", destinationWarehouse);
                    cmd.Parameters.AddWithValue("@FechaInicioTransporte", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFinalTransporte", fechaLlegada);
                    cmd.Parameters.AddWithValue("@EnTransito", true);
                    cmd.Parameters.AddWithValue("@Product_idProduct", idProduct);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Producto en tránsito", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

                conn.Open();

                using (cmd = new MySqlCommand("UPDATE Product SET State = @state WHERE idProduct = @idProduct;", conn))
                {
                    cmd.Parameters.AddWithValue("@state", "In transit");
                    cmd.Parameters.AddWithValue("@idProduct", idProduct);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Lead Actualizado", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void checkInTransitProducts()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT Product.idProduct, ProductsInTransit.Destino FROM Product INNER JOIN ProductsInTransit " +
                    "ON Product.idProduct = ProductsInTransit.Product_idProduct " +
                    "WHERE ProductsInTransit.EnTransito = true and FechaFinalTransporte <= NOW();";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        int idProduct = int.Parse(row["idProduct"].ToString());
                        string destino = row["Destino"].ToString();
                        checkOutTransitProducts(idProduct, destino);

                    }
                }

                row.Close();// Close reader.
                conn.Close();// Close connection.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public void checkOutTransitProducts(int idProduct, string destino)
        {
            int idDestino = idWarehouse(destino);

            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("UPDATE Product " +
                    "INNER JOIN ProductsInTransit ON Product.idProduct = ProductsInTransit.Product_idProduct " +
                    "SET Product.State = 'Stored', Product.Warehouses_idWarehouses = @idDestino, ProductsInTransit.EnTransito = false " +
                    "WHERE Product.idProduct = @idProduct;", conn))
                {
                    cmd.Parameters.AddWithValue("@idDestino", idDestino);
                    cmd.Parameters.AddWithValue("@idProduct", idProduct);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
