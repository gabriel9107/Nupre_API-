using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas52Tran
{
    public long SeguimientoCodigo { get; set; }

    public int SeguimientoLote { get; set; }

    public long ArchivoLinea { get; set; }

    public string RncOCedula { get; set; } = null!;

    public string NoDocumento { get; set; } = null!;

    public string CiioCodigo { get; set; } = null!;

    public string ExpedienteArlNumero { get; set; } = null!;

    public string FechaNotificacionEp { get; set; } = null!;

    public string TiempoActividadLaboralAnioEp { get; set; } = null!;

    public string TiempoActividadLaboralMesEp { get; set; } = null!;

    public string CodigoCie10 { get; set; } = null!;

    public string FechaDiagnostico { get; set; } = null!;

    public string PrestadoraNumero { get; set; } = null!;

    public string MedicoCedula { get; set; } = null!;

    public string RegistroValidacionEstado { get; set; } = null!;

    public string RegistroValidacionErrores { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string ResgistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
