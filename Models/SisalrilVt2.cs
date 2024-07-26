using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SisalrilVt2
{
    public string NoDocumento { get; set; } = null!;

    public string TipoDocumento { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public string Status { get; set; } = null!;

    public string? IdError { get; set; }

    public DateTime? UltFechaAct { get; set; }

    public int? NNumControl { get; set; }

    public int? NIdRegistro { get; set; }

    public byte? ArsSolicitante { get; set; }

    public long? NssTitular { get; set; }

    public byte? CodigoParentesco { get; set; }

    public byte? IdArs { get; set; }

    public string? Usuario { get; set; }

    public string UsuarioSolicita { get; set; } = null!;

    public int LoteNumero { get; set; }

    public string CargadoEnTss { get; set; } = null!;

    public DateTime? FechaRespuestaTss { get; set; }
}
