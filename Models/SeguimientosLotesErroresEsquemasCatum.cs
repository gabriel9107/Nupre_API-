using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosLotesErroresEsquemasCatum
{
    public byte EsquemaNumero { get; set; }

    public string EsquemaCampo { get; set; } = null!;

    public short ErrorNumero { get; set; }

    public string ErrorDescripcion { get; set; } = null!;

    public string ErrorExplicacion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
