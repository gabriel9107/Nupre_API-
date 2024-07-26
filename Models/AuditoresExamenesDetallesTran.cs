using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AuditoresExamenesDetallesTran
{
    public int ExamenNumero { get; set; }

    public short PreguntaNumero { get; set; }

    public short PreguntaRespuestaNumero { get; set; }

    public string PreguntaDescripcion { get; set; } = null!;

    public short PreguntaOrden { get; set; }

    public string PreguntaRespuestaDescripcion { get; set; } = null!;

    public string PreguntaRespuestaElegida { get; set; } = null!;

    public string PreguntaRespuestaLetra { get; set; } = null!;

    public byte PreguntaRespuestaValida { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual AuditoresExamenesTran ExamenNumeroNavigation { get; set; } = null!;

    public virtual AuditoresPreguntasCatum PreguntaNumeroNavigation { get; set; } = null!;
}
