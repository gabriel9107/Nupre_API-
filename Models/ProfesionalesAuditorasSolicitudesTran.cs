using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProfesionalesAuditorasSolicitudesTran
{
    public int SolicitudAuditoraNumero { get; set; }

    public DateTime SolicitudFecha { get; set; }

    public int AuditoraRegistroPatronal { get; set; }

    public byte SolicitudEstadoNumero { get; set; }

    public DateTime SolicitudEstadoFecha { get; set; }

    public string SolicitudEstadoNota { get; set; } = null!;

    public string SolicitudUsuarioCuenta { get; set; } = null!;

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

    public virtual ICollection<ProfesionalesAuditorasSolicitudesHistorico> ProfesionalesAuditorasSolicitudesHistoricos { get; set; } = new List<ProfesionalesAuditorasSolicitudesHistorico>();

    public virtual ICollection<ProfesionalesAuditorasSolicitudesRequerimientosTran> ProfesionalesAuditorasSolicitudesRequerimientosTrans { get; set; } = new List<ProfesionalesAuditorasSolicitudesRequerimientosTran>();
}
