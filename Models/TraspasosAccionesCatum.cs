using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene las acciones que se toman como respuesta a la evaluación de un traspaso, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosAccionesCatum
{
    /// <summary>
    /// Número único de cada acción,  acciones que se aplican en los proceso de evaluación de traspasos con reclamos de la ARS o por solicitudes del usuario.
    /// </summary>
    public byte AccionNumero { get; set; }

    /// <summary>
    /// Descripción de  la acción,  acciones que se aplican en los proceso de evaluación de traspasos con reclamos de la ARS o por solicitudes del usuario.
    /// </summary>
    public string AccionDescripcion { get; set; } = null!;

    /// <summary>
    /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<TraspasosAccionCondicionEnfermedadHistorico> TraspasosAccionCondicionEnfermedadHistoricos { get; set; } = new List<TraspasosAccionCondicionEnfermedadHistorico>();

    public virtual ICollection<TraspasosAccionProblemaImagenHistorico> TraspasosAccionProblemaImagenHistoricos { get; set; } = new List<TraspasosAccionProblemaImagenHistorico>();

    public virtual ICollection<TraspasosFormulariosCdeTran> TraspasosFormulariosCdeTrans { get; set; } = new List<TraspasosFormulariosCdeTran>();

    public virtual ICollection<TraspasosMaster> TraspasosMasters { get; set; } = new List<TraspasosMaster>();

    public virtual ICollection<TraspasosSeguimientosCondicionEnfermedadTran> TraspasosSeguimientosCondicionEnfermedadTrans { get; set; } = new List<TraspasosSeguimientosCondicionEnfermedadTran>();

    public virtual ICollection<TraspasosSeguimientosProblemaImagenTran> TraspasosSeguimientosProblemaImagenTrans { get; set; } = new List<TraspasosSeguimientosProblemaImagenTran>();
}
