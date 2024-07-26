using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssCedulasActualizacionesSisalrilTran
{
    public string CiudadanoNoDocumento { get; set; } = null!;

    public string DocumentoTipoCodigo { get; set; } = null!;

    public DateTime? DocumentoRegistroFecha { get; set; }

    public string DocumentoEstado { get; set; } = null!;

    public string? ErrorNumero { get; set; }

    public DateTime? UltimaFechaActualizacion { get; set; }

    public int ControlNumero { get; set; }

    public int? RegistroNumero { get; set; }

    public byte? ArsNumeroSolicitante { get; set; }

    public long? AfiliadoTitularNss { get; set; }

    public byte? ParentescoNumero { get; set; }

    public byte? ArsNumero { get; set; }

    public string? Usuario { get; set; }

    public string RegistroUsuarioSolicita { get; set; } = null!;

    public int LoteNumero { get; set; }

    public string DatosCargadosTss { get; set; } = null!;

    public DateTime? FechaRespuestaTss { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
