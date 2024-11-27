using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    internal class Quicksort
    {
        public static void Ordenar(List<ProductoColasCirculares> productos, string criterio, bool ascendente)
        {
            QuickSortRecursivo(productos, 0, productos.Count - 1, criterio, ascendente);
        }

        private static void QuickSortRecursivo(List<ProductoColasCirculares> productos, int izquierda, int derecha, string criterio, bool ascendente)
        {
            if (izquierda < derecha)
            {
                int pivote = Particionar(productos, izquierda, derecha, criterio, ascendente);

                QuickSortRecursivo(productos, izquierda, pivote - 1, criterio, ascendente);
                QuickSortRecursivo(productos, pivote + 1, derecha, criterio, ascendente);
            }
        }

        private static int Particionar(List<ProductoColasCirculares> productos, int izquierda, int derecha, string criterio, bool ascendente)
        {
            ProductoColasCirculares pivote = productos[derecha];
            int i = izquierda - 1;

            for (int j = izquierda; j < derecha; j++)
            {
                bool comparacion = Comparar(productos[j], pivote, criterio, ascendente);

                if (comparacion)
                {
                    i++;
                    var temp = productos[i];
                    productos[i] = productos[j];
                    productos[j] = temp;
                }
            }

            var temp2 = productos[i + 1];
            productos[i + 1] = productos[derecha];
            productos[derecha] = temp2;

            return i + 1;
        }

        private static bool Comparar(ProductoColasCirculares x, ProductoColasCirculares y, string criterio, bool ascendente)
        {
            int resultado = 0;

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

            return ascendente ? resultado < 0 : resultado > 0;
        }
    }

}
