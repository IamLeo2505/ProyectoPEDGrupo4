using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public class GrafoFloyd
    {
        private List<ProductoColasCirculares> nodos;
        private Dictionary<string, int> indices;
        private int[,] matrizAdyacencia;
        private const int INFINITO = int.MaxValue;

        public GrafoFloyd()
        {
            nodos = new List<ProductoColasCirculares>();
            indices = new Dictionary<string, int>();
        }

        public void AgregarNodo(ProductoColasCirculares producto)
        {
            if (indices.ContainsKey(producto.Codigo))
            {
                throw new Exception("El producto ya existe en el grafo.");
            }

            nodos.Add(producto);
            indices[producto.Codigo] = nodos.Count - 1;

            // Redimensionar la matriz de adyacencia
            int nuevoTamano = nodos.Count;
            var nuevaMatriz = new int[nuevoTamano, nuevoTamano];

            // Copiar valores de la matriz existente
            for (int i = 0; i < nuevoTamano - 1; i++)
            {
                for (int j = 0; j < nuevoTamano - 1; j++)
                {
                    nuevaMatriz[i, j] = matrizAdyacencia?[i, j] ?? INFINITO;
                }
            }

            // Inicializar nuevas conexiones como INFINITO
            for (int i = 0; i < nuevoTamano; i++)
            {
                nuevaMatriz[i, nuevoTamano - 1] = INFINITO;
                nuevaMatriz[nuevoTamano - 1, i] = INFINITO;
            }

            matrizAdyacencia = nuevaMatriz;
        }

        public bool EliminarNodo(string codigo)
        {
            if (!indices.ContainsKey(codigo))
            {
                return false;
            }

            int index = indices[codigo];
            indices.Remove(codigo);
            nodos.RemoveAt(index);

            // Actualizar índices y matriz de adyacencia
            for (int i = index; i < nodos.Count; i++)
            {
                indices[nodos[i].Codigo] = i;
            }

            int nuevoTamano = nodos.Count;
            var nuevaMatriz = new int[nuevoTamano, nuevoTamano];

            // Copiar valores excluyendo el índice eliminado
            for (int i = 0, ni = 0; i < matrizAdyacencia.GetLength(0); i++)
            {
                if (i == index) continue;
                for (int j = 0, nj = 0; j < matrizAdyacencia.GetLength(1); j++)
                {
                    if (j == index) continue;
                    nuevaMatriz[ni, nj] = matrizAdyacencia[i, j];
                    nj++;
                }
                ni++;
            }

            matrizAdyacencia = nuevaMatriz;
            return true;
        }

        public List<ProductoColasCirculares> ObtenerTodosLosNodos()
        {
            return new List<ProductoColasCirculares>(nodos);
        }

        public List<ProductoColasCirculares> BuscarProducto(string criterio, string busqueda)
        {
            List<ProductoColasCirculares> resultados = new List<ProductoColasCirculares>();

            foreach (var producto in ObtenerTodosLosNodos()) // Obtienes todos los productos del grafo
            {
                switch (criterio)
                {
                    case "Codigo":
                        if (producto.Codigo.Contains(busqueda, StringComparison.OrdinalIgnoreCase))
                            resultados.Add(producto);
                        break;
                    case "Nombre":
                        if (producto.NombreProducto.Contains(busqueda, StringComparison.OrdinalIgnoreCase))
                            resultados.Add(producto);
                        break;
                    case "FechaIngreso":
                        if (producto.FechaIngreso.ToShortDateString().Contains(busqueda))
                            resultados.Add(producto);
                        break;
                    case "FechaVencimiento":
                        if (producto.FechaVencimiento.ToShortDateString().Contains(busqueda))
                            resultados.Add(producto);
                        break;
                    case "PrecioCompra":
                        if (producto.PrecioCompra.ToString().Contains(busqueda))
                            resultados.Add(producto);
                        break;
                    case "PrecioVenta":
                        if (producto.PrecioVenta.ToString().Contains(busqueda))
                            resultados.Add(producto);
                        break;
                    default:
                        break;
                }
            }

            return resultados;
        }

        public List<ProductoColasCirculares> OrdenarProductos(string criterio, bool ascendente)
        {
            List<ProductoColasCirculares> productosOrdenados = ObtenerTodosLosNodos();

            switch (criterio)
            {
                case "Codigo":
                    productosOrdenados = ascendente
                        ? productosOrdenados.OrderBy(p => p.Codigo).ToList()
                        : productosOrdenados.OrderByDescending(p => p.Codigo).ToList();
                    break;

                case "Nombre":
                    productosOrdenados = ascendente
                        ? productosOrdenados.OrderBy(p => p.NombreProducto).ToList()
                        : productosOrdenados.OrderByDescending(p => p.NombreProducto).ToList();
                    break;

                case "FechaIngreso":
                    productosOrdenados = ascendente
                        ? productosOrdenados.OrderBy(p => p.FechaIngreso).ToList()
                        : productosOrdenados.OrderByDescending(p => p.FechaIngreso).ToList();
                    break;

                case "FechaVencimiento":
                    productosOrdenados = ascendente
                        ? productosOrdenados.OrderBy(p => p.FechaVencimiento).ToList()
                        : productosOrdenados.OrderByDescending(p => p.FechaVencimiento).ToList();
                    break;

                case "PrecioCompra":
                    productosOrdenados = ascendente
                        ? productosOrdenados.OrderBy(p => p.PrecioCompra).ToList()
                        : productosOrdenados.OrderByDescending(p => p.PrecioCompra).ToList();
                    break;

                case "PrecioVenta":
                    productosOrdenados = ascendente
                        ? productosOrdenados.OrderBy(p => p.PrecioVenta).ToList()
                        : productosOrdenados.OrderByDescending(p => p.PrecioVenta).ToList();
                    break;
            }

            return productosOrdenados;
        }


        public int[,] ObtenerMatrizAdyacencia()
        {
            return matrizAdyacencia;
        }
    }

}
