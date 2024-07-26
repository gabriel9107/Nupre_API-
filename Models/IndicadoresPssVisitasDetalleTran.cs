using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional que contiene los  indicadores  (Preguntas realizadas en las visitas de evaluación de las PSS contratadas por las ARS) con sus repuestas levantadas en una visita realizada,  su fuente de datos los sistemas internos de la SISALRI
/// </summary>
public partial class IndicadoresPssVisitasDetalleTran
{
    /// <summary>
    /// Número único asignado automáticamente por el sistema por cada visita que se registra a una  prestadora  de servicio de salud de categoría institucional. Por cada prestadora este número se incrementa de 1 a N.
    /// </summary>
    public byte VisitaNumero { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Es un número único que identifica el tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
    /// </summary>
    public byte PrestadoraTipoNumero { get; set; }

    /// <summary>
    /// Numero de versión de los formularios generados con las preguntas (Indicadores) que se utilizan en los procesos de visitas de supervisión que se realiza a una  prestadora  de servicio de salud de categoría institucional.
    /// </summary>
    public byte IndicadorVersionNumero { get; set; }

    /// <summary>
    /// Número único de cada pregunta (Indicador) que se utiliza en los procesos de visitas de supervisión que se realiza a una  prestadora  de servicio de salud de categoría institucional.
    /// </summary>
    public short IndicadorNumero { get; set; }

    /// <summary>
    /// Número único que identifica cada uno de los regímenes definidos en la ley 87-01, (Contributivo, Subsidiado y Contributivo Subsidiado).
    /// </summary>
    public byte RegimenNumero { get; set; }

    /// <summary>
    /// Nos indica si una pregunta  (Indicador) acepta un valor numérico  como respuesta,  en los formularios de las visitas de supervisión a la prestadora de servicio de salud institucional es cerrado.
    /// </summary>
    public int? IndicadorRespuestaValor { get; set; }

    /// <summary>
    /// Nos indica si una pregunta  (Indicador) es cerrada solo acepta (S/N) como respuesta, en los formularios de las visitas de supervisión a la prestadora de servicio de salud institucional es cerrado.
    /// </summary>
    public string? IndicadorRespuestaSiNo { get; set; }

    /// <summary>
    /// Detalle de las observaciones que se registraron a partir de un proceso de una visita de supervisión a la prestadora de servicio de salud institucional, para una pregunta (indicador) específico.
    /// </summary>
    public string? IndicadorRespuestaObservaciones { get; set; }

    /// <summary>
    /// Es la fecha en que se lleno el formulario de visitas.
    /// </summary>
    public DateTime? IndicadorRespuestaFechaLlenado { get; set; }

    /// <summary>
    /// Nombre de la persona (Contacto) que participo de parte de la prestadora  en una visita de supervisión a la prestadora de servicio de  salud institucional.
    /// </summary>
    public string? IndicadorRespuestaEntrevistadoNombre { get; set; }

    /// <summary>
    /// Descripción del cargo de la persona (Contacto) que participo de parte de la prestadora  en una visita de supervisión a la prestadora de servicio de  salud institucional.
    /// </summary>
    public string? IndicadorRespuestaEntrevistadoCargo { get; set; }

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

    public virtual IndicadoresPssTipoPreguntasCatum IndicadoresPssTipoPreguntasCatum { get; set; } = null!;

    public virtual IndicadoresPssVisitasMaster IndicadoresPssVisitasMaster { get; set; } = null!;
}
