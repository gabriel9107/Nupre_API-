using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un  catálogo donde se registran los detalles de los niveles académicos que puede presentar una persona, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesNivelesAcademicosCatum
{
    /// <summary>
    /// Número único que identifica el nivel académico de la persona.
    /// </summary>
    public byte NivelAcademicoNumero { get; set; }

    /// <summary>
    /// Descripción del nivel académico de la persona.
    /// </summary>
    public string NivelAcademicoDescripcion { get; set; } = null!;

    /// <summary>
    /// Este campo es temporal hasta se realice al pase de promotores a la BDD Simon.
    /// </summary>
    public string NivelAcademicoPromotorTmp { get; set; } = null!;

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

    public virtual ICollection<AcreditacionesPersonasMaster> AcreditacionesPersonasMasters { get; set; } = new List<AcreditacionesPersonasMaster>();

    public virtual ICollection<AuditoresMaster> AuditoresMasters { get; set; } = new List<AuditoresMaster>();

    public virtual ICollection<PromotoresMaster> PromotoresMasters { get; set; } = new List<PromotoresMaster>();
}
