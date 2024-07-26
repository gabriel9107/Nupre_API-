using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssPensionadosHistorico
{
    public int PeriodoCorte { get; set; }

    public int PensionadoNumero { get; set; }

    public byte InstitucionNumero { get; set; }

    public string PensionadoDocumentoNo { get; set; } = null!;

    public string PensionadoNombre { get; set; } = null!;

    public DateTime? PensionadoFechaNacimiento { get; set; }

    public string PensionadoDireccion { get; set; } = null!;

    public string PensionadoTelefono { get; set; } = null!;

    public string StatusCodigo { get; set; } = null!;

    public long CiudadanoNss { get; set; }

    public byte ArsNumero { get; set; }

    public int PensionadoFechaAfiliacion { get; set; }

    public int PensionadoFechaBajaSeh { get; set; }

    public int PensionadoFechaDesafiliacion { get; set; }

    public int PensionadoFechaRegistroTss { get; set; }

    public decimal PensionadoMontoPension { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual TssPensionadosMaster PensionadoNumeroNavigation { get; set; } = null!;
}
