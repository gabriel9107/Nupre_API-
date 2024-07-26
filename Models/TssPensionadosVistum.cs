using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssPensionadosVistum
{
    public int PensionadoNumero { get; set; }

    public string PensionadoDocumentoNo { get; set; } = null!;

    public long? CiudadanoNss { get; set; }

    public string PensionadoNombre { get; set; } = null!;

    public DateTime? PensionadoFechaNacimiento { get; set; }

    public string PensionadoDireccion { get; set; } = null!;

    public string PensionadoTelefono { get; set; } = null!;

    public string StatusCodigo { get; set; } = null!;

    public string? StatusDescripcion { get; set; }

    public byte ArsNumero { get; set; }

    public string? ArsNombre { get; set; }

    public DateTime? PensionadoFechaAfiliacion { get; set; }

    public DateTime? PensionadoFechaBajaSeh { get; set; }

    public DateTime? PensionadoFechaDesafiliacion { get; set; }

    public DateTime? PensionadoFechaRegistroTss { get; set; }

    public decimal PensionadoMontoPension { get; set; }

    public string RegistroEstado { get; set; } = null!;
}
