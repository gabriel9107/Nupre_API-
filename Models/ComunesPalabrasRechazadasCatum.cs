using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ComunesPalabrasRechazadasCatum
{
    public string PalabraDetalle { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string? RegistroUsuario { get; set; }

    public DateTime RegistroFecha { get; set; }
}
