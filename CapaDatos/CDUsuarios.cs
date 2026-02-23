using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void RegistrarLogin(int idUsuario)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                conexion.Open();

                string query = "INSERT INTO auditoria_login (id_usuario) VALUES (@idUsuario)";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarAuditoria()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                conexion.Open();

                string query = @"SELECT u.nombre, u.username, a.fecha_login
                         FROM auditoria_login a
                         INNER JOIN usuarios u ON a.id_usuario = u.id_usuario
                         ORDER BY a.fecha_login DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}