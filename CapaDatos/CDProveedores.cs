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
    }
}
