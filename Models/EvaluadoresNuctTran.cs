using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class EvaluadoresNuctTran
{
    public int EmpleadoNumero { get; set; }

    public byte TraspasoSolicitudTipoNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
