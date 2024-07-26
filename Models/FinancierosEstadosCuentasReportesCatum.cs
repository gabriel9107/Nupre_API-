using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Tabla que contiene el catálogo con los reportes de los estados de cuentas para calcular los estados finaneros de la balanza de comprobación.
/// </summary>
public partial class FinancierosEstadosCuentasReportesCatum
{
    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long? CuentaCodigo { get; set; }

    /// <summary>
    /// Es el número único de cada tipo de planes relacionados con los reportes de los estados financieros
    /// </summary>
    public byte? PlanCuentaNumero { get; set; }

    /// <summary>
    /// Nombre de la cuenta contable en el catálogo de cuentas.
    /// </summary>
    public string? CuentaNombre { get; set; }

    /// <summary>
    /// Descripción del tipo de las cuentas contables en el catálogo de cuentas según las cuentas mayores.
    /// </summary>
    public string? CuentaTipo { get; set; }

    /// <summary>
    /// Código que representa el origen de la cuenta contable.
    /// </summary>
    public string? CuentaOrigen { get; set; }

    /// <summary>
    /// Es código único  de la cuenta contable padre de cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public string? CuentaControlNumero { get; set; }

    /// <summary>
    /// Indica el orden en que se presentará  cuenta o resultado en los reporte financieros.
    /// </summary>
    public int? CuentaOrden { get; set; }

    /// <summary>
    /// Indica el nivel de la cuenta contable, a más bajo nivel  la cuenta tiene mayor nivel de agrupamiento.
    /// </summary>
    public int? CuentaNivel { get; set; }

    /// <summary>
    /// Indica si la cuenta contable puede recibir o no operaciones.
    /// </summary>
    public string? CuentaMovimiento { get; set; }

    /// <summary>
    /// Indica si la cuenta o resultado se utilizará para el consolidado general de los reportes financieros.
    /// </summary>
    public string? CuentaGeneral { get; set; }

    /// <summary>
    /// Indica si la cuenta o resultado se utilizara para el consolidado general de los reporte financieros.
    /// </summary>
    public string? ConsolidadoGeneral { get; set; }

    /// <summary>
    /// Indica si la cuenta o resultado se utilizara para el consolidado general de los reporte financieros.
    /// </summary>
    public string? CuentaConsolidadoGeneral { get; set; }
}
