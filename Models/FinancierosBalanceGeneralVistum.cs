using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class FinancierosBalanceGeneralVistum
{
    public decimal ArsNumero { get; set; }

    public int SeguimientoPeriodo { get; set; }

    public int ResultadoNumero { get; set; }

    public string CuentaNumero { get; set; } = null!;

    public string CuentaNombre { get; set; } = null!;

    public byte ResultadoNivel { get; set; }

    public int ResultadoDetalleOrden { get; set; }

    public decimal BalanceActual { get; set; }

    public string ArsNombre { get; set; } = null!;

    public string ArsCategoriaCodigo { get; set; } = null!;

    public string ArsCategoriaDescripcion { get; set; } = null!;

    public string? ResultadoNegrita { get; set; }

    public byte? PlanGrupoNumero { get; set; }

    public string? PlanGrupoDescripcion { get; set; }
}
