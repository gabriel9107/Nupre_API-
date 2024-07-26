using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de las metas por trimestre y año de las poblaciones objetivas según Grupos y Subgrupos de servicios de salud, para el seguimiento del PYP a través del esquema 40, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PypMetasTrimestralesMaster
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
    /// Año correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public short SeguimientoAnio { get; set; }

    /// <summary>
    /// Corresponde al período de tres meses de un año
    /// </summary>
    public byte TrimestreNumero { get; set; }

    /// <summary>
    /// Es el porciento que se espera cubrir en un trimestre de la población proyectada anual de afiliados de una ARS, de un año y población objetiva específica.
    /// </summary>
    public byte MetaTrimestre { get; set; }

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

    public virtual SubGruposCatum SubGruposCatum { get; set; } = null!;

    public virtual ComunesTrimestresCatum TrimestreNumeroNavigation { get; set; } = null!;
}
