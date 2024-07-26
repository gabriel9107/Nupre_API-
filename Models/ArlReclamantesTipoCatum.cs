using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene el tipo de reclamante,  utilizado por la ARL para reportar los detalles de las notificaciones de las reclamaciones, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ArlReclamantesTipoCatum
{
    /// <summary>
    /// Código válido para reportar el tipo de reclamante que realizó la reclamación a la ARLSS.
    /// </summary>
    public byte ReclamanteTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de reclamante.
    /// </summary>
    public string ReclamanteTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación del tipo de reclamante.
    /// </summary>
    public string ReclamanteTipoExplicacion { get; set; } = null!;

    /// <summary>
    /// Indica dependiendo del tipo de reclamante, el documento será valido.
    /// </summary>
    public string ReclamanteTipoDocumentoValido { get; set; } = null!;

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
