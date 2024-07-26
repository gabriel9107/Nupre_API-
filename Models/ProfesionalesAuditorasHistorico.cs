using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProfesionalesAuditorasHistorico
{
    public int AuditoraRegistroPatronal { get; set; }

    public string AuditoraRncOCedula { get; set; } = null!;

    public DateTime AuditoraFechaAcreditacion { get; set; }

    public byte AuditoraEstadoNumero { get; set; }

    public DateTime AuditoraEstadoFecha { get; set; }

    public string AuditoraNota { get; set; } = null!;

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

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFechaHistorico { get; set; }

    public virtual ProfesionalesAuditorasMaster AuditoraRegistroPatronalNavigation { get; set; } = null!;
}
