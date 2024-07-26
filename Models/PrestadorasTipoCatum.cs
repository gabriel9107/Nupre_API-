using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipo de Prestadoras de Servicios de Salud (PSS), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasTipoCatum
{
    /// <summary>
    /// Es un número único que identifica el tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
    /// </summary>
    public byte PrestadoraTipoNumero { get; set; }

    /// <summary>
    /// Es la descripción del tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
    /// </summary>
    public string PrestadoraTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Es la explicación del tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
    /// </summary>
    public string PrestadoraTipoExplicacion { get; set; } = null!;

    /// <summary>
    /// Indica los números del catálogo anterior de tipo de prestadoras,  que eran similares a este tipo de prestadora.
    /// </summary>
    public string PrestadoraTipoAnteriores { get; set; } = null!;

    /// <summary>
    /// Es un número único que identifica la clase a la cual pertenece el tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos, Centro Ambulatorio, Hospitales, etc.).
    /// </summary>
    public byte PrestadoraClaseNumero { get; set; }

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 1er. Nivel de atención de salud.
    /// </summary>
    public string PrestadoraPrimerNivel { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 2do. Nivel de atención de salud.
    /// </summary>
    public string PrestadoraSegundoNivel { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 3er. Nivel de atención de salud.
    /// </summary>
    public string PrestadoraTercerNivel { get; set; } = null!;

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

    public virtual PrestadorasClaseCatum PrestadoraClaseNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PrestadorasInstitucionalesMaster> PrestadorasInstitucionalesMasters { get; set; } = new List<PrestadorasInstitucionalesMaster>();

    public virtual ICollection<PrestadorasMedicosMaster> PrestadorasMedicosMasters { get; set; } = new List<PrestadorasMedicosMaster>();

    public virtual ICollection<PrestadorasSolicitudTran> PrestadorasSolicitudTrans { get; set; } = new List<PrestadorasSolicitudTran>();

    public virtual ICollection<PrestadorasTipoServiciosCatum> PrestadorasTipoServiciosCata { get; set; } = new List<PrestadorasTipoServiciosCatum>();
}
