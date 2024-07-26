using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemasLinkCatum
{
    public int EsquemaNumero { get; set; }

    public int EsquemaCodigo { get; set; }

    public string EsquemaNombre { get; set; } = null!;

    public string EsquemaDescripcion { get; set; } = null!;

    public string EsquemaLink { get; set; } = null!;

    public string? EsquemaAcceso { get; set; }

    public byte? GrupoSeguridadNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
