using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosDireccionesMaster
{
    /// <summary>
    /// Número que identifica la dirección (Uadministrativa), solo para casos.
    /// </summary>
    public byte CasoDireccionNumero { get; set; }

    /// <summary>
    /// Unidad Administrativa al que corresponde la Dirección con acceso a casos.
    /// </summary>
    public string CasoDireccionUnidadAdministrativa { get; set; } = null!;

    /// <summary>
    /// Nombre de la Unidad Administrativa o Dirección.
    /// </summary>
    public string CasoDireccionNombre { get; set; } = null!;

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

    public virtual ICollection<CasosActividadesTran> CasosActividadesTrans { get; set; } = new List<CasosActividadesTran>();

    public virtual ICollection<CasosDireccionesViasTiemposTran> CasosDireccionesViasTiemposTrans { get; set; } = new List<CasosDireccionesViasTiemposTran>();

    public virtual ICollection<CasosMaster> CasosMasters { get; set; } = new List<CasosMaster>();

    public virtual ICollection<CasosMotivosCatum> CasosMotivosCata { get; set; } = new List<CasosMotivosCatum>();

    public virtual ICollection<CasosUsuariosMaster> CasosUsuariosMasters { get; set; } = new List<CasosUsuariosMaster>();
}
