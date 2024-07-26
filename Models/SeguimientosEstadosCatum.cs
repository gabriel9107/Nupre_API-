using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los estados en que puede estar un seguimiento  de carga de esquema de una ARS/ARL durante  los procesos de las cargas de los esquemas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosEstadosCatum
{
    /// <summary>
    /// Es un número que representa el estado de procesamiento en que se encuentra un seguimiento de carga de esquema.
    /// </summary>
    public byte SeguimientoEstadoNumero { get; set; }

    /// <summary>
    /// Es la descripción del estado de procesamiento en que se encuentra un seguimiento de carga de esquema.
    /// </summary>
    public string SeguimientoEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción del estado de procesamiento en que se encuentra un seguimiento de carga de esquema.
    /// </summary>
    public string SeguimientoEstadoExplicacion { get; set; } = null!;

    /// <summary>
    /// Agrupa los estados de carga de los esquemas en función de un estado principal.
    /// </summary>
    public byte SeguimientoEstadoGrupo { get; set; }

    /// <summary>
    /// Dirección de la carpeta donde se encuentra ubicado el archivo de la imagen (JPG) del estado de carga de los esquemas.
    /// </summary>
    public string SeguimientoEstadoImagenUrl { get; set; } = null!;

    public string SeguimientoEstadoGeneraLote { get; set; } = null!;

    /// <summary>
    /// Indica si este estado lo pueden visualizar las entidades externas a la SISALRIL
    /// </summary>
    public string SeguimientoEstadoVisualizaExternos { get; set; } = null!;

    /// <summary>
    /// Indica si este estado es una de las actividades del ROBOT
    /// </summary>
    public string SeguimientoEstadoIndicaActividadRobot { get; set; } = null!;

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

    public virtual ICollection<SeguimientosLotesEventosTipoCatum> SeguimientosLotesEventosTipoCatumSeguimientoEstadoNumeroErrorNavigations { get; set; } = new List<SeguimientosLotesEventosTipoCatum>();

    public virtual ICollection<SeguimientosLotesEventosTipoCatum> SeguimientosLotesEventosTipoCatumSeguimientoEstadoNumeroNavigations { get; set; } = new List<SeguimientosLotesEventosTipoCatum>();

    public virtual ICollection<SeguimientosLotesTran> SeguimientosLotesTrans { get; set; } = new List<SeguimientosLotesTran>();

    public virtual ICollection<SeguimientosMaster> SeguimientosMasters { get; set; } = new List<SeguimientosMaster>();
}
