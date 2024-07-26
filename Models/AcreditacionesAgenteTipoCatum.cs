using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los tipo de agentes promotores  para el sistema de acreditación,  su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesAgenteTipoCatum
{
    /// <summary>
    /// Número único que identifica el tipo de agente promotor (Local, Nacional).
    /// </summary>
    public byte AgenteTipoNumero { get; set; }

    /// <summary>
    /// Descripción  del tipo de agente promotor (Local, Nacional).
    /// </summary>
    public string AgenteTipoDescripcion { get; set; } = null!;

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
}
