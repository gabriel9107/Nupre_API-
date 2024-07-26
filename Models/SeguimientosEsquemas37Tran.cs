using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional, de los Reporte de Accidentes de Tránsitos no Laborales cubierto por la ARS, loa cuales son registrados de las ARS, con los datos que durante la validación dieron errores, su fuente de datos es el Esquema 37 procesado por el Robot Simon.
/// </summary>
public partial class SeguimientosEsquemas37Tran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico.
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Número único asignado a cada registro del archivo temporal de una carga de esquema especifica (Seguimiento + Lote).
    /// </summary>
    public long ArchivoLinea { get; set; }

    /// <summary>
    /// Número de la institución que es o a la que pertenece la ARS.
    /// </summary>
    public int InstitucionNumero { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public string? NssAfiliado { get; set; }

    /// <summary>
    /// Origen del Accidente.
    /// </summary>
    public string? OrigenNumero { get; set; }

    /// <summary>
    /// Fecha del Accidente.
    /// </summary>
    public string? AccidenteFecha { get; set; }

    /// <summary>
    /// Número único que asigna la ARS a cada autorización de cobertura en su sistema.
    /// </summary>
    public string? NumeroAutorizacion { get; set; }

    /// <summary>
    /// Hora del Accidente.
    /// </summary>
    public string? AccidenteHora { get; set; }

    /// <summary>
    /// Tipo de Vehículo en el cual ocurrió el Accidente.
    /// </summary>
    public string? TipoVehiculoNumero { get; set; }

    /// <summary>
    /// Posición del lesionado en el Accidente.
    /// </summary>
    public string? PosicionLesionadoNumero { get; set; }

    /// <summary>
    /// Con que Colisionó el Afiliado.
    /// </summary>
    public string? TipoColisionNumero { get; set; }

    /// <summary>
    /// Municipio donde ocurrió el Accidente.
    /// </summary>
    public string? MunicipioNumero { get; set; }

    /// <summary>
    /// Diagnóstico Inicial (código CIE).
    /// </summary>
    public string? DiagnosticoInicialCodigo { get; set; }

    /// <summary>
    /// Diagnóstico Final (código CIE).
    /// </summary>
    public string? DiagnosticoFinalCodigo { get; set; }

    /// <summary>
    /// Cambio del Origen del Accidente.
    /// </summary>
    public string? NuevoOrigen { get; set; }

    /// <summary>
    /// Fecha en que se actualizó el origen del Accidente. 
    /// </summary>
    public string? FechaActualizacionOrigen { get; set; }

    /// <summary>
    /// Representa el estado en que se encuentra un registro en una tabla de validación del Esquema (OK=Activo, RE=Rechazado).
    /// </summary>
    public string? RegistroValidacionEstado { get; set; }

    /// <summary>
    /// Número que identifica los errores del archivo de carga.
    /// </summary>
    public string? RegistroValidacionErrores { get; set; }

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
