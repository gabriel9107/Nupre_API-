using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssEmpleadoresHistorico
{
    public int PeriodoFactura { get; set; }

    public int EmpleadorRegistroPatronal { get; set; }

    public string EmpresaTipoCodigo { get; set; } = null!;

    public string CategoriaRiesgo { get; set; } = null!;

    public int EmpleadorTotalTrabajadores { get; set; }

    public decimal EmpleadorSalarioSeguridadSocial { get; set; }

    public DateTime EmpleadorFechaRegistroTss { get; set; }

    public DateTime EmpleadorFechaActualizacionTss { get; set; }

    public string EmpleadorEstatus { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
