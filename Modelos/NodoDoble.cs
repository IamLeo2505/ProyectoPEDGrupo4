using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4.Modelos
{
    public class NodoDoble
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public NodoDoble Anterior { get; set; }
        public NodoDoble Siguiente { get; set; }

        public NodoDoble(string codigo, string nombre, string descripcion, string categoria, DateTime fechaIngreso, DateTime fechaVencimiento, decimal precioCompra, decimal precioVenta)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Categoria = categoria;
            FechaIngreso = fechaIngreso;
            FechaVencimiento = fechaVencimiento;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Anterior = null;
            Siguiente = null;
        }
    }

}
