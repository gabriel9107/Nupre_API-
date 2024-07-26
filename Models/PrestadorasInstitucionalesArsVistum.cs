using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasInstitucionalesArsVistum
{
    public byte ArsNumero { get; set; }

    public int PrestadoraNumero { get; set; }

    public byte PlanTipoNumero { get; set; }

    public int SeguimientoPeriodo { get; set; }

    public DateTime PrestadoraContratoDesde { get; set; }

    public DateTime? PrestadoraContratoHasta { get; set; }

    public short PrestadoraMedicos { get; set; }

    public string PrestadoraPrimerNivel { get; set; } = null!;

    public string PrestadoraSegundoNivel { get; set; } = null!;

    public string PrestadoraTercerNivel { get; set; } = null!;

    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public DateTime? FechaUltimoReporte { get; set; }
}
