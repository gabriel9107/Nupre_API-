using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas41Tran
{
    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public long ArchivoLinea { get; set; }

    public int InstitucionNumero { get; set; }

    public string PrestadoraNumeroSrs { get; set; } = null!;

    public string PrestadoraNumero { get; set; } = null!;

    public string Nss { get; set; } = null!;

    public string RecienNacidos { get; set; } = null!;

    public string FechaNacimientoRecienNacido { get; set; } = null!;

    public string NumeroFacturaSrs { get; set; } = null!;

    public string TipoAtencion { get; set; } = null!;

    public string Frecuencia { get; set; } = null!;

    public string HistoriaClinicaNumero { get; set; } = null!;

    public string NumeroFichaFamiliar { get; set; } = null!;

    public string CodigoIntervencion { get; set; } = null!;

    public string CodigoDiagnosticoPrincipal { get; set; } = null!;

    public string RecurrenciaDiagnostico { get; set; } = null!;

    public string Cobertura { get; set; } = null!;

    public string VacunaDosisORefuerzo { get; set; } = null!;

    public string TipoReferencia { get; set; } = null!;

    public string CausaReferencia { get; set; } = null!;

    public string PrestadoraNumeroReferido { get; set; } = null!;

    public string TipoPersonalPrestaServicio { get; set; } = null!;

    public string FechaAtencion { get; set; } = null!;

    public string FechaFactura { get; set; } = null!;

    public string FechaPago { get; set; } = null!;

    public string ValorReclamado { get; set; } = null!;

    public string ValorPagado { get; set; } = null!;

    public string EpisodioNumero { get; set; } = null!;

    public string RegistroValidacionEstado { get; set; } = null!;

    public string RegistroValidacionErrores { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
