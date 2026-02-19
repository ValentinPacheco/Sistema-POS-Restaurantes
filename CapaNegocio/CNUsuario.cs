using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace CapaNegocio
{
    public class CNUsuario
    {
        private CDUsuario datos = new CDUsuario();

        public bool Login(string username, string password)
        {
            DataTable dt = datos.ObtenerUsuario(username);

            if (dt.Rows.Count == 0)
                return false;

            string hashBD = dt.Rows[0]["password_hash"].ToString();
            string hashIngresado = ObtenerSHA256(password);

            if (hashBD == hashIngresado)
            {
                CNSesion.IdUsuario = Convert.ToInt32(dt.Rows[0]["id_usuario"]);
                CNSesion.Nombre = dt.Rows[0]["nombre"].ToString();
                CNSesion.Rol = dt.Rows[0]["rol"].ToString();
                return true;
            }

            return false;
        }

        private string ObtenerSHA256(string texto)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder sb = new StringBuilder();

                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
    }
}
