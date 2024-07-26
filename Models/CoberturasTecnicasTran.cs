using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CoberturasTecnicasTran
{
    public short CoberturaNumero { get; set; }

    public int CoberturaTecnicaSecuencia { get; set; }

    public string CoberturaTecnicaDescripcion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual CoberturasMaster CoberturaNumeroNavigation { get; set; } = null!;
}
