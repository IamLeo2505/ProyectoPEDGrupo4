using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4
{
        public class ListaDobleEnlazada
        {
            private NodoProducto head;
            private NodoProducto tail;

            public ListaDobleEnlazada()
            {
                head = null;
                tail = null;
            }

            // Método para agregar un nuevo producto
            public void AgregarProducto(Producto producto)
            {
                NodoProducto nuevoNodo = new NodoProducto(producto);
                if (head == null)
                {
                    head = nuevoNodo;
                    tail = nuevoNodo;
                }
                else
                {
                    tail.Next = nuevoNodo;
                    nuevoNodo.Prev = tail;
                    tail = nuevoNodo;
                }
            }

            // Método para eliminar un producto por código
            public bool EliminarProducto(string codigo)
            {
                NodoProducto actual = head;
                while (actual != null)
                {
                    if (actual.Producto.Codigo == codigo)
                    {
                        // Caso cuando el nodo es la cabeza
                        if (actual == head)
                        {
                            head = actual.Next;
                            if (head != null) head.Prev = null;
                        }
                        // Caso cuando el nodo es la cola
                        else if (actual == tail)
                        {
                            tail = actual.Prev;
                            if (tail != null) tail.Next = null;
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
                NodoProducto actual = head;
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
                NodoProducto actual = head;

                while (actual != null)
                {
                    listaProductos.Add(actual.Producto);
                    actual = actual.Next;
                }

                return listaProductos;
            }
        }
}
