using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una vista con los datos de los Promotores que participan en los procesos de Acreditación de Promotores de Salud, Sistema Promotores de Salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PromotoresPromotorasVistum
{
    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long PromotorNss { get; set; }

    /// <summary>
    /// Es el número único que le asigna la Tesorería de la Seguridad Social a cada uno de los empleadores que se registran en dicha institución.    
    /// </summary>
    public int PromotoraRegistroPatronal { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número único que identifica cada entidad en los procesos de acreditación.
    /// </summary>
    public int EntidadNumero { get; set; }

    /// <summary>
    /// Es la cédula de identidad y electoral del ciudadano con el formato que incluye los guiones.
    /// </summary>
    public string PromotorCedula { get; set; } = null!;

    /// <summary>
    /// Es la cédula de identidad y electoral del ciudadano con el formato que incluye los guiones.
    /// </summary>
    public string PromotorCedulaFormateada { get; set; } = null!;

    /// <summary>
    /// Es nombre completo (Nombres  y Apellidos) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string PromotorNombreCompleto { get; set; } = null!;

    /// <summary>
    /// Número único que identifica cada examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public int ExamenNumero { get; set; }

    /// <summary>
    /// Número único que identifica un período (Rango de fecha) en el cual se procedió a habilitar la toma de exámenes en las actividades de evaluación de los procesos de acreditación.
    /// </summary>
    public short PeriodoNumero { get; set; }

    /// <summary>
    /// Fecha y hora en que inició una persona  un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public DateTime ExamenFechaInicio { get; set; }

    /// <summary>
    /// Fecha y hora en que terminó una persona  un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public DateTime ExamenFechaFinal { get; set; }

    /// <summary>
    /// Calificación numérica obtenido por la persona en un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public int ExamenResultado { get; set; }

    /// <summary>
    /// Nombre de la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public string ArsNombre { get; set; } = null!;

    /// <summary>
    /// Indica si el promotor es representante de la promotora
    /// </summary>
    public string PromotorRepresentaPromotora { get; set; } = null!;

    /// <summary>
    /// Número único que identifica la categoría de acreditación a ser otorgada (Auditor, Promotor, Promotora, Firma Auditoria etc.).
    /// </summary>
    public int PromotorCategoriaNumero { get; set; }

    /// <summary>
    /// Descripción  de la categoría de acreditación a ser otorgada (Auditor, Promotor, Promotora, Firma Auditoria etc.).
    /// </summary>
    public string PromotorCategoriaDescripcion { get; set; } = null!;

    /// <summary>
    /// Número único que identifica que quien se está acreditando es una persona o entidad.
    /// </summary>
    public int PromotorClaseNumero { get; set; }

    /// <summary>
    /// Descripción de que quien se está acreditando es una persona o entidad.
    /// </summary>
    public string PromotorClaseDescripcion { get; set; } = null!;

    /// <summary>
    /// Es la descripción de la conjugación de una clase y categoría en el proceso de acreditación.
    /// </summary>
    public string PromotorCategoriaClaseDescripcion { get; set; } = null!;

    /// <summary>
    /// Número único que identifica el nivel académico de la persona.
    /// </summary>
    public byte NivelAcademicoNumero { get; set; }

    /// <summary>
    /// Descripción del nivel académico de la persona.
    /// </summary>
    public string NivelAcademicoDescripcion { get; set; } = null!;

    /// <summary>
    /// Fecha en que fue aprobada la primera licencia del promotor
    /// </summary>
    public DateTime PromotorFechaAcreditacion { get; set; }

    /// <summary>
    /// Fecha en que debe renovar su licencia el promotor
    /// </summary>
    public DateTime PromotorFechaRenovacion { get; set; }

    /// <summary>
    /// Fecha en que vence la licencia el promotor
    /// </summary>
    public DateTime PromotorFechaVencimiento { get; set; }

    /// <summary>
    /// Número único que identifica cada estado en que se encuentra la licencia de un promotor o promotora de salud
    /// </summary>
    public byte PromotorEstadoNumero { get; set; }

    /// <summary>
    /// Descripción del estado en que se encuentra la licencia de un promotor o promotora de salud
    /// </summary>
    public string PromotorEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Observaciones realizadas en el registro de un promotor
    /// </summary>
    public string PromotorObservacion { get; set; } = null!;

    /// <summary>
    /// Es la razón social registrada por el prestador de servicios de salud   en la DGII, y que utiliza la Tesorería de la Seguridad Social en su registro de empleadores. Representa el nombre oficial de cada empresa o institución en el país.
    /// </summary>
    public string PromotoraNombre { get; set; } = null!;

    /// <summary>
    /// RNC (Registro Nacional Contribuyente) de la institución.
    /// </summary>
    public string PromotoraRnc { get; set; } = null!;

    /// <summary>
    /// Fecha en la que se aprobó una entidad en los procesos de acreditación.
    /// </summary>
    public DateTime PromotoraFechaAcreditacion { get; set; }

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
