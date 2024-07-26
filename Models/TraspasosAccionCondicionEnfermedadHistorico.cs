using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosAccionCondicionEnfermedadHistorico
{
    public int HistoricoNumero { get; set; }

    public int NuctNumero { get; set; }

    public byte AccionNumero { get; set; }

    public byte RepuestaNumero { get; set; }

    public string? Comentario { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public string RegistroUsuarioHistorico { get; set; } = null!;

    public DateTime RegistroFechaHistorico { get; set; }

    public virtual TraspasosAccionesCatum AccionNumeroNavigation { get; set; } = null!;

    public virtual TraspasosRespuestasCatum RepuestaNumeroNavigation { get; set; } = null!;
}
