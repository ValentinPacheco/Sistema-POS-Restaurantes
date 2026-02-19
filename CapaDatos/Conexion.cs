using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private SqlConnection Conn = new SqlConnection(
            "Data Source=ValeLaptop; Initial Catalog=DBPos; Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            return Conn;
        }

        public void CerrarConexion()
        {
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
        }
    }
}