using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Tabla transaccional que contiene los estados financieros de las ARS, obtenido a partir de la Balanza de Comprobación.
/// </summary>
public partial class FinancierosEstadosTransHistorico
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Periodo (Año y Mes) correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public int SeguimientoPeriodo { get; set; }

    /// <summary>
    /// Es el número único de cada tipo de planes relacionados con los reportes de los estados financieros
    /// </summary>
    public byte PlanCuentaNumero { get; set; }

    /// <summary>
    /// Número único que identifica cada uno de los estados financieros.
    /// </summary>
    public byte EstadoFinancieroNumero { get; set; }

    /// <summary>
    /// Es el número único que identifica una cuenta o resultado en los reporte financieros.
    /// </summary>
    public byte EstadoResultadoNumero { get; set; }

    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaCodigo { get; set; }

    /// <summary>
    /// Nombre de la cuenta contable en el catálogo de cuentas.
    /// </summary>
    public string CuentaNombre { get; set; } = null!;

    /// <summary>
    /// Indica el orden en que se calculará  cuenta o resultado en los reporte financieros.
    /// </summary>
    public byte EstadoResultadoNivel { get; set; }

    /// <summary>
    /// Indica el orden en que se presentará  cuenta o resultado en los reporte financieros.
    /// </summary>
    public byte EstadoResultadoDetalleOrden { get; set; }

    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Es el balance actual que tiene la cuenta para el periodo reportado en el esquema 5, en el cual se informa la Balanza de comprobación.
    /// </summary>
    public decimal BalanceActual { get; set; }

    /// <summary>
    /// Indica si presentará en formato negrita una cuenta o resultado en los reporte financieros.
    /// </summary>
    public string EstadoResultadoNegrita { get; set; } = null!;

    /// <summary>
    /// Es el número único asignado para identificar cuales Planes de Salud son del PDSS o son de los demás planes (Voluntarios, Complementarios, Especiales, etc.), esta columna actualmente solo se utiliza en los estados de resultados de los estados financieros.
    /// </summary>
    public byte PlanGrupoNumero { get; set; }

    /// <summary>
    /// Tipifica las cuentas contables según las cuentas mayores.
    /// </summary>
    public byte CuentaTipoNumero { get; set; }

    /// <summary>
    /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFechaHistorico { get; set; }

    public string RegistroMotivoHistorico { get; set; } = null!;
}
