using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNCategorias
    {
        public static DataTable ListarCategorias()
        { 
            CDCategorias Datos = new CDCategorias();
            return Datos.Listar();
        }

        public static string Guardar(String nombre)
        { 
            CDCategorias Datos = new CDCategorias();
            Datos.nombre = nombre;
            return Datos.Guardar(Datos);
        }

        public static string Editar(int id_categoria, string nombre)
        { 
            CDCategorias Datos = new CDCategorias();
            Datos.id_categoria = id_categoria;
            Datos.nombre = nombre;
            return Datos.Editar(Datos);
        }

        public static string Eliminar(int id_categoria)
        { 
            CDCategorias Datos = new CDCategorias();
            Datos.id_categoria = id_categoria;
            return Datos.Eliminar(Datos);
        }

        public static DataTable BuscarNombre(string textoBuscar)
        { 
            CDCategorias Datos = new CDCategorias();
            Datos.Buscar = textoBuscar;
            return Datos.BuscarNombre(Datos);
        }


    }
}
