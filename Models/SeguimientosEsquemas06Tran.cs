using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas06Tran
{
    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public long ArchivoLinea { get; set; }

    public int InstitucionNumero { get; set; }

    public string? CedulaORncPromotor { get; set; }

    public string? NombrePromotor { get; set; }

    public string? TipoPromotor { get; set; }

    public string? NumeroTelefono { get; set; }

    public string? PlanNumero { get; set; }

    public string? MontoPagado { get; set; }

    public string? PromotorNumero { get; set; }

    public string? PlanTipoNumero { get; set; }

    public string? PagoEstado { get; set; }

    public string? PagoPeriodo { get; set; }

    /// <summary>
    /// Indica el periodo al que corresponde el pago de la reclamación cuando su estado es (C) 
    /// </summary>
    public string? TipoDocumentoPago { get; set; }

    /// <summary>
    /// Indica el periodo al que corresponde el pago de la reclamación cuando su estado es (C) 
    /// </summary>
    public string? NumeroDocumentoPago { get; set; }

    /// <summary>
    /// Indica el periodo al que corresponde el pago de la reclamación cuando su estado es (C) 
    /// </summary>
    public string? FechaPago { get; set; }

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
