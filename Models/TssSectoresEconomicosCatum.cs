using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los sectores económicos de los empleadores, su fuente de datos la vista de publicadas por TSS.
/// </summary>
public partial class TssSectoresEconomicosCatum
{
    /// <summary>
    /// Número único del sector económico según clasificación de la TSS para los empleadores (Gobierno, Salud, ONG, Zona Franca, etc.).
    /// </summary>
    public byte SectorEconomicoNumero { get; set; }

    /// <summary>
    /// Descripción del sector económico según clasificación de la TSS para los empleadores (Gobierno, Salud, ONG, Zona Franca, etc.).
    /// </summary>
    public string SectorEconomicoDescripcion { get; set; } = null!;

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
