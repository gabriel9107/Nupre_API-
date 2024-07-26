using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ComunesCie10DiagnosticosGruposCatum
{
    public string Cie10DiagnosticoGrupoCodigo { get; set; } = null!;

    public string Cie10DiagnosticoGrupoDescripcion { get; set; } = null!;

    public string Cie10DiagnosticoCapitulo { get; set; } = null!;

    public string Cie10DiagnosticoCapituloDescripcion { get; set; } = null!;

    public string Cie10DiagnosticoClasificacionCodigo { get; set; } = null!;

    public string Cie10DiagnosticoClasificacionDescripcion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<ComunesCie10DiagnosticosCatum> ComunesCie10DiagnosticosCata { get; set; } = new List<ComunesCie10DiagnosticosCatum>();
}
