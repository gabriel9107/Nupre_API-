using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro  que contiene los detalles de cada uno de los seguimientos  que se generan para un período de carga de un esquema de cada ARS/ARL, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosMaster
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Año correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public int SeguimientoPeriodoAno { get; set; }

    /// <summary>
    /// Mes correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public short SeguimientoPeriodoMes { get; set; }

    /// <summary>
    /// Es un número que representa el estado de procesamiento en que se encuentra un seguimiento de carga de esquema.
    /// </summary>
    public byte SeguimientoEstadoNumero { get; set; }

    /// <summary>
    /// Número de la institución que es o a la que pertenece la ARS.
    /// </summary>
    public int InstitucionNumero { get; set; }

    /// <summary>
    /// Número único que representa cada  esquema.
    /// </summary>
    public byte EsquemaNumero { get; set; }

    /// <summary>
    /// Fecha limite que tienen la ARS para realizar la carga de un esquema para un periodo especifico (Seguimiento).
    /// </summary>
    public DateTime SeguimientoFechaEnvioHasta { get; set; }

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

    public virtual SeguimientosEsquemasCatum EsquemaNumeroNavigation { get; set; } = null!;

    public virtual InstitucionesMaster InstitucionNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosEstadosCatum SeguimientoEstadoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<SeguimientosLotesTran> SeguimientosLotesTrans { get; set; } = new List<SeguimientosLotesTran>();

    public virtual ICollection<SeguimientosProrrogasTran> SeguimientosProrrogasTrans { get; set; } = new List<SeguimientosProrrogasTran>();
}
