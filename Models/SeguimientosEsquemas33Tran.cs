using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas33Tran
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

    public int? InstitucionNumero { get; set; }

    /// <summary>
    /// Numero único del Plan que el afiliado tiene contratado con la ARS. (Asignado por la SISALRIL) 
    /// (SIMON\Consultas).
    /// </summary>
    public string? PlanNumero { get; set; }

    public string? PolizaTitularNumero { get; set; }

    /// <summary>
    /// Número de Cédula asignada por la Junta Central Electoral.
    /// </summary>
    public string? CedulaTitular { get; set; }

    public string? InicioVigencia { get; set; }

    public string? FechaUltimoPagoFactura { get; set; }

    public string? PrimaComercialMensual { get; set; }

    public string? ModalidadPago { get; set; }

    public string? Estado { get; set; }

    /// <summary>
    /// (La cédula o RNC del promotor será su clave ) 
    /// </summary>
    public string? ClaveAgentePromotor { get; set; }

    /// <summary>
    /// OK= Activo , RE=Rechazado
    /// </summary>
    public string? RegistroValidacionEstado { get; set; }

    /// <summary>
    /// Número que identifican  los errores del del archivo de carga 
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
