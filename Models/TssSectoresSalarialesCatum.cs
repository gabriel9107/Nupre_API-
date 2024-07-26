using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los sectores salariales que establecen el salario mínimo para los empleadores, su fuente de datos la vista de publicadas por TSS.
/// </summary>
public partial class TssSectoresSalarialesCatum
{
    /// <summary>
    /// Número único que identifica un sector salarial para los empleadores registrados en la TSS.
    /// </summary>
    public byte SectorSalarialNumero { get; set; }

    /// <summary>
    /// Descripción del sector salarial para los empleadores registrados en la TSS, para establecer el salario mínimo sectorial.
    /// </summary>
    public string SectorSalarialDescripcion { get; set; } = null!;

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

    public virtual ICollection<TssSectoresSalarialesEscalaTran> TssSectoresSalarialesEscalaTrans { get; set; } = new List<TssSectoresSalarialesEscalaTran>();
}
