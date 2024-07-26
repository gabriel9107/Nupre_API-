using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosContactosTipoCatum
{
    /// <summary>
    /// Número que identifica el tipo de contacto para gestión de casos.
    /// </summary>
    public byte CasoContactoTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de contacto.
    /// </summary>
    public string CasoContactoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del tipo de contacto.
    /// </summary>
    public string CasoContactoTipoExplicacion { get; set; } = null!;

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

    public virtual ICollection<CasosContactosMaster> CasosContactosMasters { get; set; } = new List<CasosContactosMaster>();
}
