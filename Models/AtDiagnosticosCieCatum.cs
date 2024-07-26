using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtDiagnosticosCieCatum
{
    /// <summary>
    /// Código de diagnostico CIE para accidentes de transito.
    /// </summary>
    public string DiagnosticoCieCodigo { get; set; } = null!;

    /// <summary>
    /// Grupo especial de diagnostico para accidentes de transito.
    /// </summary>
    public string DiagnosticoCieGrupo { get; set; } = null!;

    /// <summary>
    /// Descripción del diagnostico CIE para accidentes de transito.
    /// </summary>
    public string DiagnosticoCieDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicacion del diagnostico CIE para accidentes de transito.
    /// </summary>
    public string DiagnosticoCieExplicacion { get; set; } = null!;

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

    public virtual ICollection<AtMaster> AtMasterDiagnosticoCieCodigoFinalNavigations { get; set; } = new List<AtMaster>();

    public virtual ICollection<AtMaster> AtMasterDiagnosticoCieCodigoInicialNavigations { get; set; } = new List<AtMaster>();

    public virtual AtDiagnosticosGruposCieCatum DiagnosticoCieGrupoNavigation { get; set; } = null!;
}
