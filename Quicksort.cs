using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    internal class Quicksort
    {
        // Método principal que llama el algoritmo QuickSort
        public static void Ordenar(List<ProductoQuicksort> productos, string criterio, bool ascendente)
        {
            // Llamada recursiva a QuickSort con el criterio de ordenación y la dirección
            QuickSortRecursivo(productos, 0, productos.Count - 1, criterio, ascendente);
        }

        // Función recursiva de QuickSort
        private static void QuickSortRecursivo(List<ProductoQuicksort> productos, int izquierda, int derecha, string criterio, bool ascendente)
        {
            if (izquierda < derecha)
            {
                // Obtiene el índice del pivote
                int pivote = Particionar(productos, izquierda, derecha, criterio, ascendente);

                // Llama recursivamente para las sublistas izquierda y derecha
                QuickSortRecursivo(productos, izquierda, pivote - 1, criterio, ascendente);
                QuickSortRecursivo(productos, pivote + 1, derecha, criterio, ascendente);
            }
        }

        // Función de partición que divide el arreglo
        private static int Particionar(List<ProductoQuicksort> productos, int izquierda, int derecha, string criterio, bool ascendente)
        {
            ProductoQuicksort pivote = productos[derecha]; // Tomamos el último elemento como pivote
            int i = izquierda - 1; // Índice del menor elemento

            for (int j = izquierda; j < derecha; j++)
            {
                bool comparacion = Comparar(productos[j], pivote, criterio, ascendente);

                // Si el elemento actual es menor que el pivote (en orden ascendente o descendente)
                if (comparacion)
                {
                    i++;
                    // Intercambia los elementos
                    var temp = productos[i];
                    productos[i] = productos[j];
                    productos[j] = temp;
                }
            }

            // Intercambia el pivote con el elemento siguiente al último menor
            var temp2 = productos[i + 1];
            productos[i + 1] = productos[derecha];
            productos[derecha] = temp2;

            return i + 1;
        }

        // Función para comparar los elementos según el criterio y la dirección
        private static bool Comparar(ProductoQuicksort x, ProductoQuicksort y, string criterio, bool ascendente)
        {
            int resultado = 0;

            // Realiza la comparación en base al criterio seleccionado
            switch (criterio)
            {
                case "Codigo":
                    resultado = x.Codigo.CompareTo(y.Codigo);
                    break;
                case "Nombre":
                    resultado = x.NombreProducto.CompareTo(y.NombreProducto);
                    break;
                case "FechaIngreso":
                    resultado = x.FechaIngreso.CompareTo(y.FechaIngreso);
                    break;
                case "FechaVencimiento":
                    resultado = x.FechaVencimiento.CompareTo(y.FechaVencimiento);
                    break;
                case "PrecioCompra":
                    resultado = x.PrecioCompra.CompareTo(y.PrecioCompra);
                    break;
                case "PrecioVenta":
                    resultado = x.PrecioVenta.CompareTo(y.PrecioVenta);
                    break;
                default:
                    throw new ArgumentException("Criterio de ordenación no válido.");
            }

            // Si es ascendente, devolvemos el resultado directo
            // Si es descendente, invertimos la comparación
            return ascendente ? resultado < 0 : resultado > 0;
        }
    }

}
