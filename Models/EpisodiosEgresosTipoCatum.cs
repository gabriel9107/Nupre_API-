using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de los tipo de egreso relacionados con los episodios de salud (Generalmente cuando son hospitalizaciones), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class EpisodiosEgresosTipoCatum
{
    /// <summary>
    /// Número único que representa  Tipo de Egreso, especifica el destino o estado del paciente  , su objetivo es ser utilizados en futuras conversiones hacia el DATA WAREHOUSE.
    /// </summary>
    public byte EgresoTipoNumero { get; set; }

    /// <summary>
    /// Código del Tipo de Egreso, especifica el estado o situación del paciente (Afiliado) al finalizar un episodio de prestación de servicios de salud (Fallecido, Trasferido, Alta, etc.).
    /// </summary>
    public string EgresoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del Tipo de Egreso, especifica el estado o situación del paciente (Afiliado) al finalizar un episodio de prestación de servicios de salud (Fallecido, Trasferido, Alta, etc.).
    /// </summary>
    public string EgresoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Descripción corta del Tipo de Egreso (Resumido para mejor visualización en las interfaces), especifica el estado o situación del paciente (Afiliado) al finalizar un episodio de prestación de servicios de salud (Fallecido, Trasferido, Alta, etc.).
    /// </summary>
    public string EgresoTipoDescripcionCorta { get; set; } = null!;

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

    public virtual ICollection<AtEventosTran> AtEventosTrans { get; set; } = new List<AtEventosTran>();

    public virtual ICollection<EpisodiosDiagnosticosSubsidiadosTran> EpisodiosDiagnosticosSubsidiadosTrans { get; set; } = new List<EpisodiosDiagnosticosSubsidiadosTran>();

    public virtual ICollection<EpisodiosSubsidiadosTran> EpisodiosSubsidiadosTrans { get; set; } = new List<EpisodiosSubsidiadosTran>();

    public virtual ICollection<EpisodiosTran> EpisodiosTrans { get; set; } = new List<EpisodiosTran>();
}
