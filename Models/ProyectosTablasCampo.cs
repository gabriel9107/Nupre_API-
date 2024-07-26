using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProyectosTablasCampo
{
    public string ProyectoServidor { get; set; } = null!;

    public string ProyectoBdd { get; set; } = null!;

    public string ProyectoTabla { get; set; } = null!;

    public string ProyectoTablaContenido { get; set; } = null!;

    public string ProyectoCampo { get; set; } = null!;

    public string ProyectoCampoTipo { get; set; } = null!;

    public short ProyectoCampoLongitud { get; set; }

    public byte ProyectoCampoEscala { get; set; }

    public string ProyectoCampoClave { get; set; } = null!;

    public string ProyectoCampoIdentity { get; set; } = null!;

    public string ProyectoCampoDescripcion { get; set; } = null!;
}
