using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los tipo de documento con lo que se registran  los ciudadanos del SDS, su fuente directa de datos son las actualización es la TSS.
/// </summary>
public partial class TssDocumentoTipoCatum
{
    /// <summary>
    /// Es el código que identifica el tipo de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) para los casos requeridos de las personas registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string DocumentoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Es la descripción  del tipo de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) para los casos requeridos de las personas registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string DocumentoTipoDescripcion { get; set; } = null!;

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

    public virtual ICollection<AfiliadosDocumentosTipoCatum> AfiliadosDocumentosTipoCata { get; set; } = new List<AfiliadosDocumentosTipoCatum>();
}
