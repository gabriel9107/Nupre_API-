using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los grupos de acceso de seguridad, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguridadGruposCatum
{
    /// <summary>
    /// Número único del grupo de seguridad al que pertenecen los usuarios de los sistemas de información.
    /// </summary>
    public byte GrupoSeguridadNumero { get; set; }

    /// <summary>
    /// Número único del sistema de información.
    /// </summary>
    public short SistemaNumero { get; set; }

    /// <summary>
    /// Descripción del grupo de seguridad al que pertenecen los usuarios de los sistemas de información.
    /// </summary>
    public string GrupoSeguridadDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción del grupo de seguridad al que pertenecen los usuarios de los sistemas de información.
    /// </summary>
    public string GrupoSeguridadExplicacion { get; set; } = null!;

    /// <summary>
    /// Indica si el grupo de seguridad permite la inclusión de usuarios externos.
    /// </summary>
    public string GrupoSeguridadUsuarioExterno { get; set; } = null!;

    /// <summary>
    /// Indica si el grupo de seguridad permite la inclusión de usuarios internos.
    /// </summary>
    public string GrupoSeguridadUsuarioInterno { get; set; } = null!;

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

    public virtual ICollection<AcreditacionesSeguridadGruposCatum> AcreditacionesSeguridadGruposCata { get; set; } = new List<AcreditacionesSeguridadGruposCatum>();

    public virtual ICollection<SeguimientosEsquemasCatum> SeguimientosEsquemasCata { get; set; } = new List<SeguimientosEsquemasCatum>();

    public virtual ICollection<SeguridadGruposConsultasTran> SeguridadGruposConsultasTrans { get; set; } = new List<SeguridadGruposConsultasTran>();

    public virtual ICollection<SeguridadGruposFuncionesTran> SeguridadGruposFuncionesTrans { get; set; } = new List<SeguridadGruposFuncionesTran>();

    public virtual ICollection<SeguridadGruposPermisosTran> SeguridadGruposPermisosTrans { get; set; } = new List<SeguridadGruposPermisosTran>();

    public virtual ICollection<SeguridadUsuariosGruposTran> SeguridadUsuariosGruposTrans { get; set; } = new List<SeguridadUsuariosGruposTran>();

    public virtual SistemasMaster SistemaNumeroNavigation { get; set; } = null!;
}
