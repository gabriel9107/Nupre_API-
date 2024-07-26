using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class MedicamentosCoberturasCataBk12062018
{
    public long MedicamentoSecuencia { get; set; }

    public short CoberturaNumero { get; set; }

    public string? CoberturaDescripcion { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
