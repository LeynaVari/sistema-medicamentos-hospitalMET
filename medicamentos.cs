using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicamentos
{
    internal class medicamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public string Aplicacion { get; set; }
        public string Marca { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioIVA
        { get { return Math.Round((Precio * 13 / 100), 2); }
        }
        public bool Disponible { get; set; }

        // Constructor
        public medicamento() { }
        public medicamento(int id, string nombre, DateTime dateTime, string presentacion, string aplicacion, string marca, DateTime fechaVencimiento, decimal precio, bool disponible)
        {
            Id = id;
            Nombre = nombre;
            Presentacion = presentacion;
            Aplicacion = aplicacion;
            Marca = marca;
            FechaVencimiento = fechaVencimiento;
            Precio = precio;
            Disponible = disponible;
        }

        
    }
}
