using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Tabla catálogo que contiene las cuentas del Catálogo de cuentas y las cuentas proporcionales de la misma, su fuente es el catálogo de cuentas de la SISALRIL.
/// </summary>
public partial class FinancierosCuentasProporcionesCatum
{
    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaCodigo { get; set; }

    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaProporcionCodigo { get; set; }

    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaProporcionCodigo2 { get; set; }

    /// <summary>
    /// Es código único  de la cuenta contable padre de cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaControlProporcionCodigo { get; set; }

    /// <summary>
    /// Es código único  de la cuenta contable padre de cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaControlProporcionCodigo2 { get; set; }

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

    public virtual FinancierosCuentasCatum CuentaCodigoNavigation { get; set; } = null!;
}
