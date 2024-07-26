using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosActividadesUsuariosTran
{
    /// <summary>
    /// Número que identifica el caso generado mediante una solicitud ante una queja o reclamo por parte de los ciudadanos.
    /// </summary>
    public int CasoNumero { get; set; }

    /// <summary>
    /// Número de secuencia de la actividad, cuya finalidad es almacenar la frecuencia con la que ocurre una determinada actividad.
    /// </summary>
    public byte CasoActividadSecuencia { get; set; }

    /// <summary>
    /// Nombre del usuario (Usuario_NT) que tendrá permiso ante un rol determinado.
    /// </summary>
    public string UsuarioUsuarioNombre { get; set; } = null!;

    /// <summary>
    /// Nombre de la actividad realizada por el usuario.
    /// </summary>
    public string CasoActividadNombre { get; set; } = null!;

    /// <summary>
    /// Número de cédula e identidad electoral del usuario que realiza la actividad.
    /// </summary>
    public string CasoActividadCedula { get; set; } = null!;

    /// <summary>
    /// Indica el origen del usuario que realizó la actividad (I = Interno, E = Externo).
    /// </summary>
    public string CasoActividadUsuarioOrigen { get; set; } = null!;

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

    public virtual CasosActividadesTran Caso { get; set; } = null!;

    public virtual CasosUsuariosMaster UsuarioUsuarioNombreNavigation { get; set; } = null!;
}
