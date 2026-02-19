using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaDatos
{
    public class CDUsuario
    {
            private Conexion Conn= new Conexion();

    public DataTable Login(string username)
    {
        SqlCommand cmd = new SqlCommand(
            "SELECT u.id_usuario, u.nombre, u.username, u.password_hash, r.nombre AS rol " +
            "FROM usuarios u " +
            "INNER JOIN roles r ON u.id_rol = r.id_rol " +
            "WHERE u.username = @username AND u.activo = 1",
            Conn.AbrirConexion());

        cmd.Parameters.AddWithValue("@username", username);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        Conn.CerrarConexion();
        return dt;
    }

        public DataTable ObtenerUsuario(string username)
        {
            throw new NotImplementedException();
        }
    }
}
