using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    internal class ProductoColasCirculares
    {
        public string Codigo { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }

        // Constructor para inicializar el producto
        public ProductoColasCirculares(
            string codigo, string producto, string descripcion,
            string categoria, DateTime fechaIngreso, DateTime fechaVencimiento,
            decimal precioCompra, decimal precioVenta
            )
        {
            Codigo = codigo;
            NombreProducto = producto;
            Descripcion = descripcion;
            Categoria = categoria;
            FechaIngreso = fechaIngreso;
            FechaVencimiento = fechaVencimiento;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
        }


        // Sobreescribir ToString para mostrar fácilmente el producto en la lista
        public override string ToString()
        {
            return $"Código: {Codigo}, Producto: {NombreProducto}, Categoría: {Categoria}, Precio Venta: ${PrecioVenta}";
        }
    }
}
