using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasInstitucionalesPalabrasTran
{
    public int PrestadoraNumero { get; set; }

    public string PalabraDetalle { get; set; } = null!;

    public int? PalabraNumero { get; set; }
}
