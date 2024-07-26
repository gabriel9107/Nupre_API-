using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ComunesPeriodosMasterE
{
    public int PeriodoFactura { get; set; }

    public int PeriodoSecuencia { get; set; }

    public string PeriodoFormateado { get; set; } = null!;

    public short PeriodoFacturaAnio { get; set; }

    public byte PeriodoFacturaMes { get; set; }

    public byte PeriodoFacturaTrimestre { get; set; }

    public byte PeriodoFacturaCuatrimestre { get; set; }

    public short PeriodoDispersionAnio { get; set; }

    public byte PeriodoDispersionMes { get; set; }

    public int PeriodoDispersion { get; set; }

    public decimal SfsAporteEmpleador { get; set; }

    public decimal SfsAporteTrabajador { get; set; }

    public decimal SfsSalarioCotizable { get; set; }

    public decimal SfsSalariosCotizableTope { get; set; }

    public decimal SfsSalarioTope { get; set; }

    public decimal SfsDispersionCuidadoSalud { get; set; }

    public decimal SfsDispersionSubsidio { get; set; }

    public decimal SfsDispersionEstancias { get; set; }

    public decimal SfsDispersionComisionSisalril { get; set; }

    public decimal SfsCapitaAfiliado { get; set; }

    public decimal SfsCapitaAfiliadoAdicional { get; set; }

    public string? SfsPlanNumero { get; set; }

    public string SfsResoluciones { get; set; } = null!;

    public string? SfsNotasTecnicas { get; set; }

    public decimal SrlCategoriaRiesgoI { get; set; }

    public decimal SrlCategoriaRiesgoIi { get; set; }

    public decimal SrlCategoriaRiesgoIii { get; set; }

    public decimal SrlCategoriaRiesgoIv { get; set; }

    public decimal SrlSalarioCotizable { get; set; }

    public decimal SrlSalariosCotizableTope { get; set; }

    public decimal SrlSalarioTope { get; set; }

    public decimal SrlAporteEmpleador { get; set; }

    public decimal SrlAporteTrabajador { get; set; }

    public string SrlResoluciones { get; set; } = null!;

    public decimal SrlDispersionArl { get; set; }

    public decimal SrlDispersionSisalril { get; set; }

    public decimal SfsSubCapitaAfiliado { get; set; }

    public decimal FonamatCapitaAfiliado { get; set; }

    public short FinancieroCantidadSalario { get; set; }

    public decimal FinancieroPorcentajeExcesoGastoAmd { get; set; }

    public string FinancieroResoluciones { get; set; } = null!;

    public string FinancieroPublicacionEstados { get; set; } = null!;
}
