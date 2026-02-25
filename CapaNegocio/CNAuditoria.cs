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
        CDAuditoria objDatos = new CDAuditoria(); 

        CDAuditoria datos = new CDAuditoria();

        public DataTable MostrarAuditoria()
        {
            return datos.ListarAuditoria();
        }

        public DataTable ListarAuditoria()
        {
            return objDatos.ListarAuditoria();
        }
        public void RegistrarLogin(int idUsuario)
        {
            objDatos.RegistrarLogin(idUsuario);
        }
        public void RegistrarLogout(int idAuditoria)
        {
            objDatos.RegistrarLogout(idAuditoria);
        }
    }
}
