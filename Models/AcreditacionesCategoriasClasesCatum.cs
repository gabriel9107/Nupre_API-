using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un  catálogo donde se conjugan las clases y categorías para el sistema acreditación,  su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesCategoriasClasesCatum
{
    /// <summary>
    /// Número único que identifica la categoría de acreditación a ser otorgada (Auditor, Promotor, Promotora, Firma Auditoria etc.).
    /// </summary>
    public byte AcreditacionCategoriaNumero { get; set; }

    /// <summary>
    /// Número único que identifica que quien se está acreditando es una persona o entidad.
    /// </summary>
    public byte AcreditacionClaseNumero { get; set; }

    /// <summary>
    /// Es la descripción de la conjugación de una clase y categoría en el proceso de acreditación.
    /// </summary>
    public string AcreditacionCategoriaClaseDescripcion { get; set; } = null!;

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

    public virtual AcreditacionesCategoriasCatum AcreditacionCategoriaNumeroNavigation { get; set; } = null!;

    public virtual AcreditacionesClaseCatum AcreditacionClaseNumeroNavigation { get; set; } = null!;

    public virtual ICollection<AcreditacionesEntidadesMaster> AcreditacionesEntidadesMasters { get; set; } = new List<AcreditacionesEntidadesMaster>();

    public virtual ICollection<AcreditacionesPersonasMaster> AcreditacionesPersonasMasters { get; set; } = new List<AcreditacionesPersonasMaster>();

    public virtual ICollection<AcreditacionesRequerimientosCatum> AcreditacionesRequerimientosCata { get; set; } = new List<AcreditacionesRequerimientosCatum>();
}
