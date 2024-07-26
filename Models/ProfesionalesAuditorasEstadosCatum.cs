using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProfesionalesAuditorasEstadosCatum
{
    public byte AuditoraEstadoNumero { get; set; }

    public string AuditoraEstadoDescripcion { get; set; } = null!;

    public string AuditoraEstadoExplicacion { get; set; } = null!;

    public string AuditoraEstadoPendiente { get; set; } = null!;

    public string AuditoraEstadoNota { get; set; } = null!;

    public string AuditoraEstadoMensaje { get; set; } = null!;

    public string AuditoraEstadoAuditorMensaje { get; set; } = null!;

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

    public virtual ICollection<ProfesionalesAuditorasMaster> ProfesionalesAuditorasMasters { get; set; } = new List<ProfesionalesAuditorasMaster>();
}
