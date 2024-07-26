using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class EpisodiosPnaTran
{
    public long EpisodioNumero { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumeroRegional { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long CiudadanoNss { get; set; }

    public byte EpisodioRecienNacidos { get; set; }

    public DateTime? EpisodioRecienFecha { get; set; }

    public string EpisodioFacturaNumero { get; set; } = null!;

    public byte AtencionPnaTipoNumero { get; set; }

    public string FrecuenciaCodigo { get; set; } = null!;

    public string? HistoriaClinicaNumero { get; set; }

    public string? FichaFamiliarNumero { get; set; }

    public byte IntervencionNumero { get; set; }

    /// <summary>
    /// Es el código de una enfermedad o padecimiento y pertenece al código de la Clasificación Internacional de las enfermedades (CIE) , esta clasificación es de la Organización Mundial de la Salud (OMS).
    /// </summary>
    public string Cie10Codigo { get; set; } = null!;

    public string RecurrenciaDiagnosticoCodigo { get; set; } = null!;

    /// <summary>
    /// Numero único de cobertura que representa un  insumo, procedimiento médico, material, fármaco,  servicio  general que fue o puede ser prestado.
    /// </summary>
    public short CoberturaNumero { get; set; }

    public string VacunaDosisCodigo { get; set; } = null!;

    public byte ReferenciaTipoNumero { get; set; }

    public byte CausaReferenciaCodigo { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumeroReferido { get; set; }

    public string PersonalTipoCodigo { get; set; } = null!;

    public DateTime EpisoidoAtencionFecha { get; set; }

    public DateTime EpisodioFacturaFecha { get; set; }

    public DateTime EpisodioPagoFecha { get; set; }

    public decimal EpisodioValorReclamado { get; set; }

    public decimal EpisodioValorPagado { get; set; }

    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

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
