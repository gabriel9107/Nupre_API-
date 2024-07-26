using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class MedicamentosPalabrasSiCatum
{
    public string MedicamentoPalabra { get; set; } = null!;

    public int CoberturaNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
