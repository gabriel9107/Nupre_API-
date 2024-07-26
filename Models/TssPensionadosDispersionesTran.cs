using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssPensionadosDispersionesTran
{
    /// <summary>
    /// Número de carnet de cada pensionado dentro de los procesos de afiliación y dispersión del Plan Especial Transitorio para Pensionadas del Ministerio de Hacienda.
    /// </summary>
    public int PensionadoNumero { get; set; }

    /// <summary>
    /// Es el año y mes correspondiente al período de factura,  este período es en él se factura (Generación de NP) a los empleadores basado en sus nóminas depositadas en las TSS.
    /// </summary>
    public int PeriodoFactura { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Monto Dispersado por el o los afiliados a la ARS/ARL.
    /// </summary>
    public decimal DispersionMonto { get; set; }

    /// <summary>
    /// Identifica los casos de afiliados pensionados que están como candidatos para la dispersión de un periodo específico y fueron o no dispersados, esta columna podrá contener los caracteres  (S/N) según se disperse o no por el o los  pensionado (s).
    /// </summary>
    public string DispersionRegistroDispersado { get; set; } = null!;

    /// <summary>
    /// Fecha en que la TSS realizo el registro.
    /// </summary>
    public DateTime DispersionFechaRegistroTss { get; set; }

    /// <summary>
    /// Fecha de la dispersión de los capitas a las ARS/ARL.
    /// </summary>
    public DateTime DispersionFecha { get; set; }

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

    public virtual TssPensionadosMaster PensionadoNumeroNavigation { get; set; } = null!;
}
