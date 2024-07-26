using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla catálogo de validaciones para el esquema 0035 para seguimiento de las cuentas contenidas en este por parte del área técnica.
/// </summary>
public partial class SeguimientosEsquemas35ValidacionesCatum
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número único asignado a cada tipo de plan de salud.
    /// </summary>
    public byte PlanTipoNumero { get; set; }

    /// <summary>
    /// Código creado a partir de la combinación de numero de grupo con el numero del subgrupo separados por un punto (.). 
    /// </summary>
    public string SubGrupoCodigo { get; set; } = null!;

    /// <summary>
    /// Código del Tipo de Atención, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string AtencionTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaCodigo { get; set; }

    /// <summary>
    /// Número único del grupo al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public byte GrupoNumero { get; set; }

    /// <summary>
    /// Número único asignado al subgrupo del PDSS, se incrementa de 1 a N para cada grupo del PDSS.
    /// </summary>
    public byte SubGrupoNumero { get; set; }

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

    public virtual FinancierosCuentasCatum CuentaCodigoNavigation { get; set; } = null!;

    public virtual PlanesTipoCatum PlanTipoNumeroNavigation { get; set; } = null!;

    public virtual SubGruposCatum SubGruposCatum { get; set; } = null!;
}
