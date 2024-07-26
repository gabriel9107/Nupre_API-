using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional,  que contiene los detalles de los Accidentes de Transito no laborables cubiertos por la ARS,  su fuente de datos es el esquema 37 procesado por el Robot Simon. 
/// </summary>
public partial class AccidentesTransitoArsRecargasTran
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
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Fecha del Accidente.
    /// </summary>
    public int AccidenteFecha { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long AfiliadoNss { get; set; }

    /// <summary>
    /// Número único que asigna la ARS a cada autorización de cobertura en su sistema.
    /// </summary>
    public string AutorizacionNumero { get; set; } = null!;

    /// <summary>
    /// Hora del Accidente.
    /// </summary>
    public byte AccidenteHora { get; set; }

    /// <summary>
    /// Origen del Accidente.
    /// </summary>
    public byte OrigenNumero { get; set; }

    /// <summary>
    /// Tipo de Vehículo en el cual ocurrió el Accidente.
    /// </summary>
    public byte VehiculoTipoNumero { get; set; }

    /// <summary>
    /// Posición del lesionado en el Accidente.
    /// </summary>
    public byte PosicionLesionadoNumero { get; set; }

    /// <summary>
    /// Con que Colisionó el Afiliado.
    /// </summary>
    public byte ColisionTipoNumero { get; set; }

    /// <summary>
    /// Municipio donde ocurrió el Accidente.
    /// </summary>
    public short MunicipioNumero { get; set; }

    /// <summary>
    /// Diagnóstico Inicial (código CIE).
    /// </summary>
    public string DiagnosticoInicialCodigo { get; set; } = null!;

    /// <summary>
    /// Diagnóstico Final (código CIE).
    /// </summary>
    public string DiagnosticoFinalCodigo { get; set; } = null!;

    /// <summary>
    /// Cambio del Origen del Accidente.
    /// </summary>
    public byte OrigenNumeroCambio { get; set; }

    /// <summary>
    /// Fecha en que se actualizó el origen del Accidente. 
    /// </summary>
    public int OrigenFechaActualizacion { get; set; }

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
