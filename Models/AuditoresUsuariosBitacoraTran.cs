using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AuditoresUsuariosBitacoraTran
{
    public int? ExamenNumero { get; set; }

    public short? PeriodoNumero { get; set; }

    public string? PromotorCedula { get; set; }

    public string? ExamenReciboSerial { get; set; }

    public string? UsuarioCuenta { get; set; }

    public string? UsuarioAccion { get; set; }

    public string? RegistroEstado { get; set; }

    public string? RegistroUsuario { get; set; }

    public DateTime? RegistroFecha { get; set; }
}
