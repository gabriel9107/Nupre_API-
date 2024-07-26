using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional, que contiene el resumen de los balances generales de las cuentas de la balanza de comprobación reportados por las ARS y la ARL,  su fuente de datos es el esquema 05 procesado por el Robot Simon.
/// </summary>
public partial class FinancierosBalanceGeneralDetalladoVistaHistorico
{
    /// <summary>
    /// Periodo (Año y Mes) correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public int SeguimientoPeriodo { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Es el número único asignado para identificar cuales Planes de Salud son del PDSS o son de los demás planes (Voluntarios, Complementarios, Especiales, etc.), esta columna actualmente solo se utiliza en los estados de resultados de los estados financieros.
    /// </summary>
    public byte PlanGrupoNumero { get; set; }

    /// <summary>
    /// Nombre de la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public string ArsNombre { get; set; } = null!;

    /// <summary>
    /// Código único que representa la calsificación de las ARS en Públicas, Privadas y Auto gestionada.
    /// </summary>
    public string ArsCategoriaCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción que clasifica las ARS en Públicas, Privadas y Auto gestionada.
    /// </summary>
    public string ArsCategoriaDescripcion { get; set; } = null!;

    /// <summary>
    /// Es la descripción que identifica cuales Planes de Salud son del PDSS o son de los demás planes (Voluntarios, Complementarios, Especiales, etc.), esta columna se utiliza en los estados de resultados de los estados financieros.
    /// </summary>
    public string PlanGrupoDescripcion { get; set; } = null!;

    /// <summary>
    /// Indicador de los estados financieros, a partir del balance de comprobación cargados en el esquema 5
    /// </summary>
    public decimal IngresoSalud { get; set; }

    /// <summary>
    /// Indicador de los estados financieros, a partir del balance de comprobación cargados en el esquema 5
    /// </summary>
    public decimal OtrosIngreso { get; set; }

    /// <summary>
    /// Indicador de los estados financieros, a partir del balance de comprobación cargados en el esquema 5
    /// </summary>
    public decimal GastoEnSalud { get; set; }

    /// <summary>
    /// Indicador de los estados financieros, a partir del balance de comprobación cargados en el esquema 5
    /// </summary>
    public decimal OtrosGastos { get; set; }

    /// <summary>
    /// Indicador de los estados financieros, a partir del balance de comprobación cargados en el esquema 5
    /// </summary>
    public decimal GastosGeneralesAdministrativos { get; set; }

    /// <summary>
    /// Indicador de los estados financieros, a partir del balance de comprobación cargados en el esquema 5
    /// </summary>
    public decimal OtrosIngresoGastos { get; set; }

    /// <summary>
    /// Indicador de los estados financieros, a partir del balance de comprobación cargados en el esquema 5
    /// </summary>
    public decimal ImpuestosReservas { get; set; }

    /// <summary>
    /// Indicador de los estados financieros, a partir del balance de comprobación cargados en el esquema 5
    /// </summary>
    public decimal BeneficioEjercicio { get; set; }

    /// <summary>
    /// Indicador de los estados financieros, a partir del balance de comprobación cargados en el esquema 5
    /// </summary>
    public decimal BeneficioSobreIngresoSalud { get; set; }

    /// <summary>
    /// Indicador de los estados financieros, a partir del balance de comprobación cargados en el esquema 5
    /// </summary>
    public decimal Siniestralidad { get; set; }

    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Indica si los montos de los estados financieros, a partir del balance de comprobación se publicarán detallados o no (S = Si, N = No).
    /// </summary>
    public string DetalladoMonto { get; set; } = null!;

    public DateTime RegistroFechaHistorico { get; set; }
}
