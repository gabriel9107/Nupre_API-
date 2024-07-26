using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional, que contiene los detalles de los documentos que hacen referencias a los planes registrados en el maestro de planes de servicios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PlanesDocumentosTran
{
    /// <summary>
    /// Código único de la versión del Plan de servicios de Salud (PDSS) al cual pertenece el Subgrupo.
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    /// <summary>
    /// Es el código único que representa el documento dentro del sistema.
    /// </summary>
    public string DocumentoCodigo { get; set; } = null!;

    /// <summary>
    /// Notas relacionadas con el contenido y asignación del documento.
    /// </summary>
    public string DocumentoNota { get; set; } = null!;

    /// <summary>
    /// Indica si el documento relacionado con el plan se publicara o no hacia la WEB.
    /// </summary>
    public bool DocumentoPublicar { get; set; }

    /// <summary>
    /// Indica si el documento relacionado con el plan se publicara o no hacia la WEB.
    /// </summary>
    public string DocumentoPublicado { get; set; } = null!;

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

    public virtual ComunesDocumentosMaster DocumentoCodigoNavigation { get; set; } = null!;

    public virtual PlanesMaster PlanNumeroNavigation { get; set; } = null!;
}
