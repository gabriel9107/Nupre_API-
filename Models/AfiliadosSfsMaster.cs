using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro que contiene las informaciones de cada uno de los afiliados Titulares y Dependientes al SFS,  su fuente de alimentación son las vistas estadísticas de UNIPAGO.
/// </summary>
public partial class AfiliadosSfsMaster
{
    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long AfiliadoNss { get; set; }

    /// <summary>
    /// Número único que identifica a un afiliado titular dentro del SFS, sobre el cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long AfiliadoTitularNss { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Es el código que clasifica los afiliados en T = Titulares (Quien representa al núcleo familiar) D = Dependientes  (Hijos y Conjugues) y A = Adicionales (Padres, Hijos con mayoría de edad cumplida 18 o 21, otros familiares dependientes económicamente).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Sexo de la persona (Afiliado)  (F=femenino, M=masculino).
    /// </summary>
    public string AfiliadoSexo { get; set; } = null!;

    /// <summary>
    /// Fecha en que la que se realiza la afiliación de un afiliado a una Administradora de Riesgos de Salud (ARS) para un Plan de Servicios de Salud (PDSS, Voluntarios, Complementario, Especial, etc.).
    /// </summary>
    public DateTime? AfiliadoFechaAfiliacion { get; set; }

    /// <summary>
    /// Código único que representa el proceso por el cual se registro  una afiliación,  entre ellas (Traspasos, Afiliación Automática, Normal, etc.).
    /// </summary>
    public string AfiliacionTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Número único que representa el parentesco entre un dependiente y el titular de un núcleo familiar en el Seguro Familiar de Salud (SFS).
    /// </summary>
    public byte ParentescoNumero { get; set; }

    /// <summary>
    /// Indica con (S/N) si el afiliado es estudiante.
    /// </summary>
    public string AfiliadoEstudiante { get; set; } = null!;

    /// <summary>
    /// Indica con (S/N) si el afiliado es un discapacitado.
    /// </summary>
    public string AfiliadoDiscapacitado { get; set; } = null!;

    /// <summary>
    /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public short MunicipioNumero { get; set; }

    /// <summary>
    /// Es la fecha de nacimiento de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public DateTime AfiliadoFechaNacimiento { get; set; }

    /// <summary>
    /// Número único que representa el estado de  un afiliado,  entre ellos (OK, PE, BAJA, etc.), su objetivo es ser utilizados en futuras conversiones hacia el DATA WAREHOUSE.
    /// </summary>
    public byte AfiliadoEstadoNumero { get; set; }

    /// <summary>
    /// Cantidad de cápitas que han sido dispersada por el afiliado a la ARS donde se encuentra afiliado actualmente.
    /// </summary>
    public int AfiliadoCantidadCapitas { get; set; }

    /// <summary>
    /// Representa el año y mes del  último periodo de facturación dispersado para el afiliado.
    /// </summary>
    public int AfiliadoUltimoPeriodoPagado { get; set; }

    /// <summary>
    /// Fecha en la que se realizo la baja de un afiliado de una cartera de afiliación de una ARS.
    /// </summary>
    public DateTime? AfiliadoFechaBaja { get; set; }

    /// <summary>
    /// Código único que representa la respuesta que da UNIPAGO al procesar una afiliación, esta respuesta justifica el estado en el que queda la afiliación.
    /// </summary>
    public string AfiliacionesRespuestaCodigo { get; set; } = null!;

    /// <summary>
    /// Código único que representa el motivo que provoco la baja del afiliado.
    /// </summary>
    public string MotivoBajaCodigo { get; set; } = null!;

    /// <summary>
    /// Número de contrato o póliza que asigna cada ARS a cada uno de sus afiliados, puede ser representado por el número acreditado de formulario de afiliación.
    /// </summary>
    public string AfiliadoContratoNumero { get; set; } = null!;

    /// <summary>
    /// Número que representan un lote de actualización desde una de las vista estadísticas que nos reporta UNIPAGO.
    /// </summary>
    public int NumeroSecuencia { get; set; }

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

    public virtual AfiliadosAfiliacionesTipoCatum AfiliacionTipoCodigoNavigation { get; set; } = null!;

    public virtual AfiliadosAfiliacionesRespuestasCatum AfiliacionesRespuestaCodigoNavigation { get; set; } = null!;

    public virtual AfiliadosEstatusCatum AfiliadoEstadoNumeroNavigation { get; set; } = null!;

    public virtual TssCiudadanosMaster AfiliadoNssNavigation { get; set; } = null!;

    public virtual AfiliadosTipoCatum AfiliadoTipoCodigoNavigation { get; set; } = null!;

    public virtual TssCiudadanosMaster AfiliadoTitularNssNavigation { get; set; } = null!;

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual AfiliadosMotivosBajaCatum MotivoBajaCodigoNavigation { get; set; } = null!;

    public virtual ComunesMunicipiosCatum MunicipioNumeroNavigation { get; set; } = null!;

    public virtual AfiliadosParentescoCatum ParentescoNumeroNavigation { get; set; } = null!;
}
