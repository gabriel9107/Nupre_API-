using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtDiagnosticosGruposCieCatum
{
    /// <summary>
    /// Grupo al que corresponde el diagnostico CIE por accidente de transito.
    /// </summary>
    public string DiagnosticoCieGrupo { get; set; } = null!;

    /// <summary>
    /// Código CIE del diagnostico por accidente de transito.
    /// </summary>
    public string DiagnosticoCieCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del grupo del código CIE por accidente de transito.
    /// </summary>
    public string DiagnosticoCieGrupoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del grupo del código CIE por accidente de transito.
    /// </summary>
    public string DiagnosticoCieGrupoExplicacion { get; set; } = null!;

    /// <summary>
    /// Estado. A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del Usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de Registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<AtDiagnosticosCieCatum> AtDiagnosticosCieCata { get; set; } = new List<AtDiagnosticosCieCatum>();
}
