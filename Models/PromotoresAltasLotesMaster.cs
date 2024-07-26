using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PromotoresAltasLotesMaster
{
    public decimal LoteNumero { get; set; }

    public DateTime? LoteFecha { get; set; }

    public string? LoteNombreArchivo { get; set; }

    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;
}
