using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas07Tran
{
    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public long ArchivoLinea { get; set; }

    public int? InstitucionNumero { get; set; }

    public string? NumeroAutorizacion { get; set; }

    public string? FechaAutorizacion { get; set; }

    public string? PssNumero { get; set; }

    public string? NumeroUnicoAfiliado { get; set; }

    public string? NssAfiliado { get; set; }

    public string? PlanNumero { get; set; }

    public string? MontoAutorizado { get; set; }

    public string? EstadoAutorizacion { get; set; }

    public string? TipoServicio { get; set; }

    public string? TipoSeguro { get; set; }

    /// <summary>
    /// Fecha es que se inicio la entrega de los servicios por parte de la PSS al Afiliado. Formato DDMMYYYY.
    /// </summary>
    public string? FechaInicioServicio { get; set; }

    public string? FechaReclamacion { get; set; }

    public string? MontoReclamado { get; set; }

    public string? MontoCopago { get; set; }

    public string? MontoGlosado { get; set; }

    public string? FechaUltimoPago { get; set; }

    public string? MontoPagado { get; set; }

    public string? NumeroDocumentoPago { get; set; }

    public string? TipoDocumentoPago { get; set; }

    public string? RegistroValidacionEstado { get; set; }

    public string? RegistroValidacionErrores { get; set; }

    /// <summary>
    /// A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }
}
