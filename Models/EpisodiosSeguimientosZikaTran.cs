using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Esta tabla contiene el reporte de casos de los Afiliados para la vigilancia de las complicaciones por Zika, reportados por las ARS.
/// </summary>
public partial class EpisodiosSeguimientosZikaTran
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long AfiliadoNss { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Nombre del prestador de servicio de salud (PSS) que entrego los servicio (Institucional o Médico).
    /// </summary>
    public string PrestadoraNombre { get; set; } = null!;

    /// <summary>
    /// Es único número de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string AfiliadoCedula { get; set; } = null!;

    /// <summary>
    /// Indica si el Afiliado es un caso probable del Zika virus (Si, No).
    /// </summary>
    public string EpisodioCasoProbableZika { get; set; } = null!;

    /// <summary>
    /// Indica el manejo que se le dió al Afiliado con síntomas del Zika (Ambulatorio, Intrahospitalario).
    /// </summary>
    public string EpisodioManejo { get; set; } = null!;

    /// <summary>
    /// Indica si el Afiliado es una mujer embarazada (Si, No).
    /// </summary>
    public string EpisodioEmbarazada { get; set; } = null!;

    /// <summary>
    /// Representa el Trimestre de gestación de la Afiliada de ser una persona Embarazada.
    /// </summary>
    public string EpisodioTrimestreGestacion { get; set; } = null!;

    /// <summary>
    /// Indica si el recién nacido tiene Microcefalia (Si, No).
    /// </summary>
    public string EpisodioRecienNacidoMicrocefalia { get; set; } = null!;

    /// <summary>
    /// Indica si el Afiliado tiene el sídrome neurológico de Guilliain Barré. (Si, No).
    /// </summary>
    public string EpisodioSindromeNeurologicoGuillainBarre { get; set; } = null!;

    /// <summary>
    /// Descripción otros Diagnosticos que pueda presentar el afiliado.
    /// </summary>
    public string EpisodioOtroDiagnostico { get; set; } = null!;

    /// <summary>
    /// Indica la condición el Afiliado egresado (Vivo ó Muerto).
    /// </summary>
    public string EpisodioCondicionEgreso { get; set; } = null!;

    /// <summary>
    /// Indica si el Afiliado estuvo en UCI (Unidad de Cuidados Intensivos).
    /// </summary>
    public string EpisodioUsoUci { get; set; } = null!;

    /// <summary>
    /// Número de Secuencia del Registro.
    /// </summary>
    public int RegistroSecuencia { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumeroDti { get; set; }

    public string PlanPensionadoDti { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
