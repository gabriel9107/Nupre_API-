using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas36Tran
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

    /// <summary>
    /// Número unico asignado a cada ARS
    /// </summary>
    public int InstitucionNumero { get; set; }

    /// <summary>
    /// Número unico asignado a cada PSS
    /// Salud.
    /// </summary>
    public string PrestadoraNumero { get; set; } = null!;

    /// <summary>
    /// Número de seguridad social del afiliado
    /// </summary>
    public string Nss { get; set; } = null!;

    /// <summary>
    /// Número unico para una relación de procedimiento realizado a un afiliado
    /// </summary>
    public string EpisodioNumero { get; set; } = null!;

    /// <summary>
    /// Para indicar el tipo de atención del afiliado
    /// </summary>
    public string TipoAtencion { get; set; } = null!;

    /// <summary>
    /// Caracterizacion del servicio prestado
    /// </summary>
    public string TipoServicio { get; set; } = null!;

    /// <summary>
    /// Número del subgrupo del servicio  del PDSS  bajo el cual se presto la atencion al afiliado del PDSS
    /// </summary>
    public string SubGrupoNumero { get; set; } = null!;

    /// <summary>
    /// Fecha en la que el PSS presta servicio al afiliado.
    /// </summary>
    public string FechaRealizacion { get; set; } = null!;

    /// <summary>
    /// Número único del plan que el afiliado tiene contratado con la ARS 
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    /// <summary>
    /// Solo sera llenado cuando el tipo de servicio coresponda a una hospitalización medica o quirulgica
    /// </summary>
    public string FechaEgreso { get; set; } = null!;

    /// <summary>
    /// Solo sera llenado cuando el tipo de servicio coresponda a una hospitalización medica o quirulgica
    /// </summary>
    public string CircunstanciaEgreso { get; set; } = null!;

    /// <summary>
    /// Este campo es para ser completado con el diagnóstico dado al padecimiento del asegurado, el cual será seleccionado del Catálogo anexo del CIE 10.
    /// </summary>
    public string DiagnosticoPrincipal { get; set; } = null!;

    /// <summary>
    /// Este campo es para ser completado con el diagnóstico dado al padecimiento del asegurado, el cual será seleccionado del Catálogo anexo del CIE 10.
    /// </summary>
    public string DiagnosticoSecundario1 { get; set; } = null!;

    /// <summary>
    /// Este campo es para ser completado con el diagnóstico dado al padecimiento del asegurado, el cual será seleccionado del Catálogo anexo del CIE 10.
    /// </summary>
    public string DiagnosticoSecundario2 { get; set; } = null!;

    /// <summary>
    /// Este campo debe ser llenado en caso de ocurrir un evento o padecimiento inesperado ya sea clínico o quirúrgico. Se validará que el diagnóstico asignado se encuentre contenido en el Catálogo del CIE-10.
    /// </summary>
    public string Complicaciones { get; set; } = null!;

    /// <summary>
    /// Este campo debe ser completado en caso que se produzca el deceso  o muerte del asegurado. Ver Códigos CIE-10. Esta fecha deberá ser menor o igual a la Fecha de realización.
    /// </summary>
    public string Fallecimiento { get; set; } = null!;

    /// <summary>
    /// En este campo se consignará obligatoriamente el número de nacidos vivos, en caso de ocurrir este evento.
    /// </summary>
    public string RecienNacidoVivo { get; set; } = null!;

    /// <summary>
    /// En este campo se consignará obligatoriamente el número de recién nacidos muertos, en caso de ocurrir este evento.
    /// </summary>
    public string RecienNacidoMuerto { get; set; } = null!;

    /// <summary>
    /// Este campo se completará en caso de ser registrado un recién nacido muerto con la causa principal de muerte del mismo. Ver Códigos CIE-10; esto solo cuando el campo Recién Nacido Muerto, contenga información.
    /// </summary>
    public string CausaMuerteRecienNacido { get; set; } = null!;

    /// <summary>
    /// En este campo debe ser obligatorio su llenado en caso de que la atención corresponda a menores de 0-1 año no registrado como asegurado. Se consignará para este campo la letra M de Menor, de lo contrario A de Asegurado.
    /// </summary>
    public string Menor01AnioNoRegistrado { get; set; } = null!;

    /// <summary>
    /// OK = Activo , RE = Rechazado
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
