using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasMedicosArsVistum
{
    public byte ArsNumero { get; set; }

    public int PrestadoraNumero { get; set; }

    public byte PlanTipoNumero { get; set; }

    public int SeguimientoPeriodo { get; set; }

    public string MedicoCedula { get; set; } = null!;

    public short EspecialidadNumero1 { get; set; }

    public short EspecialidadNumero2 { get; set; }

    public short EspecialidadNumero3 { get; set; }

    public string MedicoTieneContrato { get; set; } = null!;

    public DateTime? MedicoContratoDesde { get; set; }

    public DateTime? MedicoContratoHasta { get; set; }

    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public DateTime? FechaUltimoReporte { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
