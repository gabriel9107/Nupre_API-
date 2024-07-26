using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosRespuestaAccionCondicionEnfermedadTran
{
    public int SeguimientoNumero { get; set; }

    public string RegistroTipoCodigo { get; set; } = null!;

    public byte TraspasoTipoNumero { get; set; }

    public long Nuct { get; set; }

    public int LoteSuirNumero { get; set; }

    public int RegistroNumero { get; set; }

    public byte AccionSisalrilNumero { get; set; }

    public byte MotivoAccionSisalrilNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RespuestaCodigo { get; set; } = null!;

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
