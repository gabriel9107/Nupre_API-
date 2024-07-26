using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class UnipagoAfiliacionWebServiceResultadosTran
{
    public long WebServiceResultadoNumero { get; set; }

    public long? WebServiceResultadoIdUnipago { get; set; }

    public string WebServiceResultadoCodigoXml { get; set; } = null!;

    public string? WebServiceResultadoParametros { get; set; }

    public string? WebServiceResultadoUsuario { get; set; }

    public DateTime RegistroFecha { get; set; }

    public string RegistroIpPc { get; set; } = null!;

    public string? RegistroEstado { get; set; }

    public string? RegistroUsuario { get; set; }
}
