using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los tipo de eventos para los LOGS de accedo y ejecuciones de los usuarios  que utilizan los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguridadEventosLogsTipoCatum
{
    /// <summary>
    /// Número único del  tipo eventos log  que se ejecuta en el sistema.
    /// </summary>
    public byte EventoLogTipoNumero { get; set; }

    /// <summary>
    /// Descripción del  tipo eventos log  que se ejecuta en el sistema.
    /// </summary>
    public string EventoLogTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción del  tipo eventos log  que se ejecuta en el sistema.
    /// </summary>
    public string EventoLogTipoExplicacion { get; set; } = null!;

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

    public virtual ICollection<SeguridadEventosLogsTran> SeguridadEventosLogsTrans { get; set; } = new List<SeguridadEventosLogsTran>();
}
