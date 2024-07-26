using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosRelacionadosTran
{
    /// <summary>
    /// Número que identifica el caso generado mediante una solicitud ante una queja o reclamo por parte de los ciudadanos.
    /// </summary>
    public int CasoNumero { get; set; }

    /// <summary>
    /// Número que identifica la persona o contacto para gestión de casos.
    /// </summary>
    public int CasoContactoNumero { get; set; }

    /// <summary>
    /// Número que identifica el tipo de relacionado de un caso.
    /// </summary>
    public byte CasoRelacionadoTipoNumero { get; set; }

    /// <summary>
    /// A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual CasosContactosMaster CasoContactoNumeroNavigation { get; set; } = null!;

    public virtual CasosMaster CasoNumeroNavigation { get; set; } = null!;

    public virtual CasosRelacionadosTipoCatum CasoRelacionadoTipoNumeroNavigation { get; set; } = null!;
}
