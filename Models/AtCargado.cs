using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtCargado
{
    public int AtCargadoSecuencia { get; set; }

    public byte IdArs { get; set; }

    public int AtNumero { get; set; }

    public DateTime AtInformeFecha { get; set; }

    public long IdNss { get; set; }

    public byte AtOrigenNumero { get; set; }

    public byte AtOrigenNumeroCambio { get; set; }

    public DateTime AtFecha { get; set; }

    public string AtHora { get; set; } = null!;

    public byte IdVehiculoTipoNumero { get; set; }

    public byte AtColisionNumero { get; set; }

    public byte IdProvincia { get; set; }

    public string AtDiagnosticoCodigoCieInicial { get; set; } = null!;

    public string? AtDiagnosticoCodigoCieFinal { get; set; }

    public byte AtEventoNumero { get; set; }

    public long AtEventoNumeroAutorizacion { get; set; }

    public DateTime AtEventoFechaApertura { get; set; }

    public int? PrestadoraNumero { get; set; }

    public string? AtPrestadoraDescripcion { get; set; }

    public DateTime AtEventoFechaEntrada { get; set; }

    public int IdServicioTipoNumero { get; set; }

    public int IdEgresoTipoNumero { get; set; }

    public DateTime? AtEventoFechaEgreso { get; set; }

    public decimal AtEventoMontoReclamado { get; set; }

    public decimal AtEventoMontoImputado { get; set; }

    public int AtEstadoReclamacionNumero { get; set; }

    public decimal AtEventoMontoAfiliado { get; set; }

    public decimal AtEventoMontoPagado { get; set; }

    public string? AtEventoFechaPago { get; set; }

    public string? AtEventoChequeNumero { get; set; }

    public bool? AtEventoChequeReembolso { get; set; }

    public string? Usuario { get; set; }
}
