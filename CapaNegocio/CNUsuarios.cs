using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class CNUsuarios
    {
        CDUsuarios objDatos = new CDUsuarios();

        public int Login(string username, string password)
        {
            return objDatos.Login(username, password);
        }
    }
}
