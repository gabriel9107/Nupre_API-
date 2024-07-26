using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtEstadoReclamacionCatum
{
    /// <summary>
    /// Número único asignado para el estado de la reclamación.
    /// </summary>
    public byte EstadoReclamacionNumero { get; set; }

    /// <summary>
    /// PE = Reclamación Pendiente, PA = Reclamacion Pagada. 
    /// </summary>
    public string EstadoReclamacionCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción de la reclamación para accidentes de transito.
    /// </summary>
    public string EstadoReclamacionDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la reclamación para accidentes de transito.
    /// </summary>
    public string EstadoReclamacionExplicacion { get; set; } = null!;

    /// <summary>
    /// Estado. A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del Usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de Registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<AtEventosTran> AtEventosTrans { get; set; } = new List<AtEventosTran>();
}
