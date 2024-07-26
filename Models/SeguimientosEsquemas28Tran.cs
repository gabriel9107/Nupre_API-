using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas28Tran
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
    public int InstitucionNumero { get; set; }

    /// <summary>
    /// Número que especifica la Prestadora de Servicios de Salud.
    /// </summary>
    public string? PrestadorNumero { get; set; }

    /// <summary>
    /// Especifica si la ARS tiene contrato con el medico (Especificar S o N).
    /// </summary>
    public string? PrestadorContratado { get; set; }

    /// <summary>
    /// Campo que representa fecha de inicio del contrato con la ARS en formato (DDMMYYYY).
    /// </summary>
    public string? FechaContratoInicia { get; set; }

    /// <summary>
    /// Campo que representa fecha de término de contrato con la ARS en formato (DDMMYYYY).
    /// </summary>
    public string? FechaContratoTermina { get; set; }

    /// <summary>
    /// Número del Plan de Servicio de Salud Plan para el cual está contratado.
    /// </summary>
    public string? PlanNumero { get; set; }

    /// <summary>
    /// Número del Servicio para el cual está contratado para el plan en específico. Descargar Catalogo_Servicios_PSS.xls disponible en la O.V.
    /// </summary>
    public string? ServicioNumero { get; set; }

    /// <summary>
    /// Se indica con S o N, si el servicio contratado por la ARS, es propio de la PSS contratada o por lo contrario lo brinda a través de otra PSS.
    /// </summary>
    public string? ServicioPropioPss { get; set; }

    /// <summary>
    /// Número que especifica la Prestadora de Servicios de Salud.
    /// </summary>
    public string? PrestadorDondePrestaServicio { get; set; }

    public string? TipoPrestador { get; set; }

    /// <summary>
    /// Número único que identifica al Prestador de Servicio de Salud Institucional en el SIMON, donde el Profesional de la Salud presta los servicios específicos y para lo cual está contratado para un plan en específico. En caso de ser N = reportar cero (0).
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
