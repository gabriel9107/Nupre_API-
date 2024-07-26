using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas31Tran
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

    public int InstitucionNumero { get; set; }

    /// <summary>
    /// Numero único para cada plan asignado por la
    /// SISALRIL a su ARS. 
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    public string PolizaNumero { get; set; } = null!;

    public string ClaveAgentePromotor { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social del titular reportado. 
    /// </summary>
    public string NssTitular { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social del dependiente
    /// reportado.
    /// </summary>
    public string NssDependiente { get; set; } = null!;

    /// <summary>
    /// Identifica el tipo de afiliado,especificando T=Titular,
    /// D= Dependiente, A=Adicional
    /// </summary>
    public string TipoAfiliado { get; set; } = null!;

    /// <summary>
    /// Relación familiar del afiliado reportado. Ver catalogo de
    /// parentesco. 
    /// </summary>
    public string Parentesco { get; set; } = null!;

    public string InicioVigencia { get; set; } = null!;

    public string FechaUltimoPagoFactura { get; set; } = null!;

    public string PrimaComercialMensual { get; set; } = null!;

    public string ModalidadPago { get; set; } = null!;

    /// <summary>
    /// Estado del Afiliado relacionado al Plan (Alta/Baja)
    /// </summary>
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
