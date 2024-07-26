using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SisalrilVtLote
{
    public int LoteNumero { get; set; }

    public int? LoteRegistrosSisalril { get; set; }

    public int? LoteRegistrosTss { get; set; }

    public DateTime? LoteFechaCarga { get; set; }

    public DateTime? LoteFechaValidacion { get; set; }

    public string? LoteUsaurio { get; set; }

    public string? RegistroEstado { get; set; }
}
