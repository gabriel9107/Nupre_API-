using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtEventosTran
{
    /// <summary>
    /// Número unico que identifica a la ARS que reporte el accidente de transito.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número del informe que se esta reportando, del 1 al 52.
    /// </summary>
    public byte AtInformeNumero { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long CiudadanoNss { get; set; }

    /// <summary>
    /// Número secuencial asignado a cada evento del accidente.
    /// </summary>
    public short AtEventoSecuencia { get; set; }

    /// <summary>
    /// Número de autorización del evento otorgado por la ARS.
    /// </summary>
    public long AtEventoAutorizacionNumero { get; set; }

    /// <summary>
    /// Fecha de apertura del evento, igual a la fecha del accidente.
    /// </summary>
    public DateTime AtEventoFechaApertura { get; set; }

    /// <summary>
    /// Código de la Prestadora de Servicios de Salud que recibe al afiliado accidentado. 
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Nombre de la Prestadora de Servicios de Salud que recibe al afiliado accidentado. 
    /// </summary>
    public string PrestadoraNombre { get; set; } = null!;

    /// <summary>
    /// Fecha en la que se recibió al afiliado accidentado en la PSS : Día(DD), Mes (MM) y Año (AAAA).
    /// </summary>
    public DateTime AtEventoFechaEntrada { get; set; }

    /// <summary>
    /// Código para el tipo de servicio por accidente de transito.
    /// </summary>
    public string ServicioTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Código del tipo de egreso para accidentes de transito.
    /// </summary>
    public string EgresoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Fecha de evento del egresado por accidente de transito.
    /// </summary>
    public DateTime AtEventoFechaEgreso { get; set; }

    /// <summary>
    /// Monto total reclamado por la ARS.
    /// </summary>
    public decimal AtEventoMontoReclamado { get; set; }

    /// <summary>
    /// Monto imputado del evento por accidente de transito.
    /// </summary>
    public decimal AtEventoMontoImputado { get; set; }

    /// <summary>
    /// Número único que identifica el estado de la reclamación.
    /// </summary>
    public byte ReclamacionEstadoNumero { get; set; }

    /// <summary>
    /// Monto total de copago pagado por el afiliado.
    /// </summary>
    public decimal AtEventoMontoPagadoAfiliado { get; set; }

    /// <summary>
    /// Monto pagado por la ARS.
    /// </summary>
    public decimal AtEventoMontoPagado { get; set; }

    /// <summary>
    /// Fecha de pago del evento por accidente de transito.
    /// </summary>
    public DateTime AtEventoFechaPago { get; set; }

    /// <summary>
    /// Número de cheque de pago por el evento del accidente de transito.
    /// </summary>
    public string AtEventoChequeNumero { get; set; } = null!;

    /// <summary>
    /// Indicador de reembolso por cheque ante un accidente de transito o evento. 1 = Si, 0 = No.
    /// </summary>
    public bool AtEventoChequeReembolso { get; set; }

    /// <summary>
    /// Estado. A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del Usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de Registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual AtMaster AtMaster { get; set; } = null!;

    public virtual TssCiudadanosMaster CiudadanoNssNavigation { get; set; } = null!;

    public virtual EpisodiosEgresosTipoCatum EgresoTipoCodigoNavigation { get; set; } = null!;

    public virtual PrestadorasMaster PrestadoraNumeroNavigation { get; set; } = null!;

    public virtual AtEstadoReclamacionCatum ReclamacionEstadoNumeroNavigation { get; set; } = null!;

    public virtual EpisodiosServiciosTipoCatum ServicioTipoCodigoNavigation { get; set; } = null!;
}
