using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssControlCargaVistasTran
{
    public int ControlCargaTablaSecuencia { get; set; }

    public string ControlCargaTablaNombre { get; set; } = null!;

    public DateTime ControlCargaFecha { get; set; }

    public int ControlCargaRegistrosBajados { get; set; }

    public int ControlCargaRegistrosActualizados { get; set; }

    public int ControlCargaRegistrosInsertados { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
