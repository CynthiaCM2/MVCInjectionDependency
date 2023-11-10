using System;
using System.Collections.Generic;

namespace MVCInjectionDependency.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Codigo { get; set; }
        public decimal? Precio { get; set; }
        public string? Departamento { get; set; }
        public int? Existencia { get; set; }
    }
}
