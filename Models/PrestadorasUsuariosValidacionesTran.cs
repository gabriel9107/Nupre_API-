using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasUsuariosValidacionesTran
{
    public int PrestadoraValidacionId { get; set; }

    public string PrestadoraValidacionCodigo { get; set; } = null!;

    public string NoDocumento { get; set; } = null!;

    public long IdNss { get; set; }

    public int PrestadoraNumero { get; set; }

    public DateTime PrestadoraValidacionFecha { get; set; }
}
