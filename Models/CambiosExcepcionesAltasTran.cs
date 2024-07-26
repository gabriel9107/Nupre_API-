using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CambiosExcepcionesAltasTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public int SeguimientoNumero { get; set; }

    /// <summary>
    /// Identificador del tipo de registro (Constante = D).
    /// </summary>
    public string RegistroTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Código del tipo de motivo de cambio por el cual el afiliado cambió de ARS o de tipo.
    /// </summary>
    public byte MotivoCambioNumero { get; set; }

    /// <summary>
    /// Número único de Solicitud de Cambio por Excepción con el cual fue autorizado el cambio.
    /// </summary>
    public int SolicitudCambioNumero { get; set; }

    /// <summary>
    /// Indica el tipo de afiliado (T = Titular, D = Dependiente Directo, A = Dependiente Adicional).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social del nuevo titular.
    /// </summary>
    public long AfiliadoTitularNuevoNss { get; set; }

    /// <summary>
    /// Cédula del nuevo titular.
    /// </summary>
    public string AfiliadoTitularNuevoCedula { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social del titular que solicitó el cambio de ARS o tipo.
    /// </summary>
    public long AfiliadoTitularNss { get; set; }

    /// <summary>
    /// Cédula del titular que solicitó el cambio de ARS o tipo.
    /// </summary>
    public string AfiliadoTitularCedula { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social del dependiente solicitante o solicitado para el cambio de ARS o tipo.
    /// </summary>
    public long AfiliadoDependienteNss { get; set; }

    /// <summary>
    /// Cédula del Dependiente solicitante o solicitado para el cambio de ARS o de tipo.
    /// </summary>
    public string AfiliadoDependienteCedula { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se proporcionará el municipio en que fue elaborada el acta de nacimiento.
    /// </summary>
    public string ActaNacimientoMunicipio { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se proporcionará la oficialia en donde fue elaborada el acta de nacimiento.
    /// </summary>
    public string ActaNacimientoOficialia { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se proporcionará el libro en donde está registrada el acta de nacimiento.
    /// </summary>
    public string ActaNacimientoLibro { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se  proporcionará el folio del acta de nacimiento.
    /// </summary>
    public string ActaNacimientoFolio { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se proporcionará el número del acta de nacimiento.
    /// </summary>
    public string ActaNacimientoNumero { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se proporcionará el año del acta de nacimiento.
    /// </summary>
    public string ActaNacimientoAnio { get; set; } = null!;

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

    /// <summary>
    /// Primer nombre del afiliado.
    /// </summary>
    public string AfiliadoPrimerNombre { get; set; } = null!;

    /// <summary>
    /// Segundo nombre del afiliado.
    /// </summary>
    public string AfiliadoSegundoNombre { get; set; } = null!;

    /// <summary>
    /// Primer apellido del afiliado.
    /// </summary>
    public string AfiliadoPrimerApellido { get; set; } = null!;

    /// <summary>
    /// Segundo apellido del afiliado.
    /// </summary>
    public string AfiliadoSegundoApellido { get; set; } = null!;

    /// <summary>
    /// Indica si el dependiente es estudiante (S = Si y N = No). (Este campo será obligatorio si el tipo de afiliado es dependiente).
    /// </summary>
    public string AfiliadoEstudiante { get; set; } = null!;

    /// <summary>
    /// Indica si el dependiente es discapacitado (S = Si y N = No). (Este campo será obligatorio si el tipo de afiliado es dependiente).
    /// </summary>
    public string AfiliadoDiscapacitado { get; set; } = null!;

    /// <summary>
    /// Provincia donde reside el afiliado.
    /// </summary>
    public short ProvinciaNumero { get; set; }

    /// <summary>
    /// Muncipio donde reside el afiliado.
    /// </summary>
    public short MunicipioNumero { get; set; }

    public virtual SistemasSeguimientosMaster SeguimientoNumeroNavigation { get; set; } = null!;
}
