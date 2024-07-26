using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosCancelacionSisalrilArsTran
{
    public int SeguimientoNumero { get; set; }

    public string RegistroTipoCodigo { get; set; } = null!;

    public byte TraspasoTipoNumero { get; set; }

    public long Nuct { get; set; }

    public long AfiliadoTitularNss { get; set; }

    public string AfiliadoTitularCedula { get; set; } = null!;

    public byte MotivoNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RespuestaCodigo { get; set; } = null!;

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
