﻿using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProfesionalesAplicablesCatum
{
    public byte AplicaNumero { get; set; }

    /// <summary>
    /// Es la descripción del tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
    /// </summary>
    public string AplicaDescripcion { get; set; } = null!;

    /// <summary>
    /// Es la explicación del tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
    /// </summary>
    public string AplicaExplicacion { get; set; } = null!;

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

    public virtual ICollection<ProfesionalesDisposicionesTiposCatum> ProfesionalesDisposicionesTiposCata { get; set; } = new List<ProfesionalesDisposicionesTiposCatum>();

    public virtual ICollection<ProfesionalesRequerimientosCatum> ProfesionalesRequerimientosCata { get; set; } = new List<ProfesionalesRequerimientosCatum>();
}
