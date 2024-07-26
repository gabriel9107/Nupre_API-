using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipos de vencimientos que afectan los traspaso, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosVecimientosTipoCatum
{
    /// <summary>
    /// Número único que especifica el tipo de vencimiento de traspaso.
    /// </summary>
    public byte TraspasoVencimientoTipoNumero { get; set; }

    /// <summary>
    /// Descripción  que especifica del tipo de vencimiento de traspaso.
    /// </summary>
    public string TraspasoVencimientoTipoDescripcion { get; set; } = null!;

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

    public virtual ICollection<TraspasosMaster> TraspasosMasters { get; set; } = new List<TraspasosMaster>();
}
