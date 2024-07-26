using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosOrigenesCatum
{
    /// <summary>
    /// Número que indica el origen del caso o servicio.
    /// </summary>
    public byte CasoOrigenNumero { get; set; }

    /// <summary>
    /// Nombre del origen del caso o servicio.
    /// </summary>
    public string CasoOrigenNombre { get; set; } = null!;

    /// <summary>
    /// Indicador de si puede concluir o no el caso (S = SI, N = NO).
    /// </summary>
    public string CasoOrigenPuedeConcluir { get; set; } = null!;

    /// <summary>
    /// A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<CasosMaster> CasosMasters { get; set; } = new List<CasosMaster>();
}
