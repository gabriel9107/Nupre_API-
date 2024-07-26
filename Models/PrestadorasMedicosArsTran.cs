using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las Prestadoras de Servicios de Salud (PSS) Médicos  contratadas por las ARS/ARL,  su fuente de datos es el esquema 27 procesado por el Robot Simon. 
/// </summary>
public partial class PrestadorasMedicosArsTran
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    public byte PlanTipoNumero { get; set; }

    public int SeguimientoPeriodo { get; set; }

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
    /// Fecha de inicio del contrato de la ARS con la PSS.
    /// </summary>
    public DateTime? MedicoContratoDesde { get; set; }

    /// <summary>
    /// Fecha de Termino del contrato de la ARS con la PSS.
    /// </summary>
    public DateTime? MedicoContratoHasta { get; set; }

    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

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

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasEspecialidadesCatum EspecialidadNumero1Navigation { get; set; } = null!;

    public virtual PrestadorasEspecialidadesCatum EspecialidadNumero2Navigation { get; set; } = null!;

    public virtual PrestadorasEspecialidadesCatum EspecialidadNumero3Navigation { get; set; } = null!;

    public virtual PlanesTipoCatum PlanTipoNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;
}
