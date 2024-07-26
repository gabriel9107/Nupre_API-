using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional con los detalles de los salario mínimos por sectores salariales según  periodo de vigencia, su fuente de datos las vistas  publicadas por TSS.
/// </summary>
public partial class TssSectoresSalarialesEscalaTran
{
    /// <summary>
    /// Número único que identifica un sector salarial para los empleadores registrados en la TSS.
    /// </summary>
    public byte SectorSalarialNumero { get; set; }

    /// <summary>
    /// Es la fecha de inicio de vigencia de un salario mínimo de un sector salarial para un periodo de aplicación en el sistema dominicano de seguridad social SDSS.
    /// </summary>
    public int SectorSalarialEscalaFechaInicio { get; set; }

    /// <summary>
    /// Es la fecha de finalización de la vigencia de un salario mínimo de un sector salarial para un periodo de aplicación en el sistema dominicano de seguridad social SDSS.
    /// </summary>
    public int SectorSalarialEscalaFechaFin { get; set; }

    /// <summary>
    /// Es el salario mínimo de un sector salarial para un periodo de aplicación en el sistema dominicano de seguridad social SDSS.
    /// </summary>
    public decimal SectorSalarialEscalaSalarioMinimo { get; set; }

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

    public virtual TssSectoresSalarialesCatum SectorSalarialNumeroNavigation { get; set; } = null!;
}
