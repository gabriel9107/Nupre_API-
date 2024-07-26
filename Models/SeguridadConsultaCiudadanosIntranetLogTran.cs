using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguridadConsultaCiudadanosIntranetLogTran
{
    public int LogSecuencia { get; set; }

    public int EmpleadoNumero { get; set; }

    public string EmpleadoNombreCompleto { get; set; } = null!;

    public string NssOrCedulaConsultada { get; set; } = null!;

    public string TipoConsulta { get; set; } = null!;

    public string Resultado { get; set; } = null!;

    public DateTime ConsultaFecha { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
