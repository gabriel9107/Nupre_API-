using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ParametrosCatum
{
    public string ParametroNombre { get; set; } = null!;

    public string ParametroDescripcion { get; set; } = null!;

    public string ParametroValor { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
