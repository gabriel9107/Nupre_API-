using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las relaciones entre las personas y las entidades para los procesos de acreditación, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesEntidadesPersonasTran
{
    /// <summary>
    /// Número único que identifica cada entidad en los procesos de acreditación.
    /// </summary>
    public short EntidadNumero { get; set; }

    public long PersonaNss { get; set; }

    /// <summary>
    /// Indica si la persona es o no  la representante de la evaluación de la entidad en el proceso de acreditación.
    /// </summary>
    public string PersonaRepresentante { get; set; } = null!;

    public DateTime PersonaFechaAlta { get; set; }

    public DateTime? PersonaFechaBaja { get; set; }

    public string EntidadObservacion { get; set; } = null!;

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

    public virtual AcreditacionesEntidadesMaster EntidadNumeroNavigation { get; set; } = null!;

    public virtual AcreditacionesPersonasMaster PersonaNssNavigation { get; set; } = null!;
}
