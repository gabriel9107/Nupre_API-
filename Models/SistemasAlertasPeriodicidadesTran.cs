using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasAlertasPeriodicidadesTran
{
    public int AlertaNumero { get; set; }

    public DateTime? PeriodicidadInicioFecha { get; set; }

    public string? PeriodicidadInicioHora { get; set; }

    public DateTime? PeriodicidadFinFecha { get; set; }

    public string? PeriodicidadFinHora { get; set; }

    public string? PeriodicidadGenerada { get; set; }

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

    public virtual SistemasAlertasMaster? SistemasAlertasMaster { get; set; }
}
