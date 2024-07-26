using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosNotificacionCondicionEnfermedadTran
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
    /// Indica si el afiliado es un dependiente o un titular (T = Titular, D = Dependiente, A = Dependiente Adicional).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Condición de enfermedad del afiliado.
    /// </summary>
    public byte CondicionEnfermedadNumero { get; set; }

    /// <summary>
    /// Número de Seguridad Social del titular que solicitó el traspaso.
    /// </summary>
    public long AfiliadoTitularNss { get; set; }

    /// <summary>
    /// Número de Seguridad Social del dependiente del titular que solicitó el traspaso.
    /// </summary>
    public long AfiliadoDependienteNss { get; set; }

    /// <summary>
    /// Cédula del titular que solicitó el traspaso.
    /// </summary>
    public string AfiliadoTitularCedula { get; set; } = null!;

    /// <summary>
    /// Cédula del Dependiente del titular que solicitó el traspaso.
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
    /// Código del parentesco que identifica la relación de un dependiente con su titular.
    /// </summary>
    public byte ParentescoNumero { get; set; }

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
