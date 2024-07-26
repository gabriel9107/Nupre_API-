using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un  catálogo donde se registran los requerimientos que deben presentar las personas o entidades para un proceso de acreditación, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesRequerimientosCatum
{
    /// <summary>
    /// Número único que identifica el requerimiento (Documento, Identificación, otros), que deben presentar las personas o entidades para un proceso de acreditación.
    /// </summary>
    public byte RequerimientoNumero { get; set; }

    /// <summary>
    /// Número único que identifica la categoría de acreditación a ser otorgada (Auditor, Promotor, Promotora, Firma Auditoria etc.).
    /// </summary>
    public byte AcreditacionCategoriaNumero { get; set; }

    /// <summary>
    /// Número único que identifica que quien se está acreditando es una persona o entidad.
    /// </summary>
    public byte AcreditacionClaseNumero { get; set; }

    /// <summary>
    /// Descripción del requerimiento (Documento, Identificación, otros), que deben presentar las personas o entidades para un proceso de acreditación.
    /// </summary>
    public string RequerimientoDescripcion { get; set; } = null!;

    /// <summary>
    /// Número de orden en que debe aparecer los requerimiento para un personas o entidades, en relación a la categoría de acreditación en un proceso de acreditación.
    /// </summary>
    public byte RequerimientoOrden { get; set; }

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

    public virtual ICollection<AcreditacionesEntidadesRequerimientosTran> AcreditacionesEntidadesRequerimientosTrans { get; set; } = new List<AcreditacionesEntidadesRequerimientosTran>();

    public virtual ICollection<AcreditacionesPersonasRequerimientosTran> AcreditacionesPersonasRequerimientosTrans { get; set; } = new List<AcreditacionesPersonasRequerimientosTran>();
}
