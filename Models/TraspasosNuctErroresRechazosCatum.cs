using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipos de errores de validación de los traspasos, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosNuctErroresRechazosCatum
{
    /// <summary>
    /// Número único del error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema o de la solicitud de un traspaso.
    /// </summary>
    public byte ErrorNumero { get; set; }

    /// <summary>
    /// Descripción del error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema o de la solicitud de un traspaso.
    /// </summary>
    public string ErrorDescripcion { get; set; } = null!;

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

    public virtual ICollection<TraspasosNuctErroresRechazosTran> TraspasosNuctErroresRechazosTrans { get; set; } = new List<TraspasosNuctErroresRechazosTran>();
}
