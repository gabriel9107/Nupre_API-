using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProyectosProcedimiento
{
    public string ProyectoServidor { get; set; } = null!;

    public string ProyectoBdd { get; set; } = null!;

    public string ProyectoProcedimiento { get; set; } = null!;

    public string ProyectoParam { get; set; } = null!;

    public string ProyectoParamTipo { get; set; } = null!;

    public short ProyectoParamLongitud { get; set; }

    public byte ProyectoParamEscala { get; set; }

    public int ProyectoProcedimientoLargo { get; set; }
}
