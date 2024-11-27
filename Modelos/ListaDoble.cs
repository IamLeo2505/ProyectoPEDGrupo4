using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4.Modelos
{
    public class ListaDoble
    {
        private NodoDoble cabeza;
        private NodoDoble cola;

        public ListaDoble()
        {
            cabeza = null;
            cola = null;
        }

        // Método para insertar al final
        public void InsertarAlFinal(NodoDoble nuevoNodo)
        {
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                cola.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = cola;
                cola = nuevoNodo;
            }
        }

        // Método para eliminar un nodo por código
        public void Eliminar(string codigo)
        {
            NodoDoble actual = cabeza;

            while (actual != null)
            {
                if (actual.Codigo == codigo)
                {
                    if (actual.Anterior != null)
                        actual.Anterior.Siguiente = actual.Siguiente;
                    else
                        cabeza = actual.Siguiente;

                    if (actual.Siguiente != null)
                        actual.Siguiente.Anterior = actual.Anterior;
                    else
                        cola = actual.Anterior;

                    return; // Nodo eliminado
                }
                actual = actual.Siguiente;
            }
        }

        // Método para recorrer la lista y devolver todos los nodos
        public List<NodoDoble> ObtenerTodos()
        {
            List<NodoDoble> nodos = new List<NodoDoble>();
            NodoDoble actual = cabeza;

            while (actual != null)
            {
                nodos.Add(actual);
                actual = actual.Siguiente;
            }

            return nodos;
        }

    }

}
