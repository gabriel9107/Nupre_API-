using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los datos para el seguimiento trimestral del PYP, calculados a partir de los reportes del esquema 40 que realizan las ARS,  su fuente de datos son los sistemas  de la SISALRIL.
/// </summary>
public partial class PypSeguimientosTrimestralesTran
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número único del grupo al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public byte GrupoNumero { get; set; }

    /// <summary>
    /// Número único asignado al subgrupo del PDSS, se incrementa de 1 a N para cada grupo del PDSS.
    /// </summary>
    public byte SubGrupoNumero { get; set; }

    /// <summary>
    /// Año correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public short SeguimientoAnio { get; set; }

    /// <summary>
    /// Corresponde al período de tres meses de un año
    /// </summary>
    public byte TrimestreNumero { get; set; }

    /// <summary>
    /// Número único de la población objetiva, la cual se agrupo por  edades y sexo enfocados en un programa de salud o que puede recibir servicios médicos (Coberturas) específicas.
    /// </summary>
    public byte PoblacionObjetivaNumero { get; set; }

    /// <summary>
    /// Nos indica cual será la población proyectada de afiliados para una ARS, en un año y población objetiva especifica.
    /// </summary>
    public int PoblacionObjetivaAnual { get; set; }

    /// <summary>
    /// Es el porciento que se espera cubrir en un trimestre de la población proyectada anual de afiliados de una ARS, de un año y población objetiva específica.
    /// </summary>
    public byte MetaTrimestre { get; set; }

    /// <summary>
    /// Es la cantidad de afiliados que se espera cubrir en un trimestre de la población proyectada anual de afiliados de una ARS, de un año y población objetiva específica.
    /// </summary>
    public int AfiliadosProgramados { get; set; }

    /// <summary>
    /// Es la cantidad total de afiliados reportados por una ARS con coberturas, en un trimestre específico y para un mismo programa de salud (Subgrupo).
    /// </summary>
    public int AfiliadosReportados { get; set; }

    /// <summary>
    /// Es la porciento de cumplimiento de afiliados reportados por una ARS con coberturas, en un trimestre específico, para un mismo programa de salud (Subgrupo) y una población objetiva esperada.
    /// </summary>
    public decimal NivelCumplimiento { get; set; }

    /// <summary>
    /// Es la cantidad total de afiliados reportados por una ARS con coberturas, en un trimestre específico y para un mismo programa de salud (Subgrupo), que pertenecen a la ARS y No a la población objetiva esperada.
    /// </summary>
    public int AfiliadosReportadosNoProgramados { get; set; }

    /// <summary>
    /// Es la porciento de cumplimiento de afiliados reportados por una ARS con coberturas, en un trimestre específico, para un mismo programa de salud (Subgrupo) y una población objetiva esperada.
    /// </summary>
    public decimal NivelCumplimientoNoProgramado { get; set; }

    /// <summary>
    /// Es la cantidad total de afiliados reportados por una ARS con coberturas, en un trimestre específico y para un mismo programa de salud (Subgrupo), que No pertenecen a dicha ARS.
    /// </summary>
    public int AfiliadosReportadosNoArs { get; set; }

    /// <summary>
    /// Es la porciento de cumplimiento de afiliados reportados por una ARS con coberturas, en un trimestre específico, para un mismo programa de salud (Subgrupo) y una población objetiva esperada.
    /// </summary>
    public decimal NivelCumplimientoNoArs { get; set; }

    /// <summary>
    /// Nos indica cual será la población proyectada de afiliados para una ARS, en un año y población objetiva, acumulada hasta un trimestre específico.
    /// </summary>
    public byte MetaTrimestreAcumulado { get; set; }

    /// <summary>
    /// Nos indica cual será la población proyectada de afiliados para una ARS, en un año y población objetiva, acumulada hasta un trimestre específico.
    /// </summary>
    public int AfiliadosProgramadosAcumulados { get; set; }

    /// <summary>
    /// Nos indica cual será la población proyectada de afiliados para una ARS, en un año y población objetiva, acumulada hasta un trimestre específico.
    /// </summary>
    public int AfiliadosReportadosAcumulados { get; set; }

    /// <summary>
    /// Es la porciento de cumplimiento de afiliados reportados por una ARS con coberturas, hasta un trimestre específico, para un mismo programa de salud (Subgrupo) y una población objetiva esperada.
    /// </summary>
    public decimal NivelCumplimientoAcumulado { get; set; }

    /// <summary>
    /// Es la cantidad total de afiliados reportados por una ARS con coberturas, en un mes específico  y para un mismo programa de salud (Subgrupo), que pertenecen a la ARS y No a la población objetiva esperada.
    /// </summary>
    public int AfiliadosReportadosNoProgramadosAcumulados { get; set; }

    /// <summary>
    /// Es la porciento de cumplimiento de afiliados reportados por una ARS con coberturas, en un trimestre específico, para un mismo programa de salud (Subgrupo) y una población objetiva esperada.
    /// </summary>
    public decimal NivelCumplimientoNoProgramadoAcumulado { get; set; }

    /// <summary>
    /// Es la cantidad total de afiliados reportados por una ARS con coberturas, en un mes específico y para un mismo programa de salud (Subgrupo), que No pertenecen a dicha ARS.
    /// </summary>
    public int AfiliadosReportadosNoArsAcumulados { get; set; }

    /// <summary>
    /// Es la porciento de cumplimiento de afiliados reportados por una ARS con coberturas, en un trimestre específico, para un mismo programa de salud (Subgrupo) y una población objetiva esperada.
    /// </summary>
    public decimal NivelCumplimientoNoArsAcumulado { get; set; }

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

    public virtual PypPoblacionesAnualesTran PypPoblacionesAnualesTran { get; set; } = null!;
}
