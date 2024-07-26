using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosNucufAccionCondicionEnfermedadTran
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
    /// Número Unico de Control de Unificación de Núcleo Familiar con el cual fue autorizado el traspaso.
    /// </summary>
    public long Nucuf { get; set; }

    /// <summary>
    /// Número de Seguridad Social del afiliado que fue solicitado para traspaso para unificación de núcleo familiar.
    /// </summary>
    public long AfiliadoNss { get; set; }

    /// <summary>
    /// Código que indica la acción de SISALRIL (1 = Detener el traspaso, 2 = Continuar con el flujo del traspaso sin tomar en cuenta la notificación de enfermedad por la ARS Origen).
    /// </summary>
    public byte AccionNumero { get; set; }

    /// <summary>
    /// Código que indica la acción de SISALRIL (1 = Autorización, 2 = Cancelación, 3 = Cancelación NUCUF, 0 = No Especifiado).
    /// </summary>
    public byte AccionSisalrilNumero { get; set; }

    /// <summary>
    /// Código que indica el detalle de la acción tomada por la SISALRIL.
    /// </summary>
    public byte MotivoNumero { get; set; }

    /// <summary>
    /// Código que indica el detalle de la acción tomada por la SISALRIL.
    /// </summary>
    public byte MotivoSisalrilNumero { get; set; }

    /// <summary>
    /// Estatus en que quedó el registro luego de la validación.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Código de respuesta de la validación del registro según catálogo de motivos del SUIR.
    /// </summary>
    public string RespuestaCodigo { get; set; } = null!;

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
