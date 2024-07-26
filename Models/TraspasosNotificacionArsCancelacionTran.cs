using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosNotificacionArsCancelacionTran
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
    /// Número de Seguridad Social del titular que solicitó el traspaso.
    /// </summary>
    public long AfiliadoTitularNss { get; set; }

    /// <summary>
    /// Cédula del titular que solicitó el traspaso.
    /// </summary>
    public string AfiliadoTitularCedula { get; set; } = null!;

    /// <summary>
    /// Código que indica el detalle de la acción tomada por la SISALRIL.
    /// </summary>
    public byte MotivoNumero { get; set; }

    /// <summary>
    /// Identifica cual es el tipo de ARS con relación al afiliado (posibles valores O = ARS Origen, D = ARS Destino).
    /// </summary>
    public string ArsTipoCodigo { get; set; } = null!;

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
