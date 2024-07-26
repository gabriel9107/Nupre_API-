using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con las entidades recaudadoras (Bancos y Asociaciones de ahorro, etc.) con la que se relacionan las cuenta de los empleadores, su fuente de datos la vista de publicadas por TSS.
/// </summary>
public partial class TssEntidadesRecaudadorasCatum
{
    /// <summary>
    /// Número único que identifica a cada entidad recaudadora en el SUIR TSS.
    /// </summary>
    public byte EntidadRecaudadoraNumero { get; set; }

    /// <summary>
    /// Nombre de la entidad recaudadora en el SUIR TSS.
    /// </summary>
    public string EntidadRecaudadoraNombre { get; set; } = null!;

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
