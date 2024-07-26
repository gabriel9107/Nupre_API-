using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas54Tran
{
    public long SeguimientoCodigo { get; set; }

    public int SeguimientoLote { get; set; }

    public long ArchivoLinea { get; set; }

    public string ReclamanteTipoNumero { get; set; } = null!;

    public string NoDocumento { get; set; } = null!;

    public string ReclamacionFecha { get; set; } = null!;

    public string FechaPago { get; set; } = null!;

    public string PagoTipoNumero { get; set; } = null!;

    public string CoberturaTipoNumero { get; set; } = null!;

    public string CodigoCie9 { get; set; } = null!;

    public string MontoReclamadoProcedimiento { get; set; } = null!;

    public string MontoPagadoProcedimiento { get; set; } = null!;

    public string ReclamacionNumero { get; set; } = null!;

    public string RegistroValidacionEstado { get; set; } = null!;

    public string RegistroValidacionErrores { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
