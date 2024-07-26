using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CoberturasMaster08122017
{
    public short CoberturaNumero { get; set; }

    public string CoberturaDescripcion { get; set; } = null!;

    public byte CoberturaTipoNumero { get; set; }

    public string CupsCodigo { get; set; } = null!;

    public string CoberturaAplicaTraspasosCde { get; set; } = null!;

    public string CoberturaNivelAtencion1 { get; set; } = null!;

    public string CoberturaNivelAtencion2 { get; set; } = null!;

    public string CoberturaNivelAtencion3 { get; set; } = null!;

    public string CoberturaAplicaPyp { get; set; } = null!;

    public byte? PypNivelNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
