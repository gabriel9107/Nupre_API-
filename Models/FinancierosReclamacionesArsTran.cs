using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class FinancierosReclamacionesArsTran
{
    /// <summary>
    /// Número único con el que se identifica la Administradora de Riesgos de Salud ARS.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Periodo al que corresponde la carga realizada por la ARS.
    /// </summary>
    public int SeguimientoPeriodo { get; set; }

    /// <summary>
    /// Número único que asigna la ARS a cada autorización de cobertura en su sistema.
    /// </summary>
    public long ReclamacionAutorizacionNumero { get; set; }

    /// <summary>
    /// Estado en que se encuentran cada una de  las autorizaciones al momento de ser reportada en el esquema. Al corte del período correspondiente.
    /// </summary>
    public byte ReclamacionEstadoNumero { get; set; }

    /// <summary>
    /// Número único de la PSS, según el catálogo de Prestadoras de Servicios de Salud del SIMON.
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Número único del afiliado con el que está registrado en el sistema de la ARS.
    /// </summary>
    public long AfiliadoNumeroUnico { get; set; }

    /// <summary>
    /// Número único del Plan relacionado con la autorización, es el número que asigna la SISALRIL a un plan de cobertura de servicios de salud en el SFS.
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    /// <summary>
    /// Número de seguridad social del afiliado cuando la autorización corresponde a los planes del PDSS, Complementarios  y  de Medicina Pre-pagada.
    /// </summary>
    public long AfiliadoNss { get; set; }

    /// <summary>
    /// Fecha a la que corresponde la autorización. Formato DDMMYYYY.
    /// </summary>
    public int ReclamacionFechaAutorizacion { get; set; }

    /// <summary>
    /// Fecha es que se inicio la entrega de los servicios por parte de la PSS al Afiliado. Formato DDMMYYYY.
    /// </summary>
    public int ReclamacionFechaInicioServicio { get; set; }

    /// <summary>
    /// Fecha a la que corresponde la reclamación. Formato DDMMYYYY.
    /// </summary>
    public int ReclamacionFecha { get; set; }

    /// <summary>
    /// Fecha en que se realizo el último pago a la reclamación. Formato DDMMYYYY.
    /// </summary>
    public int ReclamacionFechaUltimoPago { get; set; }

    /// <summary>
    /// Caracterización del tipo de servicio prestado.
    /// </summary>
    public string ServicioTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Seguro bajo el cual se prestaron los servicios.  (1 = SFS = FS, 2 = SRL = RL, 3 = AT = AT).
    /// </summary>
    public byte SeguroTipoNumero { get; set; }

    /// <summary>
    /// Es el número de Cheque o transacción bancaria con la cual la ARS realizó el último pago a la PSS, por cada autorización reportada. Al corte del período correspondiente.
    /// </summary>
    public long DocumentoPagoNumero { get; set; }

    /// <summary>
    /// Es el tipo de documento Cheque = CK o transacción bancaria = TR con el cual la ARS realizó el último pago a la PSS, por cada autorización reportada. Al corte del período correspondiente.
    /// </summary>
    public byte DocumentoPagoTipoNumero { get; set; }

    /// <summary>
    /// Monto total aprobado por cada autorización reportada. (Utilice 9999999.99 para cuando tenga decimales y/o 9999999.00 cuando no tenga decimales).
    /// </summary>
    public decimal ReclamacionMontoAutorizado { get; set; }

    /// <summary>
    /// Es el monto que reclama la PSS a la ARS por los servicios prestados por cada autorización reportada. (Utilice 9999999.99 para cuando tenga decimales y/o 9999999.00 cuando no tenga decimales).
    /// </summary>
    public decimal ReclamacionMontoReclamado { get; set; }

    /// <summary>
    /// Es el monto que pago el afiliado directamente a la PSS como diferencia de cobertura no cubierta por la ARS por cada autorización reportada. (Utilice 9999999.99 para cuando tenga decimales y/o 9999999.00 cuando no tenga decimales).
    /// </summary>
    public decimal ReclamacionMontoCopago { get; set; }

    /// <summary>
    /// Es el monto aclarado por la ARS partir del monto reclamado por la PSS por los servicios prestados por cada autorización reportada.
    /// </summary>
    public decimal ReclamacionMontoGlosado { get; set; }

    /// <summary>
    /// Es el monto total pagado por la ARS a la PSS por cada autorización reportada. Al corte del período correspondiente.
    /// </summary>
    public decimal ReclamacionMontoPagado { get; set; }

    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual FinancierosDocumentosPagoTipoCatum DocumentoPagoTipoNumeroNavigation { get; set; } = null!;

    public virtual PlanesMaster PlanNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasMaster PrestadoraNumeroNavigation { get; set; } = null!;

    public virtual FinancierosReclamacionesEstadosCatum ReclamacionEstadoNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;

    public virtual FinancierosSegurosTipoCatum SeguroTipoNumeroNavigation { get; set; } = null!;

    public virtual EpisodiosServiciosTipoCatum ServicioTipoCodigoNavigation { get; set; } = null!;
}
