using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDProductos
    {
        // 🔹 LISTAR
        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                using (SqlCommand cmd = new SqlCommand("splistar_productos", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                }
            }

            return tabla;
        }

        // 🔹 BUSCAR
        public DataTable Buscar(string nombre)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                using (SqlCommand cmd = new SqlCommand("spbuscar_productos_nombre", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre);

                    cn.Open();
                    SqlDataReader leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                }
            }

            return tabla;
        }

        // 🔹 INSERTAR
        public void Insertar(string nombre, decimal precio, int id_categoria, bool activo)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                using (SqlCommand cmd = new SqlCommand("spguardar_producto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                    cmd.Parameters.AddWithValue("@activo", activo);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 🔹 EDITAR
        public void Editar(int id_producto, string nombre, decimal precio, int id_categoria, bool activo)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                using (SqlCommand cmd = new SqlCommand("speditar_producto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_producto", id_producto);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                    cmd.Parameters.AddWithValue("@activo", activo);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 🔹 ELIMINAR (lógico)
        public void Eliminar(int id_producto)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Conn))
            {
                using (SqlCommand cmd = new SqlCommand("speliminar_producto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}