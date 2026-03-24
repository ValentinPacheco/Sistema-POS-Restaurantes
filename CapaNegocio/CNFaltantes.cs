using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Faltantes
    {
        CD_Faltantes obj = new CD_Faltantes();

        public void AgregarFaltante(int idProducto)
        {
            obj.InsertarFaltante(idProducto);
        }

        public DataTable MostrarFaltantes()
        {
            return obj.ListarFaltantes();
        }

        public void AtenderFaltante(int idFaltante)
        {
            obj.MarcarAtendido(idFaltante);
        }
    }
}