using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class CDUsuarios
    {
        public int Login(string username, string password)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                conexion.Open();

                string query = @"SELECT id_usuario 
                         FROM usuarios 
                         WHERE username = @user 
                         AND password_hash = @pass 
                         AND activo = 1";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                object result = cmd.ExecuteScalar();

                if (result != null)
                    return Convert.ToInt32(result);
                else
                    return 0;
            }
        }
    }
}
