using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los tipos de esquemas  que deben cargar las ARS/ARL para su supervisión y seguimiento, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosEsquemasCatum
{
    /// <summary>
    /// Número único que representa cada  esquema.
    /// </summary>
    public byte EsquemaNumero { get; set; }

    /// <summary>
    /// Número único del grupo de seguridad al que pertenecen los usuarios de los sistemas de información.
    /// </summary>
    public byte GrupoSeguridadNumero { get; set; }

    /// <summary>
    /// Descripción del esquema.
    /// </summary>
    public string EsquemaDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción del esquema.
    /// </summary>
    public string EsquemaExplicacion { get; set; } = null!;

    /// <summary>
    /// Día del mes en que debe iniciar el envió  (Carga) del esquema.
    /// </summary>
    public byte EsquemaDiaDebeEnviarlo { get; set; }

    /// <summary>
    /// Ultimo día del mes hasta el cual puede ser enviada la carga del esquema por las ARS/ARL.
    /// </summary>
    public byte EsquemaUltimoDiaEnvio { get; set; }

    /// <summary>
    /// Día que de que dispone la ARS/ARL para el envió  (Carga) del esquema.
    /// </summary>
    public byte EsquemaDiasParaEnvio { get; set; }

    /// <summary>
    /// Tabla (Objeto) donde se guardan las informaciones de cada  esquema.
    /// </summary>
    public string EsquemaTabla { get; set; } = null!;

    /// <summary>
    /// Indica si el esquema es de envío periódico u ocasional.
    /// </summary>
    public bool EsquemaFrecuente { get; set; }

    /// <summary>
    /// Dirección de la carpeta donde se encuentra ubicado el archivo de la imagen (JPG) del esquema.
    /// </summary>
    public string EsquemaImagenUrl { get; set; } = null!;

    public string EsquemaCierrePeriodo { get; set; } = null!;

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

    public virtual ICollection<ArsReportesMaster> ArsReportesMasters { get; set; } = new List<ArsReportesMaster>();

    public virtual SeguridadGruposCatum GrupoSeguridadNumeroNavigation { get; set; } = null!;

    public virtual ICollection<SeguimientosEsquemasEstructurasCatum> SeguimientosEsquemasEstructurasCata { get; set; } = new List<SeguimientosEsquemasEstructurasCatum>();

    public virtual ICollection<SeguimientosEsquemasInstitucionesTipoCatum> SeguimientosEsquemasInstitucionesTipoCata { get; set; } = new List<SeguimientosEsquemasInstitucionesTipoCatum>();

    public virtual ICollection<SeguimientosEsquemasInstitucionesTran> SeguimientosEsquemasInstitucionesTrans { get; set; } = new List<SeguimientosEsquemasInstitucionesTran>();

    public virtual ICollection<SeguimientosLotesEventosProcedimientosTran> SeguimientosLotesEventosProcedimientosTrans { get; set; } = new List<SeguimientosLotesEventosProcedimientosTran>();

    public virtual ICollection<SeguimientosMaster> SeguimientosMasters { get; set; } = new List<SeguimientosMaster>();
}
