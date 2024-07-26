using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class FinancierosBalanceComprobacionTemporalTran
{
    public byte ArsNumero { get; set; }

    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public long CuentaCodigo { get; set; }

    public decimal BalanceAnterior { get; set; }

    public decimal BalanceDebito { get; set; }

    public decimal BalanceCredito { get; set; }

    public decimal BalanceActual { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
