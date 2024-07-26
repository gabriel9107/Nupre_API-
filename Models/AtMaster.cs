using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtMaster
{
    /// <summary>
    /// Número unico que identifica a la ARS que reporte el accidente de transito.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número del informe que se esta reportando, del 1 al 52.
    /// </summary>
    public byte AtInformeNumero { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long CiudadanoNss { get; set; }

    /// <summary>
    /// Fecha en que se generó el informe por Accidente de Transito: Día(dd), Mes (mm) y Año (AAAA).
    /// </summary>
    public DateTime AtInformeFechaId { get; set; }

    /// <summary>
    /// Identificación del tipo del origen del reclamo:  1. Tránsito 2. Laboral 3. Salud 4. Otro.
    /// </summary>
    public byte AtOrigenNumero { get; set; }

    /// <summary>
    /// Identificación del tipo del origen del reclamo:  1. Tránsito 2. Laboral 3. Salud 4. Otro.
    /// </summary>
    public byte AtOrigenNumeroCambio { get; set; }

    /// <summary>
    /// Fecha en que ocurrió el Accidente: Día(dd), Mes (mm) y Año (AAAA).
    /// </summary>
    public DateTime AtFecha { get; set; }

    /// <summary>
    /// Hora en que ocurrió el Accidente: Día(dd), Mes (mm) y Año (AAAA).
    /// </summary>
    public string AtHora { get; set; } = null!;

    /// <summary>
    /// Número único que identifica el tipo de Vehiculo en el accidente.
    /// </summary>
    public byte VehiculoTipoNumero { get; set; }

    /// <summary>
    /// Número único que Identifica el número posición del lesionado en el accidente.
    /// </summary>
    public byte PosicionLesionadoNumero { get; set; }

    /// <summary>
    /// Número único que identifica el tipo de colisión del accidente.
    /// </summary>
    public byte ColisionTipoNumero { get; set; }

    /// <summary>
    /// Número único de la provincia según catálogo de la JCE.  (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public short ProvinciaNumero { get; set; }

    /// <summary>
    /// Código inicial de diagnostico CIE para accidentes de transito.
    /// </summary>
    public string DiagnosticoCieCodigoInicial { get; set; } = null!;

    /// <summary>
    /// Código final de diagnostico CIE para accidentes de transito.
    /// </summary>
    public string DiagnosticoCieCodigoFinal { get; set; } = null!;

    /// <summary>
    /// Estado. A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del Usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de Registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual ICollection<AtEventosTran> AtEventosTrans { get; set; } = new List<AtEventosTran>();

    public virtual AtCalendarioTran AtInformeFecha { get; set; } = null!;

    public virtual AtOrigenCatum AtOrigenNumeroCambioNavigation { get; set; } = null!;

    public virtual AtOrigenCatum AtOrigenNumeroNavigation { get; set; } = null!;

    public virtual TssCiudadanosMaster CiudadanoNssNavigation { get; set; } = null!;

    public virtual AtColisionTipoCatum ColisionTipoNumeroNavigation { get; set; } = null!;

    public virtual AtDiagnosticosCieCatum DiagnosticoCieCodigoFinalNavigation { get; set; } = null!;

    public virtual AtDiagnosticosCieCatum DiagnosticoCieCodigoInicialNavigation { get; set; } = null!;

    public virtual AtPosicionLesionadoCatum PosicionLesionadoNumeroNavigation { get; set; } = null!;

    public virtual ComunesProvinciasCatum ProvinciaNumeroNavigation { get; set; } = null!;

    public virtual AtVehiculoTipoCatum VehiculoTipoNumeroNavigation { get; set; } = null!;
}
