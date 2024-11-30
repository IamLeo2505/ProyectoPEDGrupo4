using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalEstructuraDatosGrupo4;

namespace ProyectoFinalEstructuraDatosGrupo4
{
        public class ListaDobleEnlazada
        {
            private NodoProducto cabeza;
            private NodoProducto cola;

            public ListaDobleEnlazada()
            {
                cabeza = null;
                cola = null;
            }

            public void InsertarAlInicio(NodoProducto nuevoNodo)
            {
                if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
                else
                {
                nuevoNodo.Next = cabeza;
                cabeza.Prev = nuevoNodo;
                cabeza = nuevoNodo;
                }
            }


        public List<NodoProducto> ObtenerTodosInverso()
        {
            List<NodoProducto> nodos = new List<NodoProducto>();
            NodoProducto actual = cola;

            while (actual != null)
            {
                nodos.Add(actual);
                actual = actual.Prev;
            }

            return nodos;
        }

        public void InsertarEnPosicion(NodoProducto nuevoNodo, int posicion)
        {
            if (posicion < 0) throw new ArgumentOutOfRangeException("La posición no puede ser negativa.");

            if (cabeza == null || posicion == 0) 
            {
                InsertarAlInicio(nuevoNodo);
                return;
            }

            NodoProducto actual = cabeza;
            int indice = 0;

            while (actual != null && indice < posicion - 1)
            {
                actual = actual.Next;
                indice++;
            }

            if (actual == null) throw new ArgumentOutOfRangeException("La posición está fuera del rango.");

            nuevoNodo.Next = actual.Next;
            nuevoNodo.Prev = actual;

            if (actual.Next != null)
                actual.Next.Prev = nuevoNodo;

            actual.Next = nuevoNodo;

            if (nuevoNodo.Next == null)
                cola = nuevoNodo; // Si es el último nodo, actualiza la cola
        }

       

            // Método para eliminar un producto por código
            public bool EliminarProducto(string codigo)
            {
                NodoProducto actual = cabeza;
                while (actual != null)
                {
                    if (actual.Producto.Codigo == codigo)
                    {
                        // Caso cuando el nodo es la cabeza
                        if (actual == cabeza)
                        {
                            cabeza = actual.Next;
                            if (cabeza != null) cabeza.Prev = null;
                        }
                        // Caso cuando el nodo es la cola
                        else if (actual == cola)
                        {
                            cola = actual.Prev;
                            if (cola != null) cola.Next = null;
                        }
                        // Caso intermedio
                        else
                        {
                            actual.Prev.Next = actual.Next;
                            actual.Next.Prev = actual.Prev;
                        }

                        return true;
                    }
                    actual = actual.Next;
                }
                return false;
            }



            // Método para editar un producto por código
            public bool EditarProducto(string codigo, Producto productoEditado)
            {
                NodoProducto actual = cabeza;
                while (actual != null)
                {
                    if (actual.Producto.Codigo == codigo)
                    {
                        actual.Producto = productoEditado;
                        return true;
                    }
                    actual = actual.Next;
                }
                return false;
            }

            // Método para obtener todos los productos (para mostrar en el DataGridView)
            public List<Producto> ObtenerProductos()
            {
                List<Producto> listaProductos = new List<Producto>();
                NodoProducto actual = cabeza;

                while (actual != null)
                {
                    listaProductos.Add(actual.Producto);
                    actual = actual.Next;
                }

                return listaProductos;
            }

        internal static void InsertarEnPosicion(Producto nuevoProducto, int posicion)
        {
            throw new NotImplementedException();
        }

        internal static void InsertarAlInicio(Producto nuevoProducto)
        {
            throw new NotImplementedException();
        }
    }
}
