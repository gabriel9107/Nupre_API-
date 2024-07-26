using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosCorreosPlantillasCatum
{
    /// <summary>
    /// Número que identifica la plantilla.
    /// </summary>
    public byte CasoCorreoPlantillaNumero { get; set; }

    /// <summary>
    /// Nombre de la plantilla.
    /// </summary>
    public string CasoCorreoPlantillaNombre { get; set; } = null!;

    /// <summary>
    /// Descripción de la plantilla.
    /// </summary>
    public string CasoCorreoPlantillaDescripcion { get; set; } = null!;

    /// <summary>
    /// Asunto de la plantilla.
    /// </summary>
    public string CasoCorreoPlantillaAsunto { get; set; } = null!;

    /// <summary>
    /// Cuerpo de la plantilla.
    /// </summary>
    public string CasoCorreoPlantillaCuerpo { get; set; } = null!;

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
}
