using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las funcionalidades de los módulos de los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SistemasModulosFuncionesTran
{
    /// <summary>
    /// Número único del sistema de información.
    /// </summary>
    public short SistemaNumero { get; set; }

    /// <summary>
    /// Número único de modulo del sistema de información.
    /// </summary>
    public short ModuloNumero { get; set; }

    /// <summary>
    /// Número único de la funcionalidad del modulo del sistema de información.
    /// </summary>
    public short ModuloFuncionNumero { get; set; }

    /// <summary>
    /// Nombre de la función que representan una o varias operaciones que se utilizan en las interfaces de los sistemas de información.
    /// </summary>
    public string ModuloFuncionNombre { get; set; } = null!;

    /// <summary>
    /// Nombre del menú de la función que representan una o varias operaciones que se utilizan en las interfaces de los sistemas de información.
    /// </summary>
    public string ModuloFuncionMenuNombre { get; set; } = null!;

    /// <summary>
    /// Indica si la función se va a mostrar en el  menú  en las interfaces de los sistemas de información.
    /// </summary>
    public string ModuloFuncionMenuMostrar { get; set; } = null!;

    /// <summary>
    /// Indica si en cual posición (orden) se va mostrar la función en el  menú  en las interfaces de los sistemas de información.
    /// </summary>
    public int ModuloFuncionMenuOrden { get; set; }

    /// <summary>
    /// Descripción de la función que representan una o varias operaciones que se utilizan en las interfaces de los sistemas de información.
    /// </summary>
    public string ModuloFuncionDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación  de la función que representan una o varias operaciones que se utilizan en las interfaces de los sistemas de información.
    /// </summary>
    public string ModuloFuncionExplicacion { get; set; } = null!;

    /// <summary>
    /// Direccion donde se encuentran los objetos de la función que representan una o varias operaciones que se utilizan en las interfaces de los sistemas de información.
    /// </summary>
    public string ModuloFuncionUrl { get; set; } = null!;

    /// <summary>
    /// Indica si la función que representan una o varias operaciones que se utilizan en las interfaces de los sistemas de información es un POPUP.
    /// </summary>
    public string ModuloFuncionEsPopup { get; set; } = null!;

    /// <summary>
    /// Indica la altura del POPUP donde se va a mostrar la función que representan una o varias operaciones que se utilizan en las interfaces de los sistemas de información.
    /// </summary>
    public int ModuloFuncionPopupAlto { get; set; }

    /// <summary>
    /// Indica el ancho del POPUP donde se va a mostrar la función que representan una o varias operaciones que se utilizan en las interfaces de los sistemas de información.
    /// </summary>
    public int ModuloFuncionPopupAncho { get; set; }

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

    public virtual ICollection<SistemasModulosControlesTran> SistemasModulosControlesTrans { get; set; } = new List<SistemasModulosControlesTran>();

    public virtual SistemasModulosMaster SistemasModulosMaster { get; set; } = null!;
}
