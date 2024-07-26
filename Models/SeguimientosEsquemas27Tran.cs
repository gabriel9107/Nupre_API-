using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas27Tran
{
    /// <summary>
    /// Código del seguimiento de la carga
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número de seguimiento del lote de carga
    /// </summary>
    public int SeguimientoLote { get; set; }

    /// <summary>
    /// Número que indetifica la lineas de errores del archivo
    /// </summary>
    public long ArchivoLinea { get; set; }

    /// <summary>
    /// Número que representa el código de la entidad emisora
    /// </summary>
    public int? InstitucionesNumero { get; set; }

    /// <summary>
    /// Número de documento de indetidad electoral del medico.
    /// </summary>
    public string? MedicoCedula { get; set; }

    /// <summary>
    /// Número que especifica la Prestadora de Servicios de Salud.
    /// </summary>
    public string? PrestadoraNumero { get; set; }

    /// <summary>
    /// Numero de Especialidad Principal del Medico.
    /// </summary>
    public string? Especialidad1 { get; set; }

    /// <summary>
    /// Numero de la 2da Especialidad del Medico.
    /// </summary>
    public string? Especialidad2 { get; set; }

    /// <summary>
    /// Numero de la 3ra Especialidad del Medico.
    /// </summary>
    public string? Especialidad3 { get; set; }

    /// <summary>
    /// Especifica si la ARS tiene contrato con el medico (Especificar S o N).
    /// </summary>
    public string? Contratado { get; set; }

    /// <summary>
    /// Campo que representa fecha de inicio del contrado (DDMMYYYY).
    /// </summary>
    public string? ContratoDesde { get; set; }

    /// <summary>
    /// Campo que representa fecha de término de contrato (DDMMYYYY).
    /// </summary>
    public string? ContratoHasta { get; set; }

    /// <summary>
    /// Especifica si la ARS tiene contrato con el medico para el Plan PDSS. (Especificar S o N).
    /// </summary>
    public string? ContratoPlanPdss { get; set; }

    /// <summary>
    /// Especifica si la ARS tiene contrato con el medico para Planes Complementarios. (Especificar S o N).
    /// </summary>
    public string? ContratoPlanComplementario { get; set; }

    /// <summary>
    /// Especifica si la ARS tiene contrato con el medico para Planes Voluntarios. (Especificar S o N).
    /// </summary>
    public string? ContratoPlanVoluntario { get; set; }

    /// <summary>
    /// Especifica si la ARS tiene contrato con el medico para Planes Especiales. (Especificar S o N).
    /// </summary>
    public string? ContratoPlanEpeciales { get; set; }

    /// <summary>
    /// Estado del presdor de servicios
    /// </summary>
    public string? PrestadorEstado { get; set; }

    /// <summary>
    /// OK = Activo, RE = Rechazado.
    /// </summary>
    public string? RegistroValidacionEstado { get; set; }

    /// <summary>
    /// Número que identifica los posibles errores reportados
    /// </summary>
    public string? RegistroValidacionErrores { get; set; }

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
}
