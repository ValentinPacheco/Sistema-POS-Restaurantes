using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDVenta
    {
        public DataTable ListarProductos()
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_producto, nombre, precio FROM productos WHERE activo = 1", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public decimal ObtenerPrecio(int idProducto)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT precio FROM productos WHERE id_producto = @id", con);

                cmd.Parameters.AddWithValue("@id", idProducto);

                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
        public int InsertarPedido(int idUsuario, int idMesa)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insertar_pedido", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                cmd.Parameters.AddWithValue("@id_mesa", idMesa);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void InsertarDetalle(int idPedido, int idProducto, int cantidad, decimal precio)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insertar_detalle", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_pedido", idPedido);
                cmd.Parameters.AddWithValue("@id_producto", idProducto);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@precio", precio);

                cmd.ExecuteNonQuery();
            }
        }

        public void ConfirmarPedido(int idPedido)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_confirmar_pedido", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_pedido", idPedido);

                cmd.ExecuteNonQuery();
            }
        }
    }
}