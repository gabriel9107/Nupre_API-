using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de los sectores por municipios de la República Dominicana, según codificación de la JCE, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesSectoresParajesCatum
{
    public short SectorMunicipioNumero { get; set; }

    public string SectorMunicipioNombre { get; set; } = null!;

    /// <summary>
    /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public short MunicipioNumero { get; set; }

    /// <summary>
    /// Número único  asignado a cada sector de las ciudades y municipio por la JCE.
    /// </summary>
    public short SectorNumero { get; set; }

    /// <summary>
    /// Nombre del sector de las ciudad y/o municipio según catálogo de  la JCE.
    /// </summary>
    public string SectorNombre { get; set; } = null!;

    /// <summary>
    /// Número único que identifica la ciudad
    /// </summary>
    public byte CiudadNumero { get; set; }

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

    public virtual ComunesMunicipiosCatum MunicipioNumeroNavigation { get; set; } = null!;
}
