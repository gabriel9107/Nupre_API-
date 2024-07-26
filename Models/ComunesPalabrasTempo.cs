using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ComunesPalabrasTempo
{
    public string PalabraDetalle { get; set; } = null!;

    public int PalabraSecuencia { get; set; }

    public string PalabraAplica { get; set; } = null!;

    public int PalabraSinomimo { get; set; }

    public int PalabraNumero { get; set; }
}
