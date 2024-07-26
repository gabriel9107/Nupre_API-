using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los tipos de eventos que se ejecutan para un Lote de un seguimiento  de carga de esquema de una ARS/ARL durante el proceso de carga, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosLotesEventosTipoCatum
{
    /// <summary>
    /// Número único que representa cada evento que forma parte del proceso de una carga de esquema.
    /// </summary>
    public byte EventoTipoNumero { get; set; }

    /// <summary>
    /// Descripción de  cada evento que forma parte del proceso de una carga de esquema.
    /// </summary>
    public string EventoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción de  cada evento que forma parte del proceso de una carga de esquema.
    /// </summary>
    public string EventoTipoExplicacion { get; set; } = null!;

    public byte? SeguimientoEstadoEventoInicia { get; set; }

    public byte? SeguimientoEstadoEventoTermina { get; set; }

    public byte? SeguimientoEstadoEventoError { get; set; }

    /// <summary>
    /// Es un número que representa el estado de procesamiento en que se encuentra un seguimiento de carga de esquema.
    /// </summary>
    public byte SeguimientoEstadoNumero { get; set; }

    /// <summary>
    /// Es un número que representa el estado de procesamiento en que se encuentra un seguimiento de carga de esquema.
    /// </summary>
    public byte SeguimientoEstadoNumeroError { get; set; }

    public string EventoVisualizacionExterna { get; set; } = null!;

    public byte EventoVisualizacionOrden { get; set; }

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

    public virtual SeguimientosEstadosCatum SeguimientoEstadoNumeroErrorNavigation { get; set; } = null!;

    public virtual SeguimientosEstadosCatum SeguimientoEstadoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<SeguimientosLotesEventosProcedimientosTran> SeguimientosLotesEventosProcedimientosTrans { get; set; } = new List<SeguimientosLotesEventosProcedimientosTran>();

    public virtual ICollection<SeguimientosLotesEventosTran> SeguimientosLotesEventosTrans { get; set; } = new List<SeguimientosLotesEventosTran>();
}
