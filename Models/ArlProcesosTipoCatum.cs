using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla catálogo que contiene Tipo de proceso en el cual se encuentra la solicitud AT /EP. Ver catálogo Tipo Proceso publicada por la ARLSS, su fuente de datos es el  esquema 62 procesado por el Robot Simon. 
/// </summary>
public partial class ArlProcesosTipoCatum
{
    /// <summary>
    /// Tipo de proceso en el cual se encuentra la solicitud AT /EP. Ver catálogo Tipo Proceso.
    /// </summary>
    public byte ProcesoTipoNumero { get; set; }

    /// <summary>
    /// Descripción del Tipo de proceso en el cual se encuentra la solicitud AT /EP. Ver catálogo Tipo Proceso.
    /// </summary>
    public string ProcesoTipoDescripcion { get; set; } = null!;

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
