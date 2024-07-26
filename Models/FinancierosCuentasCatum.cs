using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los detalles del Catálogo de cuenta contables oficial para las ARS y la ARL, es la base de reporte del esquema 05, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class FinancierosCuentasCatum
{
    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaCodigo { get; set; }

    /// <summary>
    /// Nombre de la cuenta contable en el catálogo de cuentas.
    /// </summary>
    public string CuentaNombre { get; set; } = null!;

    /// <summary>
    /// Tipifica las cuentas contables según las cuentas mayores.
    /// </summary>
    public byte CuentaTipoNumero { get; set; }

    /// <summary>
    /// Código que representa el origen de la cuenta contable.
    /// </summary>
    public string CuentaOrigenCodigo { get; set; } = null!;

    /// <summary>
    /// Es código único  de la cuenta contable padre de cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public string CuentaControlCodigo { get; set; } = null!;

    /// <summary>
    /// Indica el nivel de la cuenta contable, a más bajo nivel  la cuenta tiene mayor nivel de agrupamiento.
    /// </summary>
    public byte CuentaNivel { get; set; }

    /// <summary>
    /// Indica si la cuenta contable puede recibir o no operaciones.
    /// </summary>
    public string CuentaMovimiento { get; set; } = null!;

    /// <summary>
    /// Indica si la cuenta debe ser reportada en el mes de enero con balance en cero en el esquema 5.
    /// </summary>
    public string CuentaEneroCero { get; set; } = null!;

    /// <summary>
    /// Indica si la cuenta debe ser reportada en el mes de enero con balance en cero en el esquema 5.
    /// </summary>
    public string CuentaBalanceCero { get; set; } = null!;

    public string CuentaValidaAfiliadosIngresos { get; set; } = null!;

    /// <summary>
    /// Periodo (Año y Mes) correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public int SeguimientoPeriodoCarga { get; set; }

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

    public virtual FinancierosCuentasOrigenCatum CuentaOrigenCodigoNavigation { get; set; } = null!;

    public virtual FinancierosCuentasTipoCatum CuentaTipoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<FinancierosBalanceComprobacionTran> FinancierosBalanceComprobacionTrans { get; set; } = new List<FinancierosBalanceComprobacionTran>();

    public virtual ICollection<FinancierosCuentasProporcionesCatum> FinancierosCuentasProporcionesCata { get; set; } = new List<FinancierosCuentasProporcionesCatum>();

    public virtual ICollection<SeguimientosEsquemas35ValidacionesCatum> SeguimientosEsquemas35ValidacionesCata { get; set; } = new List<SeguimientosEsquemas35ValidacionesCatum>();
}
