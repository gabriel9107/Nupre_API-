using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los tipo de documento con lo que se registran  los afiliados a planes voluntarios de las ARS, Su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AfiliadosDocumentosTipoCatum
{
    /// <summary>
    /// Número único del tipo de documento de identificación personal con el cual se registro el afiliado en la ARS para un Plan de Servicios de Salud (PDSS, Voluntarios, Complementario, Especial, etc.).
    /// </summary>
    public byte DocumentoTipoNumero { get; set; }

    /// <summary>
    /// Es la descripción  del tipo de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) para los casos requeridos de las personas registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string DocumentoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del tipo de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) para los casos requeridos de las personas registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string DocumentoTipoExplicacion { get; set; } = null!;

    /// <summary>
    /// Indica para el tipo de documento de identificación personal, para su registro de afiliación, si aplica o no para un afiliado Titular.
    /// </summary>
    public string DocumentoTipoTitulares { get; set; } = null!;

    /// <summary>
    /// Indica para el tipo de documento de identificación personal, para su registro de afiliación, si aplica o no para un afiliado Dependiente.
    /// </summary>
    public string DocumentoTipoDependientes { get; set; } = null!;

    /// <summary>
    /// Es el código que identifica el tipo de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) para los casos requeridos de las personas registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string DocumentoTipoCodigo { get; set; } = null!;

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

    public virtual ICollection<AfiliadosDependientesPlanesVoluntariosTran> AfiliadosDependientesPlanesVoluntariosTrans { get; set; } = new List<AfiliadosDependientesPlanesVoluntariosTran>();

    public virtual TssDocumentoTipoCatum DocumentoTipoCodigoNavigation { get; set; } = null!;
}
