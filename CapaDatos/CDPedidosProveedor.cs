using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_PedidosProveedor
    {
        public void InsertarPedido(int idProveedor, int idProducto, int cantidad)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                string query = @"INSERT INTO pedidos_proveedor 
                                (id_proveedor, id_producto, cantidad) 
                                VALUES (@prov, @prod, @cant)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@prov", idProveedor);
                cmd.Parameters.AddWithValue("@prod", idProducto);
                cmd.Parameters.AddWithValue("@cant", cantidad);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable ListarPedidos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                string query = @"SELECT 
                            pp.id_pedido_prov,
                            pr.nombre AS Proveedor,
                            p.nombre AS Producto,
                            pp.cantidad,
                            pp.fecha
                         FROM pedidos_proveedor pp
                         INNER JOIN proveedores pr ON pp.id_proveedor = pr.id_proveedor
                         INNER JOIN productos p ON pp.id_producto = p.id_producto
                         ORDER BY pp.fecha DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }

            return dt;
        }
    }
}