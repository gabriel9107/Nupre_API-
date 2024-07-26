using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasUsuariosTran
{
    public int PrestadoraNumero { get; set; }

    public string NoDocumento { get; set; } = null!;

    public string? UsuarioNombre { get; set; }

    public byte TipoNovedadNumero { get; set; }

    public string UsuarioCargo { get; set; } = null!;

    public string UsuarioMovil { get; set; } = null!;

    public string UsuarioTelefonoOficina { get; set; } = null!;

    public string UsuarioExtensionOficina { get; set; } = null!;

    public DateTime? UsuarioFechaActualizaUnipago { get; set; }

    public string UsuarioMail { get; set; } = null!;

    public string? UsuarioClave { get; set; }

    public DateTime? UsuarioClaveFechaExpiracion { get; set; }

    public byte? EstadoClaveNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
