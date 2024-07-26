using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas26Tran
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
    /// Número que identifica la ARS
    /// </summary>
    public int InstitucionNumero { get; set; }

    public string ArsNumero { get; set; } = null!;

    /// <summary>
    /// Número de la prestadora de servicios de salud
    /// </summary>
    public string PrestadoraNumero { get; set; } = null!;

    /// <summary>
    /// Fecha Inicial del contrato 
    /// </summary>
    public string ContratoDesde { get; set; } = null!;

    /// <summary>
    /// Fecha final del contrato
    /// </summary>
    public string ContratoHasta { get; set; } = null!;

    /// <summary>
    /// Indica el Estado de la
    /// Prestadora. (A/ B/ C )
    /// </summary>
    public string Estatus { get; set; } = null!;

    /// <summary>
    /// Este campo contendrá la cantidad de médicos
    /// que posee la prestadora
    /// </summary>
    public string NumeroMedicos { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio
    /// contratado con la prestadora. Colocando
    /// S=SI o N=NO.
    /// </summary>
    public string PrevencionYPromocion { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la
    /// Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string ConsultaAmbulatoria { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la
    /// Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string ServiciosOdontologicos { get; set; } = null!;

    /// <summary>
    /// Indica si la ARS tiene este servicio contratado con la Prestadora, Colocando
    /// S=SI o N=NO
    /// </summary>
    public string Emergencias { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio
    /// contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string UnidadCuidadosIntensivosQuemados { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string Hospitalizacion { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PartosCesarias { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio
    /// contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string Cirugias { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string OtrosApoyosDiagnosticos { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string AtencionAltoCosto { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string Rehabilitacion { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string Farmacia { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string TrasladoPacientes { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string PrimerNivelAtencion { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string SegundoNivelAtencion { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string TercerNivelAtencion { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string UnidadCuidadosIntensivos { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string Laboratorios { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string Imagenes { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string ContratadaPdss { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string ContratadaPlanesComplementarios { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string ContratadaPlanesVoluntarios { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string ContratadaPlanesPrepagadosOMedicinaEspecial { get; set; } = null!;

    /// <summary>
    /// Este campo indica si la ARS tiene este servicio contratado con la Prestadora, Colocando S=SI o N=NO
    /// </summary>
    public string Optica { get; set; } = null!;

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
