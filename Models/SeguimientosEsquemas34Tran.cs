using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas34Tran
{
    /// <summary>
    /// Código del seguimiento de la carga
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número de seguimiento del lote de carga
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Número que indetifica la lineas de errores del archivo
    /// </summary>
    public long ArchivoLinea { get; set; }

    public int InstitucionNumero { get; set; }

    public string PlanNumero { get; set; } = null!;

    public string PolizaTitularNumero { get; set; } = null!;

    /// <summary>
    /// Número de Cédula asignada por la Junta Central
    /// Electoral
    /// </summary>
    public string CedulaTitular { get; set; } = null!;

    /// <summary>
    /// Clave del tipo de documento que comprueba la nacionalidad del trabajador.
    /// </summary>
    public string ClaveTipoDocumentoProbatorio { get; set; } = null!;

    /// <summary>
    /// Número de Cédula asignada por la Junta Central Electoral, en caso de
    /// que el dependiente sea mayor de edad
    /// </summary>
    public string DocumentoDependiente { get; set; } = null!;

    /// <summary>
    /// Primer nombre del dependiente
    /// </summary>
    public string PrimerNombre { get; set; } = null!;

    /// <summary>
    /// Segundo nombre del dependiente
    /// </summary>
    public string SegundoNombre { get; set; } = null!;

    /// <summary>
    /// Primer Apellido del dependiente.
    /// </summary>
    public string PrimerApellido { get; set; } = null!;

    /// <summary>
    /// Segundo Apellido del dependiente.
    /// </summary>
    public string SegundoApellido { get; set; } = null!;

    /// <summary>
    /// Sexo del dependiente. M = Masculino F = Femenino
    /// </summary>
    public string Sexo { get; set; } = null!;

    /// <summary>
    /// Clave del catalogo de parentescos. 
    /// </summary>
    public string Parentesco { get; set; } = null!;

    /// <summary>
    /// D/A Indica si el dependiente es directo o adicional
    /// </summary>
    public string TipoDependiente { get; set; } = null!;

    /// <summary>
    /// Indica si el dependiente es o no discapacitado.
    /// S = SI y N = NO.
    /// </summary>
    public string Discapacitado { get; set; } = null!;

    public string InicioVigencia { get; set; } = null!;

    public string FechaUltimoPagoFactura { get; set; } = null!;

    public string PrimaComercialMensual { get; set; } = null!;

    public string ModalidadPago { get; set; } = null!;

    public string ClaveAgentePromotor { get; set; } = null!;

    public string Estado { get; set; } = null!;

    /// <summary>
    /// OK= Activo , RE=Rechazado
    /// </summary>
    public string RegistroValidacionEstado { get; set; } = null!;

    /// <summary>
    /// Número que identifican  los errores del del archivo de carga 
    /// </summary>
    public string RegistroValidacionErrores { get; set; } = null!;

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
