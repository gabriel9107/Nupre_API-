using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los estados de procesos de las visitas de evaluación realizadas a las PSS, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class IndicadoresPssVisitasEstadoCatum
{
    /// <summary>
    /// Número único que identifica el estado del proceso de captura de datos del formulario de visitas a las PSS.
    /// </summary>
    public byte VisitaEstadoNumero { get; set; }

    /// <summary>
    /// Es el código único que identifica el estado del proceso de captura de datos del formulario de visitas a las PSS.
    /// </summary>
    public string VisitaEstadoCodigo { get; set; } = null!;

    /// <summary>
    /// Es la descripción del código único que identifica el estado del proceso de captura de datos del formulario de visitas a las PSS.
    /// </summary>
    public string VisitaEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Es una breve explicación de la descripción que identifica el estado del proceso de captura de datos del formulario de visitas a las PSS.
    /// </summary>
    public string VisitaEstadoExplicacion { get; set; } = null!;

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

    public virtual ICollection<IndicadoresPssVisitasMaster> IndicadoresPssVisitasMasters { get; set; } = new List<IndicadoresPssVisitasMaster>();
}
