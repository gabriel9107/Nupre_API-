using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosDocumentosTran
{
    /// <summary>
    /// Número que identifica el caso generado mediante una solicitud ante una queja o reclamo por parte de los ciudadanos.
    /// </summary>
    public int CasoNumero { get; set; }

    /// <summary>
    /// Es el código único que representa el documento dentro del sistema.
    /// </summary>
    public string DocumentoCodigo { get; set; } = null!;

    /// <summary>
    /// Comentario u observación acerca del documento relacionado al caso.
    /// </summary>
    public string? CasoDocumentoComentario { get; set; }

    /// <summary>
    /// A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual CasosMaster CasoNumeroNavigation { get; set; } = null!;

    public virtual ComunesDocumentosMaster DocumentoCodigoNavigation { get; set; } = null!;
}
