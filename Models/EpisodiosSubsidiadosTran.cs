using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class EpisodiosSubsidiadosTran
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long AfiliadoNss { get; set; }

    /// <summary>
    /// Fecha en que se inicio la entrega del servicio de salud (Ingreso/Admisión).
    /// </summary>
    public int EpisodioFechaRealizacion { get; set; }

    /// <summary>
    /// Fecha cuando la ARS pago a la PSS por el servicio prestado.
    /// </summary>
    public int EpisodioFechaPago { get; set; }

    /// <summary>
    /// Es una secuencia de 1 a N que depende del Número de Episodio,  y representa cada detalle de servicio prestado dentro del episodio.
    /// </summary>
    public int EpisodioDetalleSecuencia { get; set; }

    /// <summary>
    /// Fecha cuando la ARS autorizo a la PSS a prestar el servicio de salud.
    /// </summary>
    public int EpisodioFechaAutorizacion { get; set; }

    /// <summary>
    /// Fecha cuando la ARS apertura en sus registro,  la solicitud o autorización para la prestación del servicio de salud.
    /// </summary>
    public int EpisodioFechaApertura { get; set; }

    /// <summary>
    /// Fecha cuando se culmino la prestación del servicio de salud (De Alta/Egreso).
    /// </summary>
    public int EpisodioFechaEgreso { get; set; }

    /// <summary>
    /// Código del Tipo de Atención, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string AtencionTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Código del Tipo de servicio, especifica si el servicio fue prestado bajo el área de  Hospitalización,  Prevención y Promoción,  Emergencia y Ambulatorio.
    /// </summary>
    public string ServicioTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Código único de la versión del Plan de servicios de Salud (PDSS) al cual pertenece el Subgrupo.
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    /// <summary>
    /// Código creado a partir de la combinación de numero de grupo con el numero del subgrupo separados por un punto (.). 
    /// </summary>
    public string SubGrupoCodigo { get; set; } = null!;

    /// <summary>
    /// Numero único de cobertura que representa un  insumo, procedimiento médico, material, fármaco,  servicio  general que fue o puede ser prestado.
    /// </summary>
    public short? CoberturaNumero { get; set; }

    /// <summary>
    /// Monto que representa el valor reclamado por la PSS a la ARS por el servicio prestado.
    /// </summary>
    public decimal EpisodioDetalleMontoReclamado { get; set; }

    /// <summary>
    /// Monto que representa lo pagado por la ARS a la PSS por el servicio prestado.
    /// </summary>
    public decimal EpisodioDetalleMontoPagadoArs { get; set; }

    /// <summary>
    /// Monto que representa lo pagado por  el afiliado directamente a la PSS por el servicio prestado.
    /// </summary>
    public decimal EpisodioDetalleMontoPagadoAfiliado { get; set; }

    /// <summary>
    /// Código del Tipo de Egreso, especifica el estado o situación del paciente (Afiliado) al finalizar un episodio de prestación de servicios de salud (Fallecido, Trasferido, Alta, etc.).
    /// </summary>
    public string EgresoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Número de Episodio,  es un número único que representa y agrupa el conjunto de todos los servicios prestado en una misma atención de salud. 
    /// 
    /// </summary>
    public long EpisodioNumero { get; set; }

    public string EpisodioAutorizacionNumero { get; set; } = null!;

    public long AfiliadoNumeroUnico { get; set; }

    public string EpisodioRecienNacido { get; set; } = null!;

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

    public virtual TssCiudadanosMaster AfiliadoNssNavigation { get; set; } = null!;

    public virtual EpisodiosAtencionesTipoCatum AtencionTipoCodigoNavigation { get; set; } = null!;

    public virtual CoberturasMaster? CoberturaNumeroNavigation { get; set; }

    public virtual EpisodiosEgresosTipoCatum EgresoTipoCodigoNavigation { get; set; } = null!;

    public virtual PrestadorasMaster PrestadoraNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;

    public virtual EpisodiosServiciosTipoCatum ServicioTipoCodigoNavigation { get; set; } = null!;
}
