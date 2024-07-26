using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipo de novedades que pueden aplicar a un registro de usuarios  en cualquiera de los sistemas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguridadUsuariosNovedadTipoCatum
{
    /// <summary>
    /// Número  único que representa la novedad sobre el registro de usuarios.
    /// </summary>
    public byte TipoNovedadNumero { get; set; }

    /// <summary>
    /// Descripción de la novedad del registro de usuarios.
    /// </summary>
    public string TipoNovedadDescripcion { get; set; } = null!;

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

    public virtual ICollection<SeguridadUsuariosEstadoClaveCatum> SeguridadUsuariosEstadoClaveCata { get; set; } = new List<SeguridadUsuariosEstadoClaveCatum>();

    public virtual ICollection<SeguridadUsuariosMaster> SeguridadUsuariosMasters { get; set; } = new List<SeguridadUsuariosMaster>();
}
