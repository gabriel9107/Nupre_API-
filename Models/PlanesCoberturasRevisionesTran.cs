using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PlanesCoberturasRevisionesTran
{
    public string PlanNumero { get; set; } = null!;

    public byte GrupoNumero { get; set; }

    public byte SubGrupoNumero { get; set; }

    public short CoberturaNumero { get; set; }

    public string PlanNumeroOrigen { get; set; } = null!;

    public byte RevisionNumero { get; set; }

    public byte RevisionNumeroPropuesta { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
