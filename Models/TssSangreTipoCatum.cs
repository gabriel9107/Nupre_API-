using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de los tipos de sangres,  según codificación de la JCE, su fuente de datos son las vista que nos publica la TSS.
/// </summary>
public partial class TssSangreTipoCatum
{
    /// <summary>
    /// Es el código único que representa el tipo de sangre de la persona  registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public byte SangreTipoNumero { get; set; }

    /// <summary>
    /// Es la descripción del tipo de sangre de la persona  registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string SangreTipoDescripcion { get; set; } = null!;

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
