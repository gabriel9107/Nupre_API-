using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosAccionSisalrilArsOrigenDestinoTran
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
    /// Indica si el afiliado es un dependiente o un titular: (T = Titular, D = Dependiente Directo, A = Dependiente Adicional).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social del titular que solicitó el traspaso.
    /// </summary>
    public long AfiliadoTitularNss { get; set; }

    /// <summary>
    /// Número de Seguridad Social del dependiente del titular que solicitó el traspaso (Solo para el tipo de afiliado Dependiente, obligatorio si el dependiente está activo).
    /// </summary>
    public long AfiliadoDependienteNss { get; set; }

    /// <summary>
    /// Cédula del titular que solicitó el traspaso.
    /// </summary>
    public string AfiliadoTitularCedula { get; set; } = null!;

    /// <summary>
    /// Cédula del Dependiente del titular que solicitó el traspaso (Solo para el tipo de afiliado Dependiente).
    /// </summary>
    public string AfiliadoDependienteCedula { get; set; } = null!;

    /// <summary>
    /// Fecha de nacimiento del afiliado.
    /// </summary>
    public DateTime AfiliadoFechaNacimiento { get; set; }

    /// <summary>
    /// Sexo del afiliado.
    /// </summary>
    public string AfiliadoSexo { get; set; } = null!;

    /// <summary>
    /// Código del parentesco que identifica la relación de un dependiente con su titular (será obligatorio si el tipo de afiliado es un dependiente).
    /// </summary>
    public byte ParentescoNumero { get; set; }

    /// <summary>
    /// Código que indica la acción de SISALRIl (1 = Detener el traspaso, 2 = Continuar con el flujo del traspaso sin tomar en cuenta la notificación de enfermedad de la ARS Origen).
    /// </summary>
    public byte AccionSisalrilNumero { get; set; }

    /// <summary>
    /// Código que indica el detalle de la acción tomada por la SISALRIL.
    /// </summary>
    public byte MotivoAccionSisalrilNumero { get; set; }

    /// <summary>
    /// Indica cual es el tipo de ARS con relación al afiliado (posibles valores O = ARS Origen, D = ARS Destino).
    /// </summary>
    public string ArsTipoCodigo { get; set; } = null!;

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
