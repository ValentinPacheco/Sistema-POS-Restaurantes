using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Faltantes
    {
        public void InsertarFaltante(int idProducto)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                string query = "INSERT INTO productos_faltantes (id_producto) VALUES (@id_producto)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id_producto", idProducto);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarFaltantes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                string query = @"SELECT pf.id_faltante, p.nombre, pf.fecha
                                 FROM productos_faltantes pf
                                 INNER JOIN productos p ON pf.id_producto = p.id_producto
                                 WHERE pf.atendido = 0";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }

            return dt;
        }

        public void MarcarAtendido(int idFaltante)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                string query = "UPDATE productos_faltantes SET atendido = 1 WHERE id_faltante = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idFaltante);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
