using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    internal class ArbolBinario
    {
        public NodoArbolBinario Raiz { get; private set; }
        public void Insertar(ProductoColasCirculares producto)
        {
            NodoArbolBinario nuevoNodo = new NodoArbolBinario(producto);

            if (Raiz == null)
            {
                Raiz = nuevoNodo;
            }
            else
            {
                InsertarRecursivo(Raiz, nuevoNodo);
            }
        }

        private void InsertarRecursivo(NodoArbolBinario actual, NodoArbolBinario nuevo)
        {
            if (string.Compare(nuevo.Producto.Codigo, actual.Producto.Codigo) < 0)
            {
                if (actual.Izquierdo == null)
                {
                    actual.Izquierdo = nuevo;
                }
                else
                {
                    InsertarRecursivo(actual.Izquierdo, nuevo);
                }
            }
            else
            {
                if (actual.Derecho == null)
                {
                    actual.Derecho = nuevo;
                }
                else
                {
                    InsertarRecursivo(actual.Derecho, nuevo);
                }
            }
        }

        public ProductoColasCirculares Buscar(string codigo)
        {
            return BuscarRecursivo(Raiz, codigo);
        }

        private ProductoColasCirculares BuscarRecursivo(NodoArbolBinario actual, string codigo)
        {
            if (actual == null) return null;
            if (actual.Producto.Codigo == codigo) return actual.Producto;

            if (string.Compare(codigo, actual.Producto.Codigo) < 0)
            {
                return BuscarRecursivo(actual.Izquierdo, codigo);
            }
            else
            {
                return BuscarRecursivo(actual.Derecho, codigo);
            }
        }

        public void RecorrerEnOrden(NodoArbolBinario nodo, Action<ProductoColasCirculares> accion)
        {
            if (nodo != null)
            {
                RecorrerEnOrden(nodo.Izquierdo, accion);
                accion(nodo.Producto);
                RecorrerEnOrden(nodo.Derecho, accion);
            }
        }

        public bool Eliminar(string codigo)
        {
            Raiz = EliminarRecursivo(Raiz, codigo);
            return Raiz != null;
        }

        private NodoArbolBinario EliminarRecursivo(NodoArbolBinario nodo, string codigo)
        {
            if (nodo == null) return null;

            // Si el código es menor que el código del nodo actual, buscar en el subárbol izquierdo
            if (string.Compare(codigo, nodo.Producto.Codigo) < 0)
            {
                nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, codigo);
            }
            // Si el código es mayor, buscar en el subárbol derecho
            else if (string.Compare(codigo, nodo.Producto.Codigo) > 0)
            {
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, codigo);
            }
            // Si el código es igual, es el nodo a eliminar
            else
            {
                // Caso 1: El nodo tiene solo un hijo o ninguno
                if (nodo.Izquierdo == null) return nodo.Derecho;
                if (nodo.Derecho == null) return nodo.Izquierdo;

                // Caso 2: El nodo tiene dos hijos, encontrar el sucesor
                NodoArbolBinario sucesor = ObtenerSucesor(nodo.Derecho);
                nodo.Producto = sucesor.Producto; // Reemplazar el producto con el sucesor
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, sucesor.Producto.Codigo); // Eliminar el sucesor
            }

            return nodo;
        }

        private NodoArbolBinario ObtenerSucesor(NodoArbolBinario nodo)
        {
            NodoArbolBinario actual = nodo;
            while (actual.Izquierdo != null)
            {
                actual = actual.Izquierdo;
            }
            return actual;
        }


    }
}
