using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCategorias
    {
        public int id_categoria { get; set; }
        public string nombre { get; set; }

        public string Buscar { get; set; }
    }
}
