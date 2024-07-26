using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosAfiliadosTrans99
{
    public int Nuct { get; set; }

    public long AfiliadoTitularNss { get; set; }

    public long AfiliadoNss { get; set; }

    public int PeriodoFactura { get; set; }

    public string AfiliadoTipoCodigo { get; set; } = null!;

    public byte ParentescoNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
