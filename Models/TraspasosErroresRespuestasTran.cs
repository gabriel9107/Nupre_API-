using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosErroresRespuestasTran
{
    /// <summary>
    /// Número único de repuesta dada, después de detactado su error durante la evaluación de un formulario de reclamo en un proceso de traspaso.
    /// </summary>
    public int ErrorRespuestaNumero { get; set; }

    /// <summary>
    /// Número único que representa la carga de un Archivo de Traspaso por Problema de Imagen y/o Condición de Enfermedad, reportado por el SUIR.
    /// </summary>
    public long SeguimientoNumero { get; set; }

    /// <summary>
    /// Numero Único de Control de Traspaso con el cual fue autorizado el traspaso mediante consulta al Webservices de autorización de Traspaso de Salud.
    /// </summary>
    public long Nuct { get; set; }

    /// <summary>
    /// Indica la fecha del error durante la evaluación de un formulario de reclamo en un proceso de traspaso.
    /// </summary>
    public DateTime ErrorRespuestaFecha { get; set; }

    /// <summary>
    /// Indica el usuario que dió la respuesta del error.
    /// </summary>
    public string ErrorRespuestaUsuarip { get; set; } = null!;

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

    public virtual TraspasosSeguimientosMaster SeguimientoNumeroNavigation { get; set; } = null!;
}
