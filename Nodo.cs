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
        public Nodo(string text, ProductoColasCirculares producto)
        {
            Producto = producto;
            Siguiente = null;
        }

        public Nodo(string text1, string text2, string text3, string text4, DateTime value1, DateTime value2, decimal v1, decimal v2)
        {
        }

        public Nodo(ProductoColasCirculares producto)
        {
            Producto = producto;
        }
    }

}
