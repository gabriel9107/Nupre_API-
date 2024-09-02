﻿using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProfesionalesSolicitudesEspecialidadesHistorico
{
    public int SolicitudNumero { get; set; }

    /// <summary>
    /// Numero de la especialidad médica. 
    /// </summary>
    public short EspecialidadNumero { get; set; }

    public int EspecialidadPeriodo { get; set; }

    public string DocumentoCodigo { get; set; } = null!;

    public byte EspecialidadEstadoNumero { get; set; }

    public DateTime EspecialidadEstadoFecha { get; set; }

    public string EspecialidadEstadoNota { get; set; } = null!;

    public short DisposicionNumero { get; set; }

    public byte MotivoNumero { get; set; }

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

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFechaHistorico { get; set; }

    public virtual ProfesionalesSolicitudesEspecialidadesTran ProfesionalesSolicitudesEspecialidadesTran { get; set; } = null!;
}