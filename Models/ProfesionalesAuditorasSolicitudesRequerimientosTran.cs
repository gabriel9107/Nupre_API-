﻿using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProfesionalesAuditorasSolicitudesRequerimientosTran
{
    public int SolicitudAuditoraNumero { get; set; }

    /// <summary>
    /// Número único que identifica el requerimiento (Documento, Identificación, otros), que deben presentar las personas o entidades para un proceso de acreditación.
    /// </summary>
    public byte RequerimientoNumero { get; set; }

    /// <summary>
    /// Es el código único que representa el documento dentro del sistema.
    /// </summary>
    public string? DocumentoCodigo { get; set; }

    public string RequerimientoPresentado { get; set; } = null!;

    public DateTime RequerimientoFechaVence { get; set; }

    public byte RequerimientoEstadoNumero { get; set; }

    public DateTime RequerimientoEstadoFecha { get; set; }

    public string RequerimientoEstadoNota { get; set; } = null!;

    public short DisposicionNumero { get; set; }

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

    public virtual ICollection<ProfesionalesAuditorasSolicitudesRequerimientosHistorico> ProfesionalesAuditorasSolicitudesRequerimientosHistoricos { get; set; } = new List<ProfesionalesAuditorasSolicitudesRequerimientosHistorico>();

    public virtual ProfesionalesRequerimientosEstadosCatum RequerimientoEstadoNumeroNavigation { get; set; } = null!;

    public virtual ProfesionalesRequerimientosCatum RequerimientoNumeroNavigation { get; set; } = null!;

    public virtual ProfesionalesAuditorasSolicitudesTran SolicitudAuditoraNumeroNavigation { get; set; } = null!;
}
