using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class EpisodiosRecurrenciaDiagnosticoCatum
{
    /// <summary>
    /// Código del Diagnostico de Recurrencia (N = Nuevo, R = Recurrente).
    /// </summary>
    public string RecurrenciaDiagnosticoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción de la Recurrencia  del diagnostico, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string RecurrenciaDiagnosticoDescripcion { get; set; } = null!;

    /// <summary>
    /// Descripción de la Recurrencia  del diagnostico, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string RecurrenciaDiagnosticoExplicacion { get; set; } = null!;

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
}
