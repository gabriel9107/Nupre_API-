using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PromotoresUsuariosBitacoraTran
{
    public long BitacoraSecuencia { get; set; }

    public int ExamenNumero { get; set; }

    public short PeriodoNumero { get; set; }

    public string PromotorCedula { get; set; } = null!;

    public string ExamenReciboSerial { get; set; } = null!;

    public string UsuarioCuenta { get; set; } = null!;

    public string UsuarioAccion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
