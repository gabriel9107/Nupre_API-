using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas35Tran
{
    /// <summary>
    /// Código del seguimiento de la carga
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número de seguimiento del lote de carga
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Número que indetifica la lineas de errores del archivo
    /// </summary>
    public long ArchivoLinea { get; set; }

    /// <summary>
    /// Número unico asignado a cada ARS
    /// </summary>
    public int InstitucionNumero { get; set; }

    public string? ArsNumero { get; set; }

    /// <summary>
    /// Número unico asignado a cada PSS
    /// Salud.
    /// </summary>
    public string PrestadoraNumero { get; set; } = null!;

    /// <summary>
    /// Número de seguridad social del afiliado
    /// </summary>
    public string Nss { get; set; } = null!;

    /// <summary>
    /// Número unico para una relación de procedimiento realizado a un afiliado
    /// </summary>
    public string EpisodioNumero { get; set; } = null!;

    /// <summary>
    /// Para indicar el tipo de atención del afiliado
    /// </summary>
    public string TipoAtencion { get; set; } = null!;

    /// <summary>
    /// Caracterizacion del servicio prestado
    /// </summary>
    public string TipoServicio { get; set; } = null!;

    /// <summary>
    /// Número del subgrupo del servicio  del PDSS  bajo el cual se presto la atencion al afiliado del PDSS
    /// </summary>
    public string SubGrupoNumero { get; set; } = null!;

    /// <summary>
    /// Son los procedimiento servicios y medicamentos previstos o analizado al afiliado.
    /// </summary>
    public string CoberturaNumero { get; set; } = null!;

    /// <summary>
    /// Fecha a la que el PDSS solicta la atencion de prestacion de servicio a la ARS.
    /// </summary>
    public string FechaAutorizacion { get; set; } = null!;

    /// <summary>
    /// Fecha en la que la RAS registra la autorizacion  en su sistema(DDMMAAAA)
    /// </summary>
    public string FechaApertura { get; set; } = null!;

    /// <summary>
    /// Fecha en la que el PSS presta servicio al afiliado.
    /// </summary>
    public string FechaRealizacion { get; set; } = null!;

    /// <summary>
    /// Fecha en que la ARS paga a la PSS por el servicio prestado (DDMMAAAA)
    /// </summary>
    public string FechaPago { get; set; } = null!;

    /// <summary>
    /// Número único del plan que el afiliado tiene contratado con la ARS 
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    /// <summary>
    /// Monto reclamado por la PSS a la ARS
    /// </summary>
    public string MontoReclamado { get; set; } = null!;

    /// <summary>
    /// Monto pagado por la ARS a la PSS
    /// </summary>
    public string MontoPagado { get; set; } = null!;

    /// <summary>
    /// Monto pagado por el afiliado como copago
    /// </summary>
    public string MontoPagadoAfiliado { get; set; } = null!;

    /// <summary>
    /// Solo sera llenado cuando el tipo de servicio coresponda a una hospitalización medica o quirulgica
    /// </summary>
    public string FechaEgreso { get; set; } = null!;

    /// <summary>
    /// Solo sera llenado cuando el tipo de servicio coresponda a una hospitalización medica o quirulgica
    /// </summary>
    public string CircunstanciaEgreso { get; set; } = null!;

    /// <summary>
    /// OK= Activo , RE=Rechazado
    /// </summary>
    public string RegistroValidacionEstado { get; set; } = null!;

    /// <summary>
    /// Número que identifican  los errores del del archivo de carga 
    /// </summary>
    public string RegistroValidacionErrores { get; set; } = null!;

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
