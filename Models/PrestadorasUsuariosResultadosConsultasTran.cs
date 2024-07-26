using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasUsuariosResultadosConsultasTran
{
    public long ResultadoConsultaNumero { get; set; }

    public long? ResultadoConsultaIdUnipago { get; set; }

    public string ResultadoConsultaCodigoXml { get; set; } = null!;

    public string? ResultadoConsultaParametros { get; set; }

    public string? ResultadoConsultaUsuario { get; set; }

    public DateTime RegistroFecha { get; set; }

    public string RegistroIpPc { get; set; } = null!;

    public string? RegistroEstado { get; set; }

    public string? RegistroUsuario { get; set; }
}
