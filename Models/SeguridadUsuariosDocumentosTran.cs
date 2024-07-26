using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los documentos asociados a los registros y cambios de los usuarios registrados para el uso de los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguridadUsuariosDocumentosTran
{
    /// <summary>
    /// Nombre de usuario de la persona registrado como usuario en el sistema.
    /// </summary>
    public string UsuarioUsuarioNombre { get; set; } = null!;

    /// <summary>
    /// Es el código único que representa el documento dentro del sistema.
    /// </summary>
    public string DocumentoCodigo { get; set; } = null!;

    /// <summary>
    /// Observación sobre el documento relacionado con el usuario.
    /// </summary>
    public string DocumentoObservacion { get; set; } = null!;

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

    public virtual ComunesDocumentosMaster DocumentoCodigoNavigation { get; set; } = null!;

    public virtual SeguridadUsuariosMaster UsuarioUsuarioNombreNavigation { get; set; } = null!;
}
