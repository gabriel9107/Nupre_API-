﻿using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasCorreosDestinatariosCatum
{
    public string CorreoDestinatarioClave { get; set; } = null!;

    public string CorreoDestinatarioDetalle { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}