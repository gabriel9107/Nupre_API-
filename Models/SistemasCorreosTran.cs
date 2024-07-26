using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasCorreosTran
{
    public int CorreoSecuencia { get; set; }

    public byte CorreoPlantillaNumero { get; set; }

    public string CorreoEnviarTo { get; set; } = null!;

    public string CorreoEnviarCc { get; set; } = null!;

    public string CorreoEnviarCco { get; set; } = null!;

    public string CorreoAsunto { get; set; } = null!;

    public string CorreoCuerpo { get; set; } = null!;

    public string CorreoEstadoCodigo { get; set; } = null!;

    public DateTime CorreoCambioEstadoFecha { get; set; }

    /// <summary>
    /// (P=Pendiente,E=Enviado,C= Cancelado,A=Actividad)
    /// </summary>
    public string CorrreoCambioEstadoUsuario { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual SistemasCorreosEstadosCatum CorreoEstadoCodigoNavigation { get; set; } = null!;

    public virtual SistemasCorreosPlantillasCatum CorreoPlantillaNumeroNavigation { get; set; } = null!;
}
