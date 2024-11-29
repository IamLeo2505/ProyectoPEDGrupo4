using ProyectoFinalEstructuraDatosGrupo4;

public static class ShakerSort
{
    public static void Ordenar(List<ProductoColasCirculares> productos, string criterio, bool ascendente)
    {
        int izquierda = 0;
        int derecha = productos.Count - 1;
        bool intercambiado;

        do
        {
            intercambiado = false;

            // Recorrido de izquierda a derecha
            for (int i = izquierda; i < derecha; i++)
            {
                if (Comparar(productos[i], productos[i + 1], criterio, ascendente))
                {
                    // Intercambiar elementos
                    var temp = productos[i];
                    productos[i] = productos[i + 1];
                    productos[i + 1] = temp;
                    intercambiado = true;
                }
            }
            derecha--;

            // Recorrido de derecha a izquierda
            for (int i = derecha; i > izquierda; i--)
            {
                if (Comparar(productos[i], productos[i - 1], criterio, ascendente))
                {
                    // Intercambiar elementos
                    var temp = productos[i];
                    productos[i] = productos[i - 1];
                    productos[i - 1] = temp;
                    intercambiado = true;
                }
            }
            izquierda++;

        } while (intercambiado); // Continúa hasta que no haya más intercambios
    }

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
