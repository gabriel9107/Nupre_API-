using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class EpisodiosIntervencionesCatum
{
    /// <summary>
    /// Número del Tipo de Intervención, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public byte IntervencionNumero { get; set; }

    /// <summary>
    /// Descripción del Tipo de Intervención, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string IntervencionDescripcion { get; set; } = null!;

    /// <summary>
    /// Indica el tema relacionado al tipo de Intervención.
    /// </summary>
    public string IntervencionTema { get; set; } = null!;

    /// <summary>
    /// Explicación del Tipo de Intervención, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string IntervencionExplicacion { get; set; } = null!;

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
