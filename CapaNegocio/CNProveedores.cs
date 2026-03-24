using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedores
    {
        CD_Proveedores obj = new CD_Proveedores();

        public DataTable MostrarProveedores()
        {
            return obj.ListarProveedores();
        }
    }
}