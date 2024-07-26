using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtInformesSeguimientosTran
{
    public int AtSeguimientoNumero { get; set; }

    public int AtSeguimientoPeriodo { get; set; }

    public short AtInformeNumero { get; set; }

    public DateTime AtInformeFechaAviso { get; set; }

    public DateTime AtInformeFechaTope { get; set; }

    public DateTime AtInformeFechaDesde { get; set; }

    public DateTime AtInformeFechaHasta { get; set; }

    public int AtInformeDias { get; set; }

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
}
