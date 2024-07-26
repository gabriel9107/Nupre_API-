using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssEmpleadoresActivosHistorico
{
    public int PeriodoFactura { get; set; }

    public int EmpleadorId { get; set; }

    public short MunicipioNumero { get; set; }

    public string EmpresaTipoCodigo { get; set; } = null!;

    public byte SectorEconomicoNumero { get; set; }

    public int ActividadEconomicaNumero { get; set; }

    public string CategoriaRiesgo { get; set; } = null!;

    public int EmpleadorFechaRegistroTss { get; set; }

    public DateTime RegistroFecha { get; set; }
}
