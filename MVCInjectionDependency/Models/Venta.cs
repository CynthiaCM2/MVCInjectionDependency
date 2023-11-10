using System;
using System.Collections.Generic;

namespace MVCInjectionDependency.Models
{
    public partial class Venta
    {
        public int Id { get; set; }
        public string? Mes { get; set; }
        public string? Producto { get; set; }
        public int? CantidadDeVentas { get; set; }
        public decimal? Precio { get; set; }
        public decimal? TotalVentas { get; set; }
    }
}
