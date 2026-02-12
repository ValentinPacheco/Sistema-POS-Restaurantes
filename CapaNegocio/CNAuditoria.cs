using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CNAuditoria
    {
       CDAuditoria datos = new CDAuditoria();

        public DataTable MostrarAuditoria()
        {
            return datos.ListarAuditoria();
        }
    }
}
