using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosSeguimientoProblemaImagenTran
{
    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public long SeguimientoLoteSuir { get; set; }

    public int SeguimientoPeriodoAnio { get; set; }

    public byte SeguimientoPeriodoMes { get; set; }

    public byte InformeNumero { get; set; }

    public byte InformeEstadoNumero { get; set; }

    public string SeguimientoRecarga { get; set; } = null!;

    public string SeguimientoErrores { get; set; } = null!;

    public string SeugimientoAlerta { get; set; } = null!;

    public string SeguimientoNotificaciones { get; set; } = null!;

    public string SeguimientoNombreArchivo { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
