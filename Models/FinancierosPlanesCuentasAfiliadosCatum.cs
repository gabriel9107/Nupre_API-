using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Tabla catálogo que contiene el calculo por cartera de afiliados de cada tipo de planes relacionados con los reportes de los estados financieros.
/// </summary>
public partial class FinancierosPlanesCuentasAfiliadosCatum
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Es el año y mes correspondiente al período de factura,  este período es en él se factura (Generación de NP) a los empleadores basado en sus nóminas depositadas en las TSS.
    /// </summary>
    public int PeriodoFactura { get; set; }

    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaCodigoIngreso { get; set; }

    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaCodigo { get; set; }

    /// <summary>
    /// Número de Afiliados Mínimos a reportar en Cartera.
    /// </summary>
    public int CarteraAfiliadosMiimo { get; set; }

    /// <summary>
    /// Número Promedio de Afiliados Mínimos a reportar en Cartera.
    /// </summary>
    public int CarteraAfiliadosPromedio { get; set; }

    /// <summary>
    /// Número Promedio de Afiliados Mínimos a reportar en Cartera.
    /// </summary>
    public int CarteraAfiliados { get; set; }

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
}
