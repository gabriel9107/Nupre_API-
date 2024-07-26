using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasAlertasVisualizacionesTran
{
    public int AlertaNumero { get; set; }

    public byte AlertaSecuencia { get; set; }

    public byte GrupoSeguridadNumero { get; set; }

    /// <summary>
    /// Nombre de usuario de la persona registrado como usuario en el sistema.
    /// </summary>
    public string UsuarioUsuarioNombre { get; set; } = null!;

    public string? AlertaVisualizacionUsuario { get; set; }

    public DateTime? AlertaVisualizacionFecha { get; set; }

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

    public virtual SistemasAlertasTran Alerta { get; set; } = null!;
}
