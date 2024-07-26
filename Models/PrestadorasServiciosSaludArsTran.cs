using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional temporal con los detalles de las Prestadoras de Servicios de Salud (PSS) Médicos, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasServiciosSaludArsTran
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    public int SeguimientoPeriodo { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Número del Plan de Servicio de Salud Plan para el cual está contratado.
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    /// <summary>
    /// Número del Servicio para el cual está contratado para el plan en específico. Descargar Catalogo_Servicios_PSS.xls disponible en la O.V.
    /// </summary>
    public byte PrestadoraServicioNumero { get; set; }

    /// <summary>
    /// Se indica con S o N, si el servicio contratado por la ARS, es propio de la PSS contratada o por lo contrario lo brinda a través de otra PSS.
    /// </summary>
    public string PrestadoraServicioPropio { get; set; } = null!;

    /// <summary>
    /// Especifica si la ARS tiene contrato con el medico (Especificar S o N).
    /// </summary>
    public string PrestadoraContratada { get; set; } = null!;

    public byte PrestadoraCategoriaNumero { get; set; }

    /// <summary>
    /// Número que especifica la Prestadora de Servicios de Salud.
    /// </summary>
    public int PrestadoraNumeroPrestaServicio { get; set; }

    /// <summary>
    /// Campo que representa fecha de inicio del contrato con la ARS en formato (DDMMYYYY).
    /// </summary>
    public int PrestadoraContratoDesdeFecha { get; set; }

    /// <summary>
    /// Campo que representa fecha de término de contrato con la ARS en formato (DDMMYYYY).
    /// </summary>
    public int PrestadoraContratoHastaFecha { get; set; }

    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

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

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual PlanesMaster PlanNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasMaster PrestadoraNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasServiciosCatum PrestadoraServicioNumeroNavigation { get; set; } = null!;
}
