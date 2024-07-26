using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los errores de las solicitudes de traspasos pro unificación familiar que son rechazadas, no llegan al proceso de asignación de NUCUF, su fuente de datos son las vistas de traspasos publicadas por UNIPAGO.
/// </summary>
public partial class TraspasosNucufRechazosTran
{
    /// <summary>
    /// Número único de control de traspaso, número asignado a cada traspaso de unificación familiar, desde su solicitud hasta su operación final.
    /// </summary>
    public int Nucuf { get; set; }

    /// <summary>
    /// Número único de rechazo a una solicitud de traspaso, cuando este es mayor que cero es porque no se genero el NUCT.
    /// </summary>
    public int RechazoNumero { get; set; }

    /// <summary>
    /// Número único que especifica el tipo de traspaso.
    /// </summary>
    public byte TraspasoTipoNumero { get; set; }

    /// <summary>
    /// Es el código que clasifica los afiliados en T = Titulares (Quien representa al núcleo familiar) D = Dependientes  (Hijos y Conjugues) y A = Adicionales (Padres, Hijos con mayoría de edad cumplida 18 o 21, otros familiares dependientes económicamente).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long AfiliadoTitularNss { get; set; }

    /// <summary>
    /// Es único número de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string AfiliadoTitularCedula { get; set; } = null!;

    /// <summary>
    /// Representante de la ARS Destino que registro la solicitud de traspaso por unificación familiar.
    /// </summary>
    public string CedulaRepresentante { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long AfiliadoDependienteNss { get; set; }

    /// <summary>
    /// Es único número de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string AfiliadoDependienteCedula { get; set; } = null!;

    /// <summary>
    /// Número único que representa el parentesco entre un dependiente y el titular de un núcleo familiar en el Seguro Familiar de Salud (SFS).
    /// </summary>
    public byte ParentescoNumeroOrigen { get; set; }

    /// <summary>
    /// Número único que representa el parentesco entre un dependiente y el titular de un núcleo familiar en el Seguro Familiar de Salud (SFS).
    /// </summary>
    public byte ParentescoNumeroDestino { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long NssTitularDependienteSolicitado { get; set; }

    /// <summary>
    /// Es único número de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string CedulaTitularDependienteSolicitado { get; set; } = null!;

    /// <summary>
    /// Numero de municipio del acta de nacimiento de la persona  registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string ActaNacimientoMunicipio { get; set; } = null!;

    /// <summary>
    /// Número de la oficialía civil correspondiente al  acta de nacimiento de la persona  registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string ActaNacimientoOficialia { get; set; } = null!;

    /// <summary>
    /// Número de folio  del acta de nacimiento de la persona  registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string ActaNacimientoLibro { get; set; } = null!;

    /// <summary>
    /// Número de folio  del acta de nacimiento de la persona  registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string ActaNacimientoFolio { get; set; } = null!;

    /// <summary>
    /// Número de acta  del documento de acta de nacimiento de la persona  registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string ActaNacimientoNumero { get; set; } = null!;

    /// <summary>
    /// Año correspondiente al acta de nacimiento de la persona  registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string ActaNacimientoAnio { get; set; } = null!;

    /// <summary>
    /// Es la fecha de nacimiento de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string AfiliadoFechaNacimiento { get; set; } = null!;

    /// <summary>
    /// Sexo de la persona (Afiliado)  (F=femenino, M=masculino).
    /// </summary>
    public string AfiliadoSexo { get; set; } = null!;

    /// <summary>
    /// Indica si el afiliado que está en el proceso de traspaso por unificación familiar cotiza a la TSS.
    /// </summary>
    public string AfiliadoCotiza { get; set; } = null!;

    /// <summary>
    /// Indica si traspaso por unificación familiar fue autorizado por la SISALRIL.
    /// </summary>
    public string AutorizadoSisalril { get; set; } = null!;

    /// <summary>
    /// Fecha en que un afiliado solicita su afiliación a una Administradora de Riesgos de Salud (ARS) para un Plan de Servicios de Salud (PDSS, Voluntarios, Complementario, Especial, etc.).
    /// </summary>
    public DateTime AfiliadoFechaSolicitud { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public int ArsOrigen { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public int ArsDestino { get; set; }

    /// <summary>
    /// Numero de lote con el cual UNIPAGO notificó a la ARS origen del traspaso de su afiliado.
    /// </summary>
    public long LoteNotificacionArsOrigen { get; set; }

    /// <summary>
    /// Fecha en que se hace efectivo el proceso de traspaso por unificación familiar cotiza a la TSS.
    /// </summary>
    public DateTime? FechaCierre { get; set; }

    /// <summary>
    /// Estado en que se encuentra el NUCUF del proceso de traspaso por unificación familiar cotiza a la TSS.
    /// </summary>
    public string NucufEstado { get; set; } = null!;

    /// <summary>
    /// Motivo por e cual se rechazo una solicitud de traspaso.
    /// </summary>
    public string RechazoMotivo { get; set; } = null!;

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
}
