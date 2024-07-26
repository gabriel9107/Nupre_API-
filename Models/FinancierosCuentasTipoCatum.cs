using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipo de cuentas contables (cuentas mayores),  clasifica el catálogo de cuentas contables, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class FinancierosCuentasTipoCatum
{
    /// <summary>
    /// Tipifica las cuentas contables según las cuentas mayores.
    /// </summary>
    public byte CuentaTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de las cuentas contables en el catálogo de cuentas según las cuentas mayores.
    /// </summary>
    public string CuentaTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Tipifica las cuentas contables según las cuentas mayores.
    /// </summary>
    public string CuentaTipoCodigo { get; set; } = null!;

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

    public virtual ICollection<FinancierosCuentasCatum> FinancierosCuentasCata { get; set; } = new List<FinancierosCuentasCatum>();
}
