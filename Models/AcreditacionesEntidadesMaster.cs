using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un  maestro con los datos de las entidades  que participan en los procesos de acreditación, sistema acreditación,  su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesEntidadesMaster
{
    /// <summary>
    /// Número único que identifica cada entidad en los procesos de acreditación.
    /// </summary>
    public short EntidadNumero { get; set; }

    /// <summary>
    /// Es el número único que le asigna la Tesorería de la Seguridad Social a cada uno de los empleadores que se registran en dicha institución.    
    /// </summary>
    public int EmpleadorRegistroPatronal { get; set; }

    /// <summary>
    /// Fecha en la que se aprobó una entidad en los procesos de acreditación.
    /// </summary>
    public DateTime EntidadFechaAcreditacion { get; set; }

    /// <summary>
    /// Número único que identifica la categoría de acreditación a ser otorgada (Auditor, Promotor, Promotora, Firma Auditoria etc.).
    /// </summary>
    public byte AcreditacionCategoriaNumero { get; set; }

    /// <summary>
    /// Número único que identifica que quien se está acreditando es una persona o entidad.
    /// </summary>
    public byte AcreditacionClaseNumero { get; set; }

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

    public virtual AcreditacionesCategoriasClasesCatum AcreditacionC { get; set; } = null!;

    public virtual ICollection<AcreditacionesEntidadesPersonasTran> AcreditacionesEntidadesPersonasTrans { get; set; } = new List<AcreditacionesEntidadesPersonasTran>();

    public virtual ICollection<AcreditacionesEntidadesRequerimientosTran> AcreditacionesEntidadesRequerimientosTrans { get; set; } = new List<AcreditacionesEntidadesRequerimientosTran>();

    public virtual TssEmpleadoresMaster EmpleadorRegistroPatronalNavigation { get; set; } = null!;
}
