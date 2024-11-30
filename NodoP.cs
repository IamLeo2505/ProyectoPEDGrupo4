using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalEstructuraDatosGrupo4;


namespace ProyectoFinalEstructuraDatosGrupo4
{
    public class NodoProducto
    {
        public Producto Producto { get; set; }
        public NodoProducto Next { get; set; }
        public NodoProducto Prev { get; set; }

        // Constructor
        public NodoProducto(Producto producto)
        {
            Producto = producto;
            Next = null;
            Prev = null;
        }
    }

}
