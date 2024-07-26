using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de las consultas que están disponibles en los sistemas de información que requerirán control de seguridad  adicional, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguridadConsultasCatum
{
    /// <summary>
    /// Número único del sistema de información.
    /// </summary>
    public short SistemaNumero { get; set; }

    /// <summary>
    /// Número único que representa la consulta.
    /// </summary>
    public int ConsultaNumero { get; set; }

    /// <summary>
    /// Titulo principal de la consulta una vez esta generada.
    /// </summary>
    public string ConsultaTitulo { get; set; } = null!;

    /// <summary>
    /// Tema con el cual se relaciona la consulta.
    /// </summary>
    public int ConsultaTema { get; set; }

    /// <summary>
    /// Descripción la información principal que se presenta en la consulta.
    /// </summary>
    public string ConsultaDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación Descripción la información principal que se presenta en la consulta.
    /// </summary>
    public string ConsultaExplicacion { get; set; } = null!;

    /// <summary>
    /// Ubicación de la carpeta donde se encuentra almacenado el archivo físico del ejecutable de la consulta.
    /// </summary>
    public string ConsultaUrl { get; set; } = null!;

    /// <summary>
    /// Especifica las tablas, vistas o procedimiento almacenado (PROC)  de donde se obtendrá la información de la consulta.
    /// </summary>
    public string ConsultaFuenteDatos { get; set; } = null!;

    /// <summary>
    /// Orden en que debe ser desplegada la consulta, en el visor para seleccionar la consulta a utilizar.
    /// </summary>
    public int ConsultaOrden { get; set; }

    /// <summary>
    /// Procedimiento que genera y provee la información al reporte de la consulta.
    /// </summary>
    public string ConsultaProcedimiento { get; set; } = null!;

    /// <summary>
    /// Ubicación de la carpeta donde se encuentra almacenado el archivo físico del reporte de la consulta.
    /// </summary>
    public string ConsultaReporteRuta { get; set; } = null!;

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

    public virtual ICollection<SeguridadGruposConsultasTran> SeguridadGruposConsultasTrans { get; set; } = new List<SeguridadGruposConsultasTran>();
}
