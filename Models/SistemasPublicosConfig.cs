using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasPublicosConfig
{
    /// <summary>
    /// Nombre de la interface a la cual se hace referencia.
    /// </summary>
    public string? NombrePublicoPagina { get; set; }

    /// <summary>
    /// Nombre interno del objeto (Generalmente un Botón). al cual se hace referencia en el registro.
    /// </summary>
    public string? NombrePublicoNombrePrivado { get; set; }

    /// <summary>
    /// Nombre público del objeto (Generalmente un Botón) que se mostrara la usuario final.
    /// </summary>
    public string? NombrePublicoNombrePublico { get; set; }

    /// <summary>
    /// Pequeña descripción que sale sobre el objeto(Generalmente un Botón) al pasar el Mouse sobre el mismo.
    /// </summary>
    public string? NombrePublicoToolTips { get; set; }

    /// <summary>
    /// Imagen que mostrara el objeto(Generalmente un Botón).
    /// </summary>
    public string? NombrePublicoImagenUrl { get; set; }

    /// <summary>
    /// Indica si el objeto será visible al usuario.
    /// </summary>
    public string? NombrePublicoMostrar { get; set; }

    /// <summary>
    /// Indica la cantidad de columna que la interface debe diseñar para mostrar al usuario(generalmente aplica a un panel)
    /// </summary>
    public int? NombrePublicoTablaHtmlCantidadColumna { get; set; }

    /// <summary>
    /// Indica el nombre de la clase en el archivo de estilo (CSS) el cual el objeto tomara como diseño(generalmente aplica a un panel).
    /// </summary>
    public string? NombrePublicoTablaHtmlTdCssClass { get; set; }

    /// <summary>
    /// Indica si determinado objeto(generalmente un textbox). se mostrara solo en una fila de la tabla HTML que se genera en la interfaces del usuario.
    /// </summary>
    public string? NombrePublicoTablaHtlmMerge { get; set; }

    /// <summary>
    /// Indica el modo de escritura que acepta el objeto(generalmente un textbox), puede ser una sola línea o múltiples líneas.
    /// </summary>
    public string? NombrePublicoTextBoxTexMode { get; set; }

    /// <summary>
    /// Indica el ancho del objeto(generalmente un textbox).
    /// </summary>
    public string? NombrePublicoTextBoxWith { get; set; }

    /// <summary>
    /// Indica el nombre de la clase en el archivo de estilo (CSS) el cual el objeto tomara como diseño(generalmente aplica a un textbox).
    /// </summary>
    public string? NombrePublicoTextBoxCssClass { get; set; }

    /// <summary>
    /// Indica el ancho del objeto(generalmente un Label).
    /// </summary>
    public string? NombrePublicoLabelWith { get; set; }

    /// <summary>
    /// Indica el nombre de la clase en el archivo de estilo (CSS) el cual el objeto tomara como diseño(generalmente aplica a un Label).
    /// </summary>
    public string? NombrePublicoLabelCssClass { get; set; }

    /// <summary>
    /// Indica el orden de visualización del objeto en la interface del usuario.
    /// </summary>
    public int? NombrePublicoVisualizarOrden { get; set; }

    /// <summary>
    /// Indica si se mostrara un control de búsqueda en la interface.
    /// </summary>
    public string? NombrePublicoBusquedaMostrar { get; set; }

    /// <summary>
    /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string? RegistroEstado { get; set; }

    /// <summary>
    /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
    /// </summary>
    public string? RegistroUsuario { get; set; }

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime? RegistroFecha { get; set; }
}
