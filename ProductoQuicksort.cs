using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    internal class ProductoQuicksort
    {
        //////////////////Orden Cambiado
        public string Codigo { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }

        // Constructor para crear un ProductoColasCirculares con todos los parámetros
        public ProductoQuicksort(
            string codigo, string nombreProducto, string descripcion, string categoria,
            DateTime fechaIngreso, DateTime fechaVencimiento, decimal precioCompra,
            decimal precioVenta)
        {
            Codigo = codigo;
            NombreProducto = nombreProducto;
            Descripcion = descripcion;
            Categoria = categoria;
            FechaIngreso = fechaIngreso;
            FechaVencimiento = fechaVencimiento;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
        }

        // Constructor vacío (opcional si se necesita)
        public ProductoQuicksort() { }
    }
}
