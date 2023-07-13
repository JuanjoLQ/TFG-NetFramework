using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdProduct
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        public void addProduct(ceProduct p)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("insert into Product (Name, PricePerUnit, Amount, " +
                "UnitOfMeasure, ProductCategory, State) " +
                "values(@name, @pricePerUnit, @amount, @unitOfMeasure, @productCategory, @state);", conn))
                {
                    cmd.Parameters.AddWithValue("@name", p.name);
                    cmd.Parameters.AddWithValue("@pricePerUnit", p.pricePerUnit);
                    cmd.Parameters.AddWithValue("@amount", p.amount);
                    cmd.Parameters.AddWithValue("@unitOfMeasure", p.unitOfMeasure);
                    cmd.Parameters.AddWithValue("@productCategory", p.productCategory);
                    cmd.Parameters.AddWithValue("@state", p.state);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Product sin Warehouse asignado añadido", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void removeProduct(ceProduct p)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("DELETE FROM Product WHERE idProduct = @idProduct;", conn))
                {
                    cmd.Parameters.AddWithValue("@idProduct", p.idProduct);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Product Eliminado", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void modifyProductAmount(ceProduct p)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("UPDATE Product SET Amount = @amount WHERE idProduct = @idProduct;", conn))
                {
                    cmd.Parameters.AddWithValue("@amount", p.amount);
                    cmd.Parameters.AddWithValue("@idProduct", p.idProduct);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Product Actualizado", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ArrayList obtainNoStoredProducts()
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
                command.Parameters.AddWithValue("?state", "No stored");

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
                    MessageBox.Show("No hay Productos.");
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

        public ArrayList obtainSoldProducts(int idSale)
        {
            ArrayList array = new ArrayList();
            try
            {
                array.Clear();
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idProduct, Name, PricePerUnit, Amount, UnitOfMeasure, ProductCategory, State FROM Product " +
                    "WHERE Sales_idSale1 = ?idSale;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?idSale", idSale);

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
                    MessageBox.Show("No hay Productos.");
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

    }
}
