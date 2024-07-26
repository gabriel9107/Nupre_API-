using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro que contiene las informaciones de cada una de las instituciones relacionadas con el SDSS, está estrechamente ligada a la tabla ARS Máster su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class InstitucionesMaster
{
    /// <summary>
    /// Número de la institución que es o a la que pertenece la ARS.
    /// </summary>
    public int InstitucionNumero { get; set; }

    /// <summary>
    /// RNC (Registro Nacional Contribuyente) de la institución.
    /// </summary>
    public string InstitucionRnc { get; set; } = null!;

    /// <summary>
    /// Es la razón social registrada por el prestador de servicios de salud   en la DGII, y que utiliza la Tesorería de la Seguridad Social en su registro de empleadores. Representa el nombre oficial de cada empresa o institución en el país.
    /// </summary>
    public string InstitucionNombre { get; set; } = null!;

    /// <summary>
    /// Nombre comercial de la institución.
    /// </summary>
    public string InstitucionNombreComercial { get; set; } = null!;

    /// <summary>
    /// Número telefónico de la institución.
    /// </summary>
    public string InstitucionTelefono { get; set; } = null!;

    /// <summary>
    /// Número de fax de la institución.
    /// </summary>
    public string InstitucionFax { get; set; } = null!;

    /// <summary>
    /// Dirección de la institución.
    /// </summary>
    public string InstitucionDireccion { get; set; } = null!;

    /// <summary>
    /// Website de la institución.
    /// </summary>
    public string InstitucionWebSite { get; set; } = null!;

    /// <summary>
    /// Tipificación del número de la institución (3 = Administradora de Riesgos de Salud).
    /// </summary>
    public byte InstitucionTipoNumero { get; set; }

    /// <summary>
    /// Número único de la ENTIDAD (ARS , ARL, PSS, Empleador, etc. ) que esta relacionado con la institución.
    /// </summary>
    public int InstitucionEntidadNumero { get; set; }

    /// <summary>
    /// Código que representa el Tipo de empresa según el sector al que pertenece (Pública centralizada, Pública No Centralizada, Privada y Mixta).
    /// </summary>
    public string EmpresaTipoCodigo { get; set; } = null!;

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

    public virtual ICollection<ArsMaster> ArsMasters { get; set; } = new List<ArsMaster>();

    public virtual ComunesEmpresasTipoCatum EmpresaTipoCodigoNavigation { get; set; } = null!;

    public virtual InstitucionesTipoCatum InstitucionTipoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PrestadorasInstitucionalesMaster> PrestadorasInstitucionalesMasters { get; set; } = new List<PrestadorasInstitucionalesMaster>();

    public virtual ICollection<SeguimientosCifradosLlavesTran> SeguimientosCifradosLlavesTrans { get; set; } = new List<SeguimientosCifradosLlavesTran>();

    public virtual ICollection<SeguimientosEsquemasInstitucionesTran> SeguimientosEsquemasInstitucionesTrans { get; set; } = new List<SeguimientosEsquemasInstitucionesTran>();

    public virtual ICollection<SeguimientosMaster> SeguimientosMasters { get; set; } = new List<SeguimientosMaster>();
}
