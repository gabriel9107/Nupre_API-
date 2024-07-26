using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas50Tran
{
    public long SeguimientoCodigo { get; set; }

    public int SeguimientoLote { get; set; }

    public long ArchivoLinea { get; set; }

    public string NoDocumento { get; set; } = null!;

    public string ReclamanteTipoNumero { get; set; } = null!;

    public string ReclamacionNotificacionTipoNumero { get; set; } = null!;

    public string MontoReclamado { get; set; } = null!;

    public string ReclamacionNumero { get; set; } = null!;

    public string ReclamacionFecha { get; set; } = null!;

    public string RegistroValidacionEstado { get; set; } = null!;

    public string RegistroValidacionErrores { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
