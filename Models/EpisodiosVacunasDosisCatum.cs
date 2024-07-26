using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class EpisodiosVacunasDosisCatum
{
    /// <summary>
    /// Número que representa la Dosis de Vacuna.
    /// </summary>
    public string VacunaDosisCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción de la Dosis de Vacuna, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string VacunaDosisDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación de la Dosis de Vacuna, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string VacunaDosisExplicacion { get; set; } = null!;

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
