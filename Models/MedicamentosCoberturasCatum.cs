using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class MedicamentosCoberturasCatum
{
    public long MedicamentoSecuencia { get; set; }

    /// <summary>
    /// Numero único de cobertura que representa un  insumo, procedimiento médico, material, fármaco,  servicio  general que fue o puede ser prestado.
    /// </summary>
    public short CoberturaNumero { get; set; }

    public string? CoberturaDescripcion { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
