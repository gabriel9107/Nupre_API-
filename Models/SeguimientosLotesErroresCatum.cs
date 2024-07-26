using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los errores relacionados con cada uno de los pasos y actividades que se ejecutan en los procedimientos de los procesos de las cargas de los esquemas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosLotesErroresCatum
{
    /// <summary>
    /// Número único del error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema.
    /// </summary>
    public short ErrorNumero { get; set; }

    /// <summary>
    /// Descripción del error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema.
    /// </summary>
    public string ErrorDescripcion { get; set; } = null!;

    /// <summary>
    /// Número único del proceso con el cual se relaciona un número de error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema.
    /// </summary>
    public byte ErrorProcesoNumero { get; set; }

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

    public virtual SeguimientosLotesErroresProcesosCatum ErrorProcesoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<SeguimientosProcedimientosLogTran> SeguimientosProcedimientosLogTrans { get; set; } = new List<SeguimientosProcedimientosLogTran>();
}
