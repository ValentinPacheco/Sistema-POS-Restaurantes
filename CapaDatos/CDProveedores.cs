using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Proveedores
    {
        public DataTable ListarProveedores()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                string query = @"SELECT id_proveedor, nombre, telefono
                                 FROM proveedores
                                 WHERE activo = 1";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }

            return dt;
        }
        public void InsertarProveedor(string nombre, string telefono)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                string query = "INSERT INTO proveedores (nombre, telefono) VALUES (@n, @t)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@n", nombre);
                cmd.Parameters.AddWithValue("@t", telefono);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarProveedor(int id, string nombre, string telefono)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                string query = "UPDATE proveedores SET nombre=@n, telefono=@t WHERE id_proveedor=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@n", nombre);
                cmd.Parameters.AddWithValue("@t", telefono);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProveedor(int id)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                string query = "UPDATE proveedores SET activo = 0 WHERE id_proveedor=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable BuscarProveedor(string texto)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                string query = @"SELECT id_proveedor, nombre, telefono
                         FROM proveedores
                         WHERE activo = 1 AND nombre LIKE @texto";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
    }
}
