using System;
using System.Collections.Generic;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public static class BubbleSort
    {
        public static void Ordenar(List<ProductoColasCirculares> productos, string criterio, bool ascendente)
        {
            // Obtener el tamaño de la lista
            int n = productos.Count;
            // Bucles anidados para realizar múltiples pasadas sobre la lista
            for (int i = 0; i < n - 1; i++)
            {
                // En cada pasada, los elementos más grandes "burbujean" hacia el final
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Switch para comparar según se elija el criterio
                    bool condicion;
                    switch (criterio)
                    {
                        case "Codigo":
                            condicion = string.Compare(productos[j].Codigo, productos[j + 1].Codigo, StringComparison.Ordinal) > 0;
                            break;
                        case "Nombre":
                            condicion = string.Compare(productos[j].NombreProducto, productos[j + 1].NombreProducto, StringComparison.Ordinal) > 0;
                            break;
                        case "FechaIngreso":
                            condicion = productos[j].FechaIngreso > productos[j + 1].FechaIngreso;
                            break;
                        case "FechaVencimiento":
                            condicion = productos[j].FechaVencimiento > productos[j + 1].FechaVencimiento;
                            break;
                        case "PrecioCompra":
                            condicion = productos[j].PrecioCompra > productos[j + 1].PrecioCompra;
                            break;
                        case "PrecioVenta":
                            condicion = productos[j].PrecioVenta > productos[j + 1].PrecioVenta;
                            break;
                        default:
                            throw new ArgumentException("Criterio inválido");
                    }

                    // Si se seleccionó un orden descendente, invertir la condición
                    if (!ascendente)
                    {
                        condicion = !condicion;
                    }

                    // Intercambiar si no cumple la condición
                    if (condicion)
                    {
                        var temp = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = temp;
                    }
                }
            }
        }
    }
}
