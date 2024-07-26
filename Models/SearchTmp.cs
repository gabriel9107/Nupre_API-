using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SearchTmp
{
    public byte PosicionLesionadoNumero { get; set; }

    public string PosicionLesionadoDescripcion { get; set; } = null!;

    public string PosicionLesionadoExplicacion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
