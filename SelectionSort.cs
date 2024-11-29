using System;
using System.Collections.Generic;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public static class SelectionSort
    {
        public static void Ordenar(List<ProductoColasCirculares> productos, string criterio, bool ascendente)
        {
            int n = productos.Count;

            // Se recorre la lista de productos
            for (int i = 0; i < n - 1; i++)
            {
                // Aqui se busca el índice según el criterio
                int indexMinMax = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Comparar(productos[j], productos[indexMinMax], criterio, ascendente))
                    {
                        indexMinMax = j;
                    }
                }

                // Intercambiar si se encuentra un valor más pequeño (o más grande)
                if (indexMinMax != i)
                {
                    var temp = productos[i];
                    productos[i] = productos[indexMinMax];
                    productos[indexMinMax] = temp;
                }
            }
        }

        // este método compara los productos según el criterio y el orden
        private static bool Comparar(ProductoColasCirculares a, ProductoColasCirculares b, string criterio, bool ascendente)
        {
            int resultado;

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

            return ascendente ? resultado < 0 : resultado > 0;
        }

    }
}
