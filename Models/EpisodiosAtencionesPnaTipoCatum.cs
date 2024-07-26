﻿using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class EpisodiosAtencionesPnaTipoCatum
{
    /// <summary>
    /// Código del Tipo de Atención, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public byte AtencionPnaTipoNumero { get; set; }

    /// <summary>
    /// Descripción del Tipo de Atención, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string AtencionPnaTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Descripción corta del Tipo de Atención (Resumido para mejor visualización en las interfaces), especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string AtencionPnaTipoDescripcionCorta { get; set; } = null!;

    /// <summary>
    /// Descripción del Tipo de Atención, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string AtencionPnaTipoExplicacion { get; set; } = null!;

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
