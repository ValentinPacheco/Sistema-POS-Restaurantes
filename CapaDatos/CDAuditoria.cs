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
                    "SELECT id_auditoria, tipo_cambio, fecha_cambio, datos_anteriores, datos_nuevos FROM dbo.auditoriacategorias ORDER BY fecha_cambio DESC", cn))
                {
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
