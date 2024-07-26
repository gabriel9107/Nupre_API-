using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipos de servicios y atenciones utilizadas para calificar los episodios de prestaciones de salud y su relación con los subgrupos de servicios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SubGruposAtencionesServiciosTipoCatum
{
    /// <summary>
    /// Número único del grupo al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public byte GrupoNumero { get; set; }

    /// <summary>
    /// Número único asignado al subgrupo del PDSS, se incrementa de 1 a N para cada grupo del PDSS.
    /// </summary>
    public byte SubGrupoNumero { get; set; }

    /// <summary>
    /// Código del Tipo de Atención, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string AtencionTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Código del Tipo de servicio, especifica si el servicio fue prestado bajo el área de  Hospitalización,  Prevención y Promoción,  Emergencia y Ambulatorio.
    /// </summary>
    public string ServicioTipoCodigo { get; set; } = null!;

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

    public virtual EpisodiosAtencionesTipoCatum AtencionTipoCodigoNavigation { get; set; } = null!;

    public virtual EpisodiosServiciosTipoCatum ServicioTipoCodigoNavigation { get; set; } = null!;

    public virtual SubGruposCatum SubGruposCatum { get; set; } = null!;
}
