using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.Data.SqlClient;

namespace BusinessLogic
{
    public class Oficina
    {
        public int id { get; set; }
        public string? nombre { get; set; }

        public int? GetID()
        {
            try
            {
                string query = "select id from Oficina where nombre=@nombre";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@nombre", nombre);

                SqlDataReader reader = dbAccess.GetConsult(cmd);

                if (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    dbAccess.connection.Close();
                    return ID;
                }
                else
                {
                    dbAccess.connection.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
