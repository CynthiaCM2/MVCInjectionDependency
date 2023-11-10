using System;
using System.Collections.Generic;

namespace MVCInjectionDependency.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? NoCliente { get; set; }
        public string? Direccion { get; set; }
        public int? Edad { get; set; }
    }
}
