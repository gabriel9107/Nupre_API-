using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los orígenes tipo de cuentas contables,  identifica el origen del  catálogo de cuentas contables, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class FinancierosCuentasOrigenCatum
{
    /// <summary>
    /// Código que representa el origen de la cuenta contable.
    /// </summary>
    public string CuentaOrigenCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del origen de la cuenta contable en el catálogo de cuentas
    /// </summary>
    public string CuentaOrigenDescripcion { get; set; } = null!;

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
