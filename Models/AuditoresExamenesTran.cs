﻿using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AuditoresExamenesTran
{
    /// <summary>
    /// Número único que identifica cada examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public int ExamenNumero { get; set; }

    public string PromotorCedula { get; set; } = null!;

    /// <summary>
    /// Número único que identifica un período (Rango de fecha) en el cual se procedió a habilitar la toma de exámenes en las actividades de evaluación de los procesos de acreditación.
    /// </summary>
    public short PeriodoNumero { get; set; }

    public short? DisposicionNumero { get; set; }

    public byte ExamenPreguntas { get; set; }

    public byte ExamenPeriodoSecuencia { get; set; }

    public byte ExamenEstadoNumero { get; set; }

    /// <summary>
    /// Fecha y hora en que inició una persona  un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public DateTime? ExamenFechaInicio { get; set; }

    /// <summary>
    /// Fecha y hora en que terminó una persona  un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public DateTime? ExamenFechaFinal { get; set; }

    /// <summary>
    /// Número único que identifica un período (Rango de fecha) en el cual se procedió a habilitar la toma de exámenes en las actividades de evaluación de los procesos de acreditación.
    /// </summary>
    public byte ExamenTiempoMinutos { get; set; }

    /// <summary>
    /// Número único que identifica un período (Rango de fecha) en el cual se procedió a habilitar la toma de exámenes en las actividades de evaluación de los procesos de acreditación.
    /// </summary>
    public byte ExamenTiempoSegundos { get; set; }

    /// <summary>
    /// Serial generado para un recibo de resultado de un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public string ExamenReciboSerial { get; set; } = null!;

    /// <summary>
    /// Representa la puntuación obtenida por un Promotor de Saludral finalizar su exámen.
    /// </summary>
    public int ExamenPuntuacion { get; set; }

    public byte ExamenPuntuacionMinima { get; set; }

    /// <summary>
    /// Indica el Estatus del Promotor, solo aplica para los estados 0 = No Acreditado y 1 = Acreditado, va a depender de si el promotor aprueba o no.
    /// </summary>
    public byte PromotorEstadoNumero { get; set; }

    public byte HorarioNumero { get; set; }

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

    public virtual ICollection<AuditoresExamenesDetallesTran> AuditoresExamenesDetallesTrans { get; set; } = new List<AuditoresExamenesDetallesTran>();

    public virtual ICollection<AuditoresExamenesRequerimientosTran> AuditoresExamenesRequerimientosTrans { get; set; } = new List<AuditoresExamenesRequerimientosTran>();

    public virtual AuditoresExamenesEstadosCatum ExamenEstadoNumeroNavigation { get; set; } = null!;

    public virtual AuditoresExamenesHorariosCatum HorarioNumeroNavigation { get; set; } = null!;

    public virtual AuditoresPeriodosMaster PeriodoNumeroNavigation { get; set; } = null!;

    public virtual AuditoresMaster PromotorCedulaNavigation { get; set; } = null!;
}
