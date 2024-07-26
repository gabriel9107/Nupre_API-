using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional temporal con los detalles de las Prestadoras de Servicios de Salud (PSS) Médicos, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasMedicosArsTemporalTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Es único número de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string MedicoCedula { get; set; } = null!;

    /// <summary>
    /// Numero de la especialidad médica. 
    /// </summary>
    public short EspecialidadNumero1 { get; set; }

    /// <summary>
    /// Numero de la especialidad médica. 
    /// </summary>
    public short EspecialidadNumero2 { get; set; }

    /// <summary>
    /// Numero de la especialidad médica. 
    /// </summary>
    public short EspecialidadNumero3 { get; set; }

    /// <summary>
    /// Indica con S o N si el Médico contratado por  la ARS tiene o no contrato firmado.
    /// </summary>
    public string MedicoTieneContrato { get; set; } = null!;

    /// <summary>
    /// Nos indica con (S/N) si el prestador de servicio de salud (PSS) contratado por la  ARS, fue contratado para presta servicios a sus afiliados bajo el Plan de Servicios de Salud (PDSS) o el PBS.
    /// </summary>
    public string MedicoContratadoPlanPdss { get; set; } = null!;

    /// <summary>
    /// Nos indica con (S/N) si el prestador de servicio de salud (PSS) contratado por la  ARS, fue contratado para presta servicios a sus afiliados bajo los Planes Complementarios.
    /// </summary>
    public string MedicoContratadoPlanComplementario { get; set; } = null!;

    /// <summary>
    /// Nos indica con (S/N) si el prestador de servicio de salud (PSS) contratado por la  ARS, fue contratado para presta servicios a sus afiliados bajo los Planes Voluntarios.
    /// </summary>
    public string MedicoContratadoPlanVoluntario { get; set; } = null!;

    /// <summary>
    /// Nos indica con (S/N) si el prestador de servicio de salud (PSS) contratado por la  ARS, fue contratado para presta servicios a sus afiliados bajo los Plan Especiales y de Medicina Pre pagada.
    /// </summary>
    public string MedicoContratadoPlanMedicinaEspecial { get; set; } = null!;

    /// <summary>
    /// Nos indica con (S/N) si el prestador de servicio de salud (PSS) contratado por la  ARS, fue contratado para presta servicios a sus afiliados bajo los Plan Especiales y de Medicina Pre pagada.
    /// </summary>
    public string MedicoContratadoPlanPensionados { get; set; } = null!;

    /// <summary>
    /// Fecha de inicio del contrato de la ARS con la PSS.
    /// </summary>
    public DateTime? MedicoContratoDesde { get; set; }

    /// <summary>
    /// Fecha de Termino del contrato de la ARS con la PSS.
    /// </summary>
    public DateTime? MedicoContratoHasta { get; set; }

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
