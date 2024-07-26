using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AfiliadosPlanesAlternativosVistum
{
    public string AfiliadoDocumento { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long AfiliadoTitularNss { get; set; }

    public byte ArsNumero { get; set; }

    public string PlanNumero { get; set; } = null!;

    /// <summary>
    /// Nombre del Plan de Salud.
    /// </summary>
    public string PlanNombre { get; set; } = null!;

    /// <summary>
    /// Nombre de la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public string ArsNombre { get; set; } = null!;

    public string AfiliadoTitularNombre { get; set; } = null!;

    public string AfiliadoTitularCedula { get; set; } = null!;

    public string AfiliadoTitularPoliza { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long AfiliadoNss { get; set; }

    /// <summary>
    /// Es el código que clasifica los afiliados en T = Titulares (Quien representa al núcleo familiar) D = Dependientes  (Hijos y Conjugues) y A = Adicionales (Padres, Hijos con mayoría de edad cumplida 18 o 21, otros familiares dependientes económicamente).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    public string AfiliadoNombre { get; set; } = null!;

    public string AfiliadoSexo { get; set; } = null!;

    /// <summary>
    /// Es la fecha de nacimiento de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public DateTime AfiliadoFechaNacimiento { get; set; }

    public string AfiliadoDiscapacitado { get; set; } = null!;

    public byte ParentescoNumero { get; set; }

    /// <summary>
    /// Descripción del parentesco entre un dependiente y el titular de un núcleo familiar en el Seguro Familiar de Salud (SFS).
    /// </summary>
    public string ParentescoDescripcion { get; set; } = null!;

    /// <summary>
    /// Número único que representa la nacionalidad de la persona o afiliado.
    /// </summary>
    public short NacionalidadNumero { get; set; }

    /// <summary>
    /// Descripción de la nacionalidad de la persona o afiliado.
    /// </summary>
    public string NacionalidadDescripcion { get; set; } = null!;

    public int InicioVigenciaFecha { get; set; }

    public int UltimoPagoFactura { get; set; }

    public decimal PrimaComercialMensual { get; set; }

    public byte ModalidadPagoNumero { get; set; }

    public string ModalidadPagoDescripcion { get; set; } = null!;

    public string PromotorDocumento { get; set; } = null!;

    public int SeguimientoPeriodo { get; set; }
}
