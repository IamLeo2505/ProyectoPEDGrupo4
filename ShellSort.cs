using System;
using System.Collections.Generic;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public static class ShellSort
    {
        public static void Ordenar(List<ProductoColasCirculares> productos, string criterio, bool ascendente)
        {
            // Selección del criterio de ordenación
            Func<ProductoColasCirculares, IComparable> obtenerValor;
            switch (criterio)
            {
                case "Codigo":
                    obtenerValor = p => p.Codigo;
                    break;
                case "Nombre":
                    obtenerValor = p => p.NombreProducto;
                    break;
                case "FechaIngreso":
                    obtenerValor = p => p.FechaIngreso;
                    break;
                case "FechaVencimiento":
                    obtenerValor = p => p.FechaVencimiento;
                    break;
                case "PrecioCompra":
                    obtenerValor = p => p.PrecioCompra;
                    break;
                case "PrecioVenta":
                    obtenerValor = p => p.PrecioVenta;
                    break;
                default:
                    throw new ArgumentException("Criterio no válido");
            }

            // Algoritmo de ShellSort
            int n = productos.Count;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    var temp = productos[i];
                    int j = i;
                    while (j >= gap && (ascendente ?
                        obtenerValor(productos[j - gap]).CompareTo(obtenerValor(temp)) > 0 :
                        obtenerValor(productos[j - gap]).CompareTo(obtenerValor(temp)) < 0))
                    {
                        productos[j] = productos[j - gap];
                        j -= gap;
                    }
                    productos[j] = temp;
                }
                gap /= 2;
            }
        }
    }
}
