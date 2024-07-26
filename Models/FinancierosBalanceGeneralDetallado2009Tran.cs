using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class FinancierosBalanceGeneralDetallado2009Tran
{
    public int SeguimientoPeriodo { get; set; }

    public byte ArsNumero { get; set; }

    public byte PlanGrupoNumero { get; set; }

    public string ArsNombre { get; set; } = null!;

    public string ArsCategoriaCodigo { get; set; } = null!;

    public string ArsCategoriaDescripcion { get; set; } = null!;

    public string PlanGrupoDescripcion { get; set; } = null!;

    public decimal IngresoSalud { get; set; }

    public decimal OtrosIngreso { get; set; }

    public decimal GastoEnSalud { get; set; }

    public decimal OtrosGastos { get; set; }

    public decimal GastosGeneralesAdministrativos { get; set; }

    public decimal OtrosIngresoGastos { get; set; }

    public decimal ImpuestosReservas { get; set; }

    public decimal BeneficioEjercicio { get; set; }

    public decimal BeneficioSobreIngresoSalud { get; set; }

    public decimal Siniestralidad { get; set; }

    public string DetalladoMonto { get; set; } = null!;
}
