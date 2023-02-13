using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using MySql.Data.MySqlClient;

namespace capaDatos
{
    public class cdCompany
    {

        public void addCompany(ceCompany company, MySqlConnection conn) 
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("insert into company (idCompany, name) " +
                "values(@idCompany, @name);", conn))
                {
                    cmd.Parameters.AddWithValue("@idCompany", company.idCompany);
                    cmd.Parameters.AddWithValue("@name", company.name);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
