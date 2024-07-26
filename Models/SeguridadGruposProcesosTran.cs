using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los procedimientos de BDD los sistemas  y los grupos de usuarios que pueden ejecutarlos, su fuente de datos los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguridadGruposProcesosTran
{
    /// <summary>
    /// Número único del grupo de seguridad al que pertenecen los usuarios de los sistemas de información.
    /// </summary>
    public byte GrupoSeguridadNumero { get; set; }

    /// <summary>
    /// Nombre del procedimiento de BDD.
    /// </summary>
    public string ProcesoNombre { get; set; } = null!;

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

    public virtual SistemasWebserviceProcesosMaster ProcesoNombreNavigation { get; set; } = null!;
}
