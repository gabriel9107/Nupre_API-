using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los detalles de los subgrupos de servicios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SubGruposCatum
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
    /// Código creado a partir de la combinación de numero de grupo con el numero del subgrupo separados por un punto (.). 
    /// </summary>
    public string SubGrupoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del subgrupo del PDSS,  se referiré al ámbito de los servicios cubiertos dentro de cada subgrupo.
    /// </summary>
    public string SubGrupoDescripcion { get; set; } = null!;

    /// <summary>
    /// Es la explicación detallada de cada subgrupo del PDSS.
    /// </summary>
    public string SubGrupoExplicacion { get; set; } = null!;

    /// <summary>
    /// Número único asignado a categoría de los subgrupos del PDSS, se refiere a si las coberturas se prestan bajo un Programa,  Área,  Área/ Servicios o Proceso.
    /// </summary>
    public int SubGrupoCategoriaNumero { get; set; }

    /// <summary>
    /// Número único asignado al área, se refiere al área donde se deben prestar  las coberturas de subgrupo del PDSS,  Ambulatoria, Urgencias y Hospitalización.
    /// </summary>
    public byte SubGrupoAreaNumero { get; set; }

    /// <summary>
    /// Número único asignado al servicio clínico, se refiere al servicio clínico bajo el cual se prestan  las coberturas de subgrupo del PDSS,  Especialidades básicas, Odontología,  Cirugía General etc.
    /// 
    /// </summary>
    public byte? SubGrupoServicioNumero { get; set; }

    /// <summary>
    /// Número único de población (Grupo etario) 
    /// </summary>
    public byte SubGrupoPoblacionNumero { get; set; }

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

    public virtual SubGruposGruposCatum GrupoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PlanesSubgruposMaster> PlanesSubgruposMasters { get; set; } = new List<PlanesSubgruposMaster>();

    public virtual ICollection<PypMetasTrimestralesMaster> PypMetasTrimestralesMasters { get; set; } = new List<PypMetasTrimestralesMaster>();

    public virtual ICollection<PypServiciosTran> PypServiciosTrans { get; set; } = new List<PypServiciosTran>();

    public virtual ICollection<PypSubGruposCoberturasMaster> PypSubGruposCoberturasMasters { get; set; } = new List<PypSubGruposCoberturasMaster>();

    public virtual ICollection<PypSubGruposPoblacionesCatum> PypSubGruposPoblacionesCata { get; set; } = new List<PypSubGruposPoblacionesCatum>();

    public virtual ICollection<SeguimientosEsquemas35ValidacionesCatum> SeguimientosEsquemas35ValidacionesCata { get; set; } = new List<SeguimientosEsquemas35ValidacionesCatum>();

    public virtual SubGruposCategoriasCatum SubGrupoAreaNumero1 { get; set; } = null!;

    public virtual SubGruposAreasCatum SubGrupoAreaNumeroNavigation { get; set; } = null!;

    public virtual SubGruposPoblacionesCatum SubGrupoPoblacionNumeroNavigation { get; set; } = null!;

    public virtual SubGruposServiciosCatum? SubGrupoServicioNumeroNavigation { get; set; }

    public virtual ICollection<SubGruposAtencionesServiciosTipoCatum> SubGruposAtencionesServiciosTipoCata { get; set; } = new List<SubGruposAtencionesServiciosTipoCatum>();

    public virtual ICollection<SubgruposCie09Catum> SubgruposCie09Cata { get; set; } = new List<SubgruposCie09Catum>();

    public virtual ICollection<SubgruposCie10Catum> SubgruposCie10Cata { get; set; } = new List<SubgruposCie10Catum>();
}
