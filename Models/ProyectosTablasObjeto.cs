using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProyectosTablasObjeto
{
    public string ProyectoServidor { get; set; } = null!;

    public string ProyectoBdd { get; set; } = null!;

    public string ProyectoTabla { get; set; } = null!;

    public string ProyectoObjetos { get; set; } = null!;

    public string ProyectoObjetosTipo { get; set; } = null!;
}
