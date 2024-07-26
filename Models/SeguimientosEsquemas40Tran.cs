using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas40Tran
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

    /// <summary>
    /// Número unico asignado a cada ARS
    /// </summary>
    public string ArsNumero { get; set; } = null!;

    /// <summary>
    /// Número unico asignado a cada PSS
    /// </summary>
    public string PrestadoraNumero { get; set; } = null!;

    /// <summary>
    /// Número de seguridad social del afiliado
    /// </summary>
    public string Nss { get; set; } = null!;

    /// <summary>
    /// Número único para una relación de actividades/servicios realizados, el cual se repite para cada afiliado que participa en el evento
    /// </summary>
    public string EventoNumero { get; set; } = null!;

    /// <summary>
    /// Esto solo aplica para los Subgrupos del Grupo 1 del Catalogo de Prestaciones del PDSS.
    /// </summary>
    public string SubGrupoNumero { get; set; } = null!;

    /// <summary>
    /// Son las actividades o servicios provistos o realizados al afiliado
    /// </summary>
    public string CoberturaNumero { get; set; } = null!;

    /// <summary>
    /// Fecha en la que la PSS presta el servicio al afiliado. (DDMMAAAA)
    /// </summary>
    public string FechaRealizacion { get; set; } = null!;

    /// <summary>
    /// Monto pagado por evento.
    /// </summary>
    public string MontoEvento { get; set; } = null!;

    /// <summary>
    /// Zona donde fue brindado la actividad o servicio al afiliado.
    /// </summary>
    public string MunicipioNumero { get; set; } = null!;

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
