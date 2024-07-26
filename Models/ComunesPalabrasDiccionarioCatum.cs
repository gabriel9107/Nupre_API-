using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ComunesPalabrasDiccionarioCatum
{
    public string PalabraDetalle { get; set; } = null!;

    public int PalabraNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ComunesPalabrasCatum PalabraNumeroNavigation { get; set; } = null!;
}
