using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ArlReclamacionesPrestacionesRecargasTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Para reportar el número de expediente dado por la ARL SS.
    /// </summary>
    public long ExpedienteArlNumero { get; set; }

    /// <summary>
    /// Para reportar el número de reclamación asignado por la ARLSS.
    /// </summary>
    public long ReclamacionNumero { get; set; }

    /// <summary>
    /// Es el número de documento o identificación que aplica  según el tipo de reclamante. Ver Tabla Tipo de Reclamante.
    /// </summary>
    public string ReclamanteDocumento { get; set; } = null!;

    /// <summary>
    /// Código valido para reportar el tipo de reclamante que realizo la reclamación a la ARLSS.  Ver Tabla Tipo de Reclamante.
    /// </summary>
    public byte ReclamanteTipoNumero { get; set; }

    /// <summary>
    /// Código valido para reportar el tipo de reclamación o notificación. Ver Tabla de tipo de reclamación o notificación.
    /// </summary>
    public byte ReclamacionTipoNumero { get; set; }

    /// <summary>
    /// Para reportar la fecha en que se realizo la reclamación a la ARLSS. Contendrá el siguiente formato DDMMYYYY.
    /// </summary>
    public DateTime ReclamacionFecha { get; set; }

    /// <summary>
    /// Para reportar el monto reclamado  a la ARLSS, (Utilice 9999999.99 para cuando tenga decimales y/o 9999999.00 cuando no tenga decimales). En caso de subsidio por Incapacidad Temporal, el campo monto reclamado será igual a cero. Cuando el tipo de reclamación sea por incapacidad  temporal (código 05), reportar en 0 ejemplo: 00000000.00.
    /// </summary>
    public decimal ReclamacionMontoReclamado { get; set; }

    /// <summary>
    /// Para reportar el salario del trabajador accidentado acorde con lo registrado en TSS. (Utilice 9999999.99 para cuando tenga decimales y/o 9999999.00 cuando no tenga decimales). Cuando el tipo de reclamación sea por prestaciones en especie (Gastos en Salud)  (código 10), reportar en 0 ejemplo: 00000000.00.
    /// </summary>
    public decimal SalarioPromedioTss { get; set; }

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
