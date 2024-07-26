using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasCorreosPlantillasCatum
{
    public byte CorreoPlantillaNumero { get; set; }

    public string CorreoPlantillaDescripcion { get; set; } = null!;

    public string CorreoPlantillaExplicacion { get; set; } = null!;

    public string CorreoPlantillaEnviarCc { get; set; } = null!;

    public string CorreoPlantillaEnviarCco { get; set; } = null!;

    public string CorreoPlantillaAsunto { get; set; } = null!;

    public string CorreoPlantillaCuerpo { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<SistemasAlertasMaster> SistemasAlertasMasters { get; set; } = new List<SistemasAlertasMaster>();

    public virtual ICollection<SistemasCorreosTran> SistemasCorreosTrans { get; set; } = new List<SistemasCorreosTran>();
}
