using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los grados de severidad de las lesiones que puede recibir  un trabajador,  utilizado por la ARL para reportar los detalles de los accidentes de trabajos, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ArlLesionesGradosCatum
{
    /// <summary>
    /// Código valido para reportar el tipo de lesión de acuerdo al accidente reportado.
    /// </summary>
    public byte LesionGradoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de lesión de acuerdo al accidente reportado.
    /// </summary>
    public string LesionGradoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación de la descripción del tipo de lesión de acuerdo al accidente reportado.
    /// </summary>
    public string LesionGradoExplicacion { get; set; } = null!;

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
