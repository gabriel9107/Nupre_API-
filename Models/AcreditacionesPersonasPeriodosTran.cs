using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las personas para un período especifico de  exámenes en los procesos de acreditación, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesPersonasPeriodosTran
{
    /// <summary>
    /// Número único que identifica un período (Rango de fecha) en el cual se procedió a habilitar la toma de exámenes en las actividades de evaluación de los procesos de acreditación.
    /// </summary>
    public short PeriodoNumero { get; set; }

    /// <summary>
    /// Secuencia única asignada a cada persona en el sistema de acreditación.
    /// </summary>
    public long PersonaNss { get; set; }

    /// <summary>
    /// Número único que identifica el proceso con el cual fue registrada una persona en un periodo de exámenes de evaluación para la acreditación en un proceso de acreditación.
    /// </summary>
    public byte ProcesoNumero { get; set; }

    /// <summary>
    /// Usuario único generado  para cada usuario para un período de exámenes.
    /// </summary>
    public string PersonaPeriodoUsuario { get; set; } = null!;

    /// <summary>
    /// Calve única generada para cada usuario para un período de exámenes.
    /// </summary>
    public string PersonaPeriodoClave { get; set; } = null!;

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

    public virtual ICollection<AcreditacionesExamenesTran> AcreditacionesExamenesTrans { get; set; } = new List<AcreditacionesExamenesTran>();

    public virtual AcreditacionesExamenesPeriodosTran PeriodoNumeroNavigation { get; set; } = null!;

    public virtual AcreditacionesPersonasMaster PersonaNssNavigation { get; set; } = null!;

    public virtual AcreditacionesProcesoCatum ProcesoNumeroNavigation { get; set; } = null!;
}
