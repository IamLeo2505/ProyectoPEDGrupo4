using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public class Nodo
    {
        public ProductoColasCirculares Producto { get; set; } // El producto almacenado en el nodo
        public Nodo Siguiente { get; set; } // Referencia al siguiente nodo

        // Constructor
        public Nodo(ProductoColasCirculares producto)
        {
            Producto = producto;
            Siguiente = null;
        }
    }

}
