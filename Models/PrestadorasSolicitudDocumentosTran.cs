using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasSolicitudDocumentosTran
{
    public int SolicitudDocumentoSecuencia { get; set; }

    /// <summary>
    /// Número único de la solicitud de inclusión de PSS Institucional realizado por las ARS/ARL.
    /// </summary>
    public int PrestadoraSolicitudNumero { get; set; }

    public string DocumentoNombre { get; set; } = null!;

    public string DocumentoRuta { get; set; } = null!;

    public string? DocumentoExtension { get; set; }

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

    public virtual PrestadorasSolicitudTran PrestadoraSolicitudNumeroNavigation { get; set; } = null!;
}
