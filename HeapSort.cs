using System;
using System.Collections.Generic;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public static class HeapSort
    {
        public static void Ordenar(List<ProductoColasCirculares> productos, string criterio, bool ascendente)
        {
            int n = productos.Count;

            // Construir el heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                AplicarHeap(productos, n, i, criterio, ascendente);
            }

            // Extraer elementos del heap uno por uno
            for (int i = n - 1; i > 0; i--)
            {
                // Intercambiar la raíz actual (el mayor o menor) con el último elemento
                (productos[0], productos[i]) = (productos[i], productos[0]);

                // Restaurar la propiedad del heap en el heap reducido
                AplicarHeap(productos, i, 0, criterio, ascendente);
            }
        }

        private static void AplicarHeap(List<ProductoColasCirculares> productos, int n, int i, string criterio, bool ascendente)
        {
            int extremo = i;       // Inicialmente, el nodo extremo (mayor o menor)
            int izquierda = 2 * i + 1; // Hijo izquierdo
            int derecha = 2 * i + 2;   // Hijo derecho

            // Comparar con el hijo izquierdo
            if (izquierda < n && Comparar(productos[izquierda], productos[extremo], criterio, ascendente))
            {
                extremo = izquierda;
            }

            // Comparar con el hijo derecho
            if (derecha < n && Comparar(productos[derecha], productos[extremo], criterio, ascendente))
            {
                extremo = derecha;
            }

            // Si el extremo no es la raíz actual, intercambiar y continuar aplicando heap
            if (extremo != i)
            {
                (productos[i], productos[extremo]) = (productos[extremo], productos[i]);

                // Aplicar heap en el subárbol afectado
                AplicarHeap(productos, n, extremo, criterio, ascendente);
            }
        }
        private static bool Comparar(ProductoColasCirculares a, ProductoColasCirculares b, string criterio, bool ascendente)
        {
            int resultado;

            // Comparar según el criterio seleccionado
            switch (criterio)
            {
                case "Codigo":
                    resultado = string.Compare(a.Codigo, b.Codigo, StringComparison.Ordinal);
                    break;
                case "Nombre":
                    resultado = string.Compare(a.NombreProducto, b.NombreProducto, StringComparison.Ordinal);
                    break;
                case "FechaIngreso":
                    resultado = a.FechaIngreso.CompareTo(b.FechaIngreso);
                    break;
                case "FechaVencimiento":
                    resultado = a.FechaVencimiento.CompareTo(b.FechaVencimiento);
                    break;
                case "PrecioCompra":
                    resultado = a.PrecioCompra.CompareTo(b.PrecioCompra);
                    break;
                case "PrecioVenta":
                    resultado = a.PrecioVenta.CompareTo(b.PrecioVenta);
                    break;
                default:
                    throw new ArgumentException("Criterio inválido");
            }

            if (ascendente)
            {
                return resultado > 0;
            }
            else
            {
                return resultado < 0;
            }
        }

    }
}
