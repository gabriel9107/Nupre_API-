using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro que contiene las informaciones de las tablas nuevas  que han sido creadas, su fuente de datos son los procesos del proyecto de mejorar de base de datos.
/// </summary>
public partial class ProyectoTablasNuevasMaster
{
    /// <summary>
    /// Nombre de la tabla (objeto).
    /// </summary>
    public string TablaNuevaNombre { get; set; } = null!;

    /// <summary>
    /// Describe la información  contenida en la tabla y su propósito.
    /// </summary>
    public string TablaNuevaContenido { get; set; } = null!;

    /// <summary>
    /// Nombre del servidor de base de datos donde se encuentra alojada la tabla.
    /// </summary>
    public string TablaNuevaServidor { get; set; } = null!;

    /// <summary>
    /// Nombre de la Base de Datos donde se encuentra alojada la tabla.
    /// </summary>
    public string TablaNuevaBdd { get; set; } = null!;

    /// <summary>
    /// Cantidad de registro con la fue que creada la tabla.
    /// </summary>
    public int TablaNuevaRegistros { get; set; }

    /// <summary>
    /// Indica si la nueva tabla ha sido certificada por la gerencia de operaciones.
    /// </summary>
    public string TablaNuevaCertificada { get; set; } = null!;

    /// <summary>
    /// Para registrar cualquier observación o comentario en relación a la tabla.
    /// </summary>
    public string TablaNuevaComentario { get; set; } = null!;

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

    public virtual ICollection<ProyectoTablasSustituidasMaster> ProyectoTablasSustituidasMasters { get; set; } = new List<ProyectoTablasSustituidasMaster>();
}
