using DataAccess;
using Microsoft.Data.SqlClient;

namespace BusinessLogic
{
    public class Propietario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }

        public void Add()
        {
            try
            {
                string query = "insert into Propietario (nombre, telefono) values (@nombre, @telefono)";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                dbAccess.ExecuteQuery(cmd);

                return;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
 
    

    

