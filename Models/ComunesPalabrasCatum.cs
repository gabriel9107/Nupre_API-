using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ComunesPalabrasCatum
{
    public int PalabraNumero { get; set; }

    public string PalabraDetalle { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<ComunesPalabrasDiccionarioCatum> ComunesPalabrasDiccionarioCata { get; set; } = new List<ComunesPalabrasDiccionarioCatum>();
}
