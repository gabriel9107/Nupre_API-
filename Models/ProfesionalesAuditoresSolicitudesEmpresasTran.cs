using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProfesionalesAuditoresSolicitudesEmpresasTran
{
    public int SolicitudAuditorNumero { get; set; }

    public string EmpleadorRncOCedula { get; set; } = null!;

    public int EmpleadorLaboraDesde { get; set; }

    public string EmpleadorLaboraActualmente { get; set; } = null!;

    public int EmpleadorLaboraHasta { get; set; }

    public string EmpleadorLabor { get; set; } = null!;

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

    public virtual ProfesionalesAuditoresSolicitudesTran SolicitudAuditorNumeroNavigation { get; set; } = null!;
}
