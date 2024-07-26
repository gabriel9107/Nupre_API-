using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PlanesDocumentosArsVistum
{
    public string PlanNumero { get; set; } = null!;

    public string DocumentoCodigo { get; set; } = null!;

    public byte ArsNumero { get; set; }

    public string ArsNombre { get; set; } = null!;

    public string PlanNombre { get; set; } = null!;

    public byte PlanEstadoNumero { get; set; }

    public string PlanEstadoCodigo { get; set; } = null!;

    public string PlanEstadoDescripcion { get; set; } = null!;

    public string PlanEstadoExplicacion { get; set; } = null!;

    public byte PlanTipoNumero { get; set; }

    public string PlanTipoCodigo { get; set; } = null!;

    public string PlanTipoDescripcion { get; set; } = null!;

    public string PlanTipoExplicacion { get; set; } = null!;

    public byte PlanModalidadNumero { get; set; }

    public string PlanModalidadDescripcion { get; set; } = null!;

    public string PlanDescripcion { get; set; } = null!;

    public DateTime PlanFechaAprobacion { get; set; }

    public DateTime PlanFechaInicioAplicacion { get; set; }

    public DateTime PlanFechaTerminoAplicacion { get; set; }

    public decimal PlanPrimaAnual { get; set; }

    public decimal PlanPrimaColectiva { get; set; }

    public int PlanRangoPersonasInicio { get; set; }

    public int PlanRangoPersonasTope { get; set; }

    public string DocumentoNota { get; set; } = null!;

    public bool DocumentoPublicar { get; set; }

    public string DocumentoPublicado { get; set; } = null!;

    public string DocumentoRuta { get; set; } = null!;

    public string DocumentoTema { get; set; } = null!;

    public string DocumentoAsunto { get; set; } = null!;

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
}
