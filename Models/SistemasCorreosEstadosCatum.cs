using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasCorreosEstadosCatum
{
    public string CorreoEstadoCodigo { get; set; } = null!;

    public string CorreoEstadoDescripcion { get; set; } = null!;

    public string CorreoEstadoExplicacion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<SistemasCorreosTran> SistemasCorreosTrans { get; set; } = new List<SistemasCorreosTran>();
}
