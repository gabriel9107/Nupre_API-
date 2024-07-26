using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosActividadesTipoCatum
{
    /// <summary>
    /// Número que identifica el tipo de actividad.
    /// </summary>
    public byte CasoActividadTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de actividad.
    /// </summary>
    public string CasoActividadTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Indicador de aplicación de tiempo para la actividad a realizar (S = SI, N = NO).
    /// </summary>
    public string CasoActividadTipoAplicaTiempo { get; set; } = null!;

    /// <summary>
    /// Número que identifica el tipo de proceso de la actividad a realizar.
    /// </summary>
    public byte CasoProcesoTipoNumero { get; set; }

    /// <summary>
    /// Indicador de permiso para editar una actividad (S = SI, N = NO).
    /// </summary>
    public string CasoActividadTipoPermiteEdicion { get; set; } = null!;

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

    public virtual CasosProcesosTipoCatum CasoProcesoTipoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<CasosActividadesTran> CasosActividadesTrans { get; set; } = new List<CasosActividadesTran>();
}
