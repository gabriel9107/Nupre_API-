using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de los tipos de servicios o área de servicios, relacionados con los episodios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class EpisodiosServiciosTipoCatum
{
    /// <summary>
    /// Número único que representa  el Tipo de servicio, especifica si el servicio fue prestado bajo el área de  Hospitalización,  Prevención y Promoción,  Emergencia y Ambulatorio, su objetivo es ser utilizados en futuras conversiones hacia el DATA WAREHOUSE.
    /// </summary>
    public byte ServicioTipoNumero { get; set; }

    /// <summary>
    /// Código del Tipo de servicio, especifica si el servicio fue prestado bajo el área de  Hospitalización,  Prevención y Promoción,  Emergencia y Ambulatorio.
    /// </summary>
    public string ServicioTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del Tipo de servicio, especifica si el servicio fue prestado bajo el área de  Hospitalización,  Prevención y Promoción,  Emergencia y Ambulatorio.
    /// </summary>
    public string ServicioTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Descripción corta del Tipo de servicio (Resumido para mejor visualización en las interfaces), especifica si el servicio fue prestado bajo el área de  Hospitalización,  Prevención y Promoción,  Emergencia y Ambulatorio.
    /// </summary>
    public string ServicioTipoDescripcionCorta { get; set; } = null!;

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

    public virtual ICollection<FinancierosReclamacionesArsTran> FinancierosReclamacionesArsTrans { get; set; } = new List<FinancierosReclamacionesArsTran>();

    public virtual ICollection<SubGruposAtencionesServiciosTipoCatum> SubGruposAtencionesServiciosTipoCata { get; set; } = new List<SubGruposAtencionesServiciosTipoCatum>();
}
