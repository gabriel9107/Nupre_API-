using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Tabla que contiene el catálogo con los detalles de los estados de cuentas para calcular los estados finaneros de la balanza de comprobación.
/// </summary>
public partial class FinancierosEstadosCuentasDetallesCatum
{
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
    /// Indica el orden en que se presentará  cuenta o resultado en los reporte financieros.
    /// </summary>
    public byte EstadoResultadoDetalleOrden { get; set; }

    /// <summary>
    /// Indica si un resultado en los reporte financieros es un titulo o cuenta de cálculo.
    /// </summary>
    public string? EstadoResultadoDetalleTipo { get; set; }

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

    public virtual FinancierosEstadosDetallesTipoCatum? EstadoResultadoDetalleTipoNavigation { get; set; }
}
