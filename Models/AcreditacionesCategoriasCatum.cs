using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con las categorías de acreditación a ser otorgada (Auditor, Promotor, Promotora, Firma Auditoria etc.),  su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesCategoriasCatum
{
    /// <summary>
    /// Número único que identifica la categoría de acreditación a ser otorgada (Auditor, Promotor, Promotora, Firma Auditoria etc.).
    /// </summary>
    public byte AcreditacionCategoriaNumero { get; set; }

    /// <summary>
    /// Descripción  de la categoría de acreditación a ser otorgada (Auditor, Promotor, Promotora, Firma Auditoria etc.).
    /// </summary>
    public string AcreditacionCategoriaDescripcion { get; set; } = null!;

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

    public virtual ICollection<AcreditacionesCategoriasClasesCatum> AcreditacionesCategoriasClasesCata { get; set; } = new List<AcreditacionesCategoriasClasesCatum>();

    public virtual ICollection<AcreditacionesEstadosCatum> AcreditacionesEstadosCata { get; set; } = new List<AcreditacionesEstadosCatum>();

    public virtual ICollection<AcreditacionesExamenesPeriodosTran> AcreditacionesExamenesPeriodosTrans { get; set; } = new List<AcreditacionesExamenesPeriodosTran>();

    public virtual ICollection<AcreditacionesPreguntasCatum> AcreditacionesPreguntasCata { get; set; } = new List<AcreditacionesPreguntasCatum>();

    public virtual ICollection<AcreditacionesSeguridadGruposCatum> AcreditacionesSeguridadGruposCata { get; set; } = new List<AcreditacionesSeguridadGruposCatum>();
}
