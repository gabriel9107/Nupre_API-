using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosAccionCondicionEnfermedadTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico.
    /// </summary>
    public int SeguimientoNumero { get; set; }

    /// <summary>
    /// Identificador del tipo de registro (Constante = D).
    /// </summary>
    public string RegistroTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Indica el Número del tipo de traspaso.
    /// </summary>
    public byte TraspasoTipoNumero { get; set; }

    /// <summary>
    /// Número único de Control del Traspaso con el cual fue autorizado el traspaso.
    /// </summary>
    public long Nuct { get; set; }

    /// <summary>
    /// Número de Lote del archivo donde fue enviado el registro reportado.
    /// </summary>
    public int LoteSuirNumero { get; set; }

    /// <summary>
    /// Estatus en que quedó el registro luego de la validación.
    /// </summary>
    public int RegistroNumero { get; set; }

    /// <summary>
    /// Código que indica la acción de SISALRIl (1 = Detener el traspaso, 2 = Continuar con el flujo del traspaso sin tomar en cuenta la notificación de enfermedad de la ARS Origen).
    /// </summary>
    public byte AccionNumero { get; set; }

    /// <summary>
    /// Código que indica el detalle de la acción tomada por la SISALRIL.
    /// </summary>
    public byte MotivoNumero { get; set; }

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
