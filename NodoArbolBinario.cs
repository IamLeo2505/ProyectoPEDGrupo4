using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    internal class NodoArbolBinario
    {
        public ProductoColasCirculares Producto { get; set; }
        public NodoArbolBinario Izquierdo { get; set; }
        public NodoArbolBinario Derecho { get; set; }

        // Constructor
        public NodoArbolBinario(ProductoColasCirculares producto)
        {
            Producto = producto;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
