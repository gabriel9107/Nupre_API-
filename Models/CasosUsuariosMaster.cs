using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosUsuariosMaster
{
    /// <summary>
    /// Nombre de usuario (Usuario_NT) de la empresa.
    /// </summary>
    public string UsuarioUsuarioNombre { get; set; } = null!;

    /// <summary>
    /// Número que identifica el empleado.
    /// </summary>
    public byte EmpleadoNumero { get; set; }

    /// <summary>
    /// Nombre completo del empleado.
    /// </summary>
    public string EmpleadoNombreCompleto { get; set; } = null!;

    /// <summary>
    /// Número que identifica la dirección (Uadministrativa), solo para casos.
    /// </summary>
    public byte CasoDireccionNumero { get; set; }

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

    public virtual CasosDireccionesMaster CasoDireccionNumeroNavigation { get; set; } = null!;

    public virtual ICollection<CasosActividadesUsuariosTran> CasosActividadesUsuariosTrans { get; set; } = new List<CasosActividadesUsuariosTran>();
}
