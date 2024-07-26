using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class FinancierosEstadosCuentasCatum
{
    public byte EstadoFinancieroNumero { get; set; }

    public byte EstadoResultadoNumero { get; set; }

    public string EstadoResultadoTitulo { get; set; } = null!;

    public byte EstadoResultadoNivel { get; set; }

    public string EstadoResultadoNegrita { get; set; } = null!;

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

    public virtual ICollection<FinancierosEstadosTran> FinancierosEstadosTrans { get; set; } = new List<FinancierosEstadosTran>();
}
