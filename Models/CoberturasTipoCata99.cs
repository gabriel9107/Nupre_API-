using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CoberturasTipoCata99
{
    public byte CoberturaTipoNumero { get; set; }

    public string CoberturaTipoDescripcion { get; set; } = null!;

    public string CoberturaTipoCups { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
