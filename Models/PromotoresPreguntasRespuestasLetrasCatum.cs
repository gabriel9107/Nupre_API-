using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PromotoresPreguntasRespuestasLetrasCatum
{
    public byte LetraNumero { get; set; }

    public string LetraLetra { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
