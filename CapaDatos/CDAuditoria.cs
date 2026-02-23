using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDAuditoria
    {
        public DataTable ListarAuditoria()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT a.id_auditoria,
                     u.nombre,
                     u.username,
                     a.fecha_login
              FROM auditoria_login a
              INNER JOIN usuarios u 
              ON a.id_usuario = u.id_usuario
              ORDER BY a.fecha_login DESC", cn))
                {
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
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
    }
}
