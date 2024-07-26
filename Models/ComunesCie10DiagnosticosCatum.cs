using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ComunesCie10DiagnosticosCatum
{
    public string Cie10DiagnosticoCodigo { get; set; } = null!;

    public string Cie10DiagnosticoGrupoCodigo { get; set; } = null!;

    public string Cie10DiagnosticoDescripcion { get; set; } = null!;

    public string Cie10DiagnosticoCodigoSimon { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ComunesCie10DiagnosticosGruposCatum Cie10DiagnosticoGrupoCodigoNavigation { get; set; } = null!;

    public virtual ICollection<EpisodiosDiagnosticosSubsidiadosTran> EpisodiosDiagnosticosSubsidiadosTrans { get; set; } = new List<EpisodiosDiagnosticosSubsidiadosTran>();
}
