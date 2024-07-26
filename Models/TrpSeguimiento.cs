using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TrpSeguimiento
{
    public decimal SeguimientoCodigo { get; set; }

    public decimal SeguimientoLote { get; set; }

    public decimal? LoteSuir { get; set; }

    public int? SeguimientoAnoPeriodo { get; set; }

    public short? SeguimientoMesPeriodo { get; set; }

    public decimal InformeCodigo { get; set; }

    public decimal? EstadoCodigo { get; set; }

    public string? SeguimientoRecarga { get; set; }

    public string? SeguimientoErrores { get; set; }

    public string? SeguimientoAlerta { get; set; }

    public string? SeguimientoNotificaciones { get; set; }

    public string? SeguimientoNombreArchivo { get; set; }

    public DateTime FechaDig { get; set; }

    public string Usuario { get; set; } = null!;
}
