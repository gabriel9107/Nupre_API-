using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SrlComisionesMedicasRegionesCatum
{
    public byte ComisionMedicaNumero { get; set; }

    public byte RegionSaludNumero { get; set; }

    public string ComisionMedicaFusionada { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual SrlComisionesMedicasMaster ComisionMedicaNumeroNavigation { get; set; } = null!;
}
