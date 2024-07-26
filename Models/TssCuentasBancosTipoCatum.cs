using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssCuentasBancosTipoCatum
{
    public byte CuentaTipoNumero { get; set; }

    public string CuentaTipoDescripcion { get; set; } = null!;

    public string CuentaTipoExplicacion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
