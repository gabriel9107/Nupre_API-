using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SrlComisionesMedicasMaster
{
    public byte ComisionMedicaNumero { get; set; }

    public string ComisionMedicaCodigo { get; set; } = null!;

    public string ComisionMedicaNombre { get; set; } = null!;

    public string ComisionMedicaDireccion { get; set; } = null!;

    public string ComisionMedicaTelefono { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<SrlCertificacionesAfiliadosTran> SrlCertificacionesAfiliadosTrans { get; set; } = new List<SrlCertificacionesAfiliadosTran>();

    public virtual ICollection<SrlComisionesMedicasRegionesCatum> SrlComisionesMedicasRegionesCata { get; set; } = new List<SrlComisionesMedicasRegionesCatum>();
}
