using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los un requerimiento (Documento, Identificación, otros), presentado por una personas  para un proceso de acreditación, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesPersonasRequerimientosTran
{
    /// <summary>
    /// Secuencia única asignada a cada persona en el sistema de acreditación.
    /// </summary>
    public long PersonaNss { get; set; }

    /// <summary>
    /// Número único que identifica el requerimiento (Documento, Identificación, otros), que deben presentar las personas o entidades para un proceso de acreditación.
    /// </summary>
    public byte RequerimientoNumero { get; set; }

    /// <summary>
    /// Es el código único que representa el documento dentro del sistema.
    /// </summary>
    public string DocumentoCodigo { get; set; } = null!;

    /// <summary>
    /// Observación de un requerimiento (Documento, Identificación, otros), presentado por una persona o entidad  para un proceso de acreditación.
    /// </summary>
    public string RequerimientoObservacion { get; set; } = null!;

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

    public virtual AcreditacionesPersonasMaster PersonaNssNavigation { get; set; } = null!;

    public virtual AcreditacionesRequerimientosCatum RequerimientoNumeroNavigation { get; set; } = null!;
}
