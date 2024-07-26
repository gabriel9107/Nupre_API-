using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PromotoresAltasLotesTran
{
    public decimal LoteNumero { get; set; }

    public string PromotorCedula { get; set; } = null!;

    public DateTime? PromotorLoteFecha { get; set; }

    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;
}
