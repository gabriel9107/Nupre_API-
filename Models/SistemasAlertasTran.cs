using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasAlertasTran
{
    public int AlertaNumero { get; set; }

    public byte AlertaSecuencia { get; set; }

    public string? AlertaMensaje { get; set; }

    public DateTime? AlertaFecha { get; set; }

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

    public virtual SistemasAlertasMaster AlertaNumeroNavigation { get; set; } = null!;

    public virtual ICollection<SistemasAlertasVisualizacionesTran> SistemasAlertasVisualizacionesTrans { get; set; } = new List<SistemasAlertasVisualizacionesTran>();
}
