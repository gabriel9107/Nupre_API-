using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas51Tran
{
    public long SeguimientoCodigo { get; set; }

    public int SeguimientoLote { get; set; }

    public long ArchivoLinea { get; set; }

    public string RncOCedula { get; set; } = null!;

    public string NoDocumento { get; set; } = null!;

    public string CiioCodigo { get; set; } = null!;

    public string FechaNotificacionAt { get; set; } = null!;

    public string MunicipioNumero { get; set; } = null!;

    public string ExpedienteArlNumero { get; set; } = null!;

    public string ContingenciaTipoNumero { get; set; } = null!;

    public string FechaAccidenteTrabajo { get; set; } = null!;

    public string HoraAt { get; set; } = null!;

    public string HoraDejoTrabajar { get; set; } = null!;

    public string PrestadoraNumeroPrimeraAtencion { get; set; } = null!;

    public string PrestadoraNumeroSegundaAtencion { get; set; } = null!;

    public string CodigoCie10 { get; set; } = null!;

    public string Salario { get; set; } = null!;

    public string CantidadHijos { get; set; } = null!;

    public string FechaAltaPrestadora { get; set; } = null!;

    public string SeveridadLesionTipoNumero { get; set; } = null!;

    public string RegistroValidacionEstado { get; set; } = null!;

    public string RegistroValidacionErrores { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
