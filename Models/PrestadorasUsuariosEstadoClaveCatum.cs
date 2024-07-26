using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasUsuariosEstadoClaveCatum
{
    public byte EstadoClaveNumero { get; set; }

    public string EstadoClaveCodigo { get; set; } = null!;

    public string EstadoClaveDescripcion { get; set; } = null!;

    public string EstadoClaveExplicacion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
