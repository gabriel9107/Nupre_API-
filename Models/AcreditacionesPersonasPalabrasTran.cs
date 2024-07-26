using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AcreditacionesPersonasPalabrasTran
{
    public long PersonaNss { get; set; }

    public string PalabraDetalle { get; set; } = null!;

    public int PalabraNumero { get; set; }
}
