using DataAccess;
using Microsoft.Data.SqlClient;

namespace BusinessLogic
{
    public class Propietario
    {
        public int id { get; set; }
        public string? nombre { get; set; }
        public string? telefono { get; set; }

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

        public bool DoesThisOwnerExist()
        {
            try
            {
                string query = "select nombre, telefono from Propietario where nombre=@nombre and telefono=@telefono";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                SqlDataReader reader = dbAccess.GetConsult(cmd);

                if (reader.HasRows) return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        public int? GetID()
        {
            try
            {
                string query = "select id from Propietario where nombre=@nombre and telefono=@telefono";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);

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
 
    

    

