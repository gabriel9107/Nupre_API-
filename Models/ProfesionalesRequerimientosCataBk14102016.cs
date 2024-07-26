using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProfesionalesRequerimientosCataBk14102016
{
    public byte RequerimientoNumero { get; set; }

    public string RequerimientoDescripcion { get; set; } = null!;

    public byte RequerimientoOrden { get; set; }

    public string RequerimientoObligatorio { get; set; } = null!;

    public string RequerimientoFechaVencimiento { get; set; } = null!;

    public byte AplicaNumero { get; set; }

    public string RequerimientoAplicaRenovacion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
