using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los tipos de traspaso, su fuente de datos son los sistemas internos de la SISALRIL y el SUIR UNIPAGO.
/// </summary>
public partial class TraspasosTipoCatum
{
    /// <summary>
    /// Número único que especifica el tipo de traspaso.
    /// </summary>
    public byte TraspasoTipoNumero { get; set; }

    /// <summary>
    /// Descripción del estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string TraspasoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación Descripción del estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string TraspasoTipoExplicacion { get; set; } = null!;

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

    public virtual ICollection<TraspasosRechazosTran> TraspasosRechazosTrans { get; set; } = new List<TraspasosRechazosTran>();
}
