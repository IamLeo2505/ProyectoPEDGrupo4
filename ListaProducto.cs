using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public class ListaProducto
    {
        private Nodo cabeza; // Nodo cabeza de la lista enlazada

        public ListaProducto()
        {
            cabeza = null; // Inicializamos cabeza como null
        }

        // Método para agregar un producto al final
        public void AgregarAlFinal(ProductoColasCirculares producto)
        {
            Nodo nuevoNodo = new Nodo(producto);

            if (cabeza == null) // Si la lista está vacía, el nuevo nodo será la cabeza
            {
                cabeza = nuevoNodo;
            }
            else // Si la lista no está vacía, se añade al final
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        // Método para agregar un producto al inicio
        public void AgregarAlInicio(ProductoColasCirculares producto)
        {
            Nodo nuevoNodo = new Nodo(producto);
            nuevoNodo.Siguiente = cabeza; // El siguiente del nuevo nodo apunta a la cabeza
            cabeza = nuevoNodo; // La cabeza ahora es el nuevo nodo
        }

        // Método para eliminar un producto por código
        public void EliminarProducto(string codigo)
        {
            if (cabeza == null) return;

            // Si el primer nodo tiene el código que buscamos
            if (cabeza.Producto.Codigo == codigo)
            {
                cabeza = cabeza.Siguiente; // Movemos la cabeza al siguiente nodo
                return;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null && actual.Siguiente.Producto.Codigo != codigo)
            {
                actual = actual.Siguiente; // Avanzamos por la lista
            }

            // Si encontramos el nodo, lo eliminamos
            if (actual.Siguiente != null)
            {
                actual.Siguiente = actual.Siguiente.Siguiente; // Borramos el nodo
            }
        }

        // Método para obtener todos los productos en la lista
        public List<ProductoColasCirculares> ObtenerProductos()
        {
            List<ProductoColasCirculares> listaProductos = new List<ProductoColasCirculares>();
            Nodo actual = cabeza;

            while (actual != null)
            {
                listaProductos.Add(actual.Producto);
                actual = actual.Siguiente; // Avanzamos al siguiente nodo
            }

            return listaProductos;
        }

        // Método para buscar productos por un criterio
        public List<ProductoColasCirculares> BuscarProducto(string criterio, string busqueda)
        {
            List<ProductoColasCirculares> resultados = new List<ProductoColasCirculares>();
            Nodo actual = cabeza;

            while (actual != null)
            {
                bool coincide = false;
                switch (criterio)
                {
                    case "Codigo":
                        coincide = actual.Producto.Codigo.Contains(busqueda);
                        break;
                    case "Nombre":
                        coincide = actual.Producto.NombreProducto.Contains(busqueda);
                        break;
                    case "FechaIngreso":
                        coincide = actual.Producto.FechaIngreso.ToString().Contains(busqueda);
                        break;
                    case "FechaVencimiento":
                        coincide = actual.Producto.FechaVencimiento.ToString().Contains(busqueda);
                        break;
                    case "PrecioCompra":
                        coincide = actual.Producto.PrecioCompra.ToString().Contains(busqueda);
                        break;
                    case "PrecioVenta":
                        coincide = actual.Producto.PrecioVenta.ToString().Contains(busqueda);
                        break;
                }

                if (coincide)
                {
                    resultados.Add(actual.Producto);
                }

                actual = actual.Siguiente; // Avanzamos al siguiente nodo
            }

            return resultados;
        }
    }

}
