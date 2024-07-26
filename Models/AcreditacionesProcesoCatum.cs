using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un  catálogo donde se registran los diferentes procesos con los cuales se registran las personas  en los periodos de exámenes de evaluación para la acreditación en un proceso de acreditación.
/// </summary>
public partial class AcreditacionesProcesoCatum
{
    /// <summary>
    /// Número único que identifica el proceso con el cual fue registrada una persona en un periodo de exámenes de evaluación para la acreditación en un proceso de acreditación.
    /// </summary>
    public byte ProcesoNumero { get; set; }

    /// <summary>
    /// Descripción del proceso con el cual fue registrada una persona en un periodo de exámenes de evaluación para la acreditación en un proceso de acreditación.
    /// </summary>
    public string ProcesoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación de la descripción del proceso con el cual fue registrada una persona en un periodo de exámenes de evaluación para la acreditación en un proceso de acreditación.
    /// </summary>
    public string ProcesoExplicacion { get; set; } = null!;

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

    public virtual ICollection<AcreditacionesPersonasPeriodosTran> AcreditacionesPersonasPeriodosTrans { get; set; } = new List<AcreditacionesPersonasPeriodosTran>();
}
