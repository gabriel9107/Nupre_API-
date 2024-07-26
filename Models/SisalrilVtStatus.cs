using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SisalrilVtStatus
{
    public string StatusCodigo { get; set; } = null!;

    public string StatusDescripcion { get; set; } = null!;

    public string StatusExplicacion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
