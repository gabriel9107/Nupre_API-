using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasAlertasTiemposIntervalosCatum
{
    public byte TiempoIntervaloNumero { get; set; }

    public string? TiempoIntervaloNombre { get; set; }

    public string? TiempoIntervaloExplicacion { get; set; }

    public int? TiempoIntervaloCantidadHoras { get; set; }

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

    public virtual ICollection<SistemasAlertasFrecuenciasCatum> SistemasAlertasFrecuenciasCata { get; set; } = new List<SistemasAlertasFrecuenciasCatum>();
}
