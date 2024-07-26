using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de los tipos de inamovilidad de documentos (cédulas),  según codificación de la JCE, su fuente de datos son las vista que nos publica la TSS.
/// </summary>
public partial class TssInhabilidadJceTipoCatum
{
    /// <summary>
    /// Es el número único que representa la causa de inhabilidad de un documento de identificación (Generalmente Cédula) la cual tiene algún impedimento por la JCE y registrado en el padrón de ciudadanos de la TSS. Dicho número se repite según el tipo de causa.
    /// </summary>
    public short CausaInhabilidadNumero { get; set; }

    /// <summary>
    /// Tipo de causa de inhabilidad de un documento de identificación (Generalmente Cédula) la cual tiene algún impedimento por la JCE y registrado en el padrón de ciudadanos de la TSS. Dicho número se repite según el tipo de causa.
    /// </summary>
    public string CausaTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Es la descripción del tipo  de causa de inhabilidad de un documento de identificación (Generalmente Cédula) la cual tiene algún impedimento por la JCE y registrado en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string CausaTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Es la descripción de la causa de inhabilidad de un documento de identificación (Generalmente Cédula) la cual tiene algún impedimento por la JCE y registrado en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string CausaInhabilidadDescripcion { get; set; } = null!;

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
