using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosContactosMaster
{
    /// <summary>
    /// Número que identifica la persona o contacto para gestión de casos.
    /// </summary>
    public int CasoContactoNumero { get; set; }

    /// <summary>
    /// Número que identifica el tipo de contacto para gestión de casos.
    /// </summary>
    public byte CasoContactoTipoNumero { get; set; }

    /// <summary>
    /// Número de RNC o cédula de la persona o contacto.
    /// </summary>
    public string CasoContactoRncOCedula { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social o Registro Patronal de la persona o contacto.
    /// </summary>
    public long CasoContactoNssOPatronal { get; set; }

    /// <summary>
    /// Nombre de la persona o contacto.
    /// </summary>
    public string CasoContactoNombre { get; set; } = null!;

    /// <summary>
    /// Cargo que desempeña la persona o contacto.
    /// </summary>
    public string CasoContactoCargo { get; set; } = null!;

    /// <summary>
    /// Número que identifica la dirección (Uadministrativa), solo para casos.
    /// </summary>
    public string CasoContactoDireccion { get; set; } = null!;

    /// <summary>
    /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public short MunicipioNumero { get; set; }

    /// <summary>
    /// Primer número de teléfono de la persona o contacto.
    /// </summary>
    public string CasoContactoTelefono1 { get; set; } = null!;

    /// <summary>
    /// Primer número de teléfono de la persona o contacto.
    /// </summary>
    public string CasoContactoTelefono2 { get; set; } = null!;

    /// <summary>
    /// Número de extensión de la persona o contacto.
    /// </summary>
    public string CasoContactoExtension { get; set; } = null!;

    /// <summary>
    /// Número de célular de la persona o contacto.
    /// </summary>
    public string CasoContactoCelular { get; set; } = null!;

    /// <summary>
    /// Número de fax de la persona o contacto.
    /// </summary>
    public string CasoContactoFax { get; set; } = null!;

    /// <summary>
    /// A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual CasosContactosTipoCatum CasoContactoTipoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<CasosRelacionadosTran> CasosRelacionadosTrans { get; set; } = new List<CasosRelacionadosTran>();
}
