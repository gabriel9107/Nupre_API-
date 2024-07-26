using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasTipoServiciosCata99
{
    public byte PrestadoraTipoNumero { get; set; }

    public byte PrestadoraServicioNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
