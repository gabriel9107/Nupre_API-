using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de los tipos de atenciones o forma de atención, relacionados con los episodios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class EpisodiosAtencionesTipoCatum
{
    /// <summary>
    /// Número único que representa  el Tipo de Atención,  especifica si el servicio fue prestado en forma de Emergencia o Programado, su objetivo es ser utilizados en futuras conversiones hacia el DATA WAREHOUSE.
    /// </summary>
    public byte AtencionTipoNumero { get; set; }

    /// <summary>
    /// Código del Tipo de Atención, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string AtencionTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del Tipo de Atención, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string AtencionTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Descripción corta del Tipo de Atención (Resumido para mejor visualización en las interfaces), especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string AtencionTipoDescripcionCorta { get; set; } = null!;

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

    public virtual ICollection<EpisodiosDiagnosticosSubsidiadosTran> EpisodiosDiagnosticosSubsidiadosTrans { get; set; } = new List<EpisodiosDiagnosticosSubsidiadosTran>();

    public virtual ICollection<EpisodiosSubsidiadosTran> EpisodiosSubsidiadosTrans { get; set; } = new List<EpisodiosSubsidiadosTran>();

    public virtual ICollection<EpisodiosTran> EpisodiosTrans { get; set; } = new List<EpisodiosTran>();

    public virtual ICollection<SeguimientosEsquemas35ValidacionesCatum> SeguimientosEsquemas35ValidacionesCata { get; set; } = new List<SeguimientosEsquemas35ValidacionesCatum>();

    public virtual ICollection<SubGruposAtencionesServiciosTipoCatum> SubGruposAtencionesServiciosTipoCata { get; set; } = new List<SubGruposAtencionesServiciosTipoCatum>();
}
