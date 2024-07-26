using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosActividadesTran
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
    /// Número que identifica el tipo de actividad.
    /// </summary>
    public byte CasoActividadTipoNumero { get; set; }

    /// <summary>
    /// Comentario de la actividad, en caso sea necesario.
    /// </summary>
    public string CasoActividadComentario { get; set; } = null!;

    /// <summary>
    /// Número que identifica la dirección (Uadministrativa), solo para casos.
    /// </summary>
    public byte CasoDireccionNumero { get; set; }

    /// <summary>
    /// Fecha de inicia una actividad.
    /// </summary>
    public DateTime CasoActividadFechaInicio { get; set; }

    /// <summary>
    /// Fecha en que finaliza una actividad.
    /// </summary>
    public DateTime CasoActividadFechaFin { get; set; }

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

    public virtual CasosActividadesTipoCatum CasoActividadTipoNumeroNavigation { get; set; } = null!;

    public virtual CasosDireccionesMaster CasoDireccionNumeroNavigation { get; set; } = null!;

    public virtual CasosMaster CasoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<CasosActividadesUsuariosTran> CasosActividadesUsuariosTrans { get; set; } = new List<CasosActividadesUsuariosTran>();
}
