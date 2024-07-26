using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene el tipo de respuesta dadas después de la evaluación de un traspaso, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosRespuestasCatum
{
    /// <summary>
    /// Número único de repuesta dada, después de la evaluación de un formulario de reclamo en un proceso de traspaso.
    /// </summary>
    public byte RespuestaNumero { get; set; }

    /// <summary>
    /// Descripción de la repuesta dada, después de la evaluación de un formulario o imagen en un proceso de traspaso.
    /// </summary>
    public string RespuestaDescripcion { get; set; } = null!;

    /// <summary>
    /// Clasifica el tipo de la repuesta dada, después de la evaluación de un formulario o imagen de un proceso de traspaso,  si aplican para condición de enfermedad o problema de imagen.
    /// </summary>
    public string RespuestaTipo { get; set; } = null!;

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

    public virtual ICollection<TraspasosProblemasImagenCatum> TraspasosProblemasImagenCata { get; set; } = new List<TraspasosProblemasImagenCatum>();

    public virtual ICollection<TraspasosSeguimientosCondicionEnfermedadTran> TraspasosSeguimientosCondicionEnfermedadTrans { get; set; } = new List<TraspasosSeguimientosCondicionEnfermedadTran>();

    public virtual ICollection<TraspasosSeguimientosProblemaImagenTran> TraspasosSeguimientosProblemaImagenTrans { get; set; } = new List<TraspasosSeguimientosProblemaImagenTran>();
}
