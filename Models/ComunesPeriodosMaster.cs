using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro donde se registran todo los periodos de facturas con todas las tasas, topes, salarios cotizables, resoluciones y otras informaciones relacionadas con el SFS y el SRL, su fuente de datos los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesPeriodosMaster
{
    /// <summary>
    /// Es el año y mes correspondiente al período de factura,  este período es en él se factura (Generación de NP) a los empleadores basado en sus nóminas depositadas en las TSS.
    /// </summary>
    public int PeriodoFactura { get; set; }

    public int PeriodoSecuencia { get; set; }

    /// <summary>
    /// Es el año y mes correspondiente al período de factura separado con un guion (AAAA-MM), este período es en él que se factura (Generación de NP) a los empleadores basado en sus nóminas depositadas en las TSS.
    /// </summary>
    public string PeriodoFormateado { get; set; } = null!;

    /// <summary>
    /// Es el año correspondiente al período de factura,  este período es en él se factura (Generación de NP) a los empleadores basado en sus nóminas depositadas en las TSS.
    /// </summary>
    public short PeriodoFacturaAnio { get; set; }

    /// <summary>
    /// Es el mes correspondiente al período de factura,  este período es en él se factura (Generación de NP) a los empleadores basado en sus nóminas depositadas en las TSS.
    /// </summary>
    public byte PeriodoFacturaMes { get; set; }

    /// <summary>
    /// Es el trimestre correspondiente mes del período de factura,  este período es en él que se factura (Generación de NP) a los empleadores basado en sus nóminas depositadas en las TSS.
    /// </summary>
    public byte PeriodoFacturaTrimestre { get; set; }

    /// <summary>
    /// Es el cuatrimestre correspondiente mes del período de factura,  este período es en él que se factura (Generación de NP) a los empleadores basado en sus nóminas depositadas en las TSS.
    /// </summary>
    public byte PeriodoFacturaCuatrimestre { get; set; }

    /// <summary>
    /// Es el año correspondiente al período en el cual se debe dispersar la cápita a las ARS, este período es equivalente al período de cobertura.  El período de cobertura es el mes inmediatamente  después al periodo de factura.
    /// </summary>
    public short PeriodoDispersionAnio { get; set; }

    /// <summary>
    /// Es el mes correspondiente al período en el cual se debe dispersar la cápita a las ARS, este período es equivalente al período de cobertura.  El período de cobertura es el mes inmediatamente  después al periodo de factura.
    /// </summary>
    public byte PeriodoDispersionMes { get; set; }

    /// <summary>
    /// Es el año correspondiente al período en el cual se debe dispersar la cápita a las ARS, este período es equivalente al período de cobertura.  El período de cobertura es el mes inmediatamente  después al periodo de factura.
    /// </summary>
    public int PeriodoDispersion { get; set; }

    /// <summary>
    /// Es la tasa que se aplica al salario en nomina del trabajador para el aporte correspondiente al empleador,   para aportar las cotizaciones al SFS vía la TSS.
    /// </summary>
    public decimal SfsAporteEmpleador { get; set; }

    /// <summary>
    /// Es la tasa que se aplica al salario en nomina del trabajador para el aporte correspondiente al mismo trabajador,  para aportar las cotizaciones al SFS vía la TSS.
    /// </summary>
    public decimal SfsAporteTrabajador { get; set; }

    /// <summary>
    /// Es el salario nacional oficial definido por el Consejo Nacional de la Seguridad Social para las cotizaciones 
    /// </summary>
    public decimal SfsSalarioCotizable { get; set; }

    /// <summary>
    /// Es la cantidad de salarios (Salario Nacional Oficial) definido por el Consejo Nacional de la Seguridad Social para las cotizaciones del SFS, con el cual se calcula el salario tope de cotización. 
    /// </summary>
    public decimal SfsSalariosCotizableTope { get; set; }

    /// <summary>
    /// Es el salario máximo hasta  el cual debe cotizar un trabajador  para el SFS. Se obtiene de multiplicar el Salario Cotizables por Salarios Cotizables Tope.
    /// </summary>
    public decimal SfsSalarioTope { get; set; }

    /// <summary>
    /// Es la tasa que se aplica al aporte realizado por el trabajador  al SFS para el fondo del cuidado de la salud de los afiliados, de donde se toman los recursos para la dispersión de las cápitas a las ARS
    /// </summary>
    public decimal SfsDispersionCuidadoSalud { get; set; }

    /// <summary>
    /// Es la tasa que se aplica al aporte realizado por el trabajador  al SFS para el fondo de los Subsidios, de donde se toman los recursos para la entrega de los beneficios de subsidios por maternidad, lactancia y enfermedad común.
    /// </summary>
    public decimal SfsDispersionSubsidio { get; set; }

    /// <summary>
    /// Es la tasa que se aplica al aporte realizado por el trabajador  al SFS para el fondo de las Estancias Infantiles.
    /// </summary>
    public decimal SfsDispersionEstancias { get; set; }

    /// <summary>
    /// Es la tasa que se aplica al aporte realizado por el trabajador  al SFS para el fondo de la Comisión  de la SISALRIL, de donde se toman los recursos para la los gastos de las operaciones de la SISALRIL.
    /// </summary>
    public decimal SfsDispersionComisionSisalril { get; set; }

    /// <summary>
    /// Es el monto de cápita que deberá se dispersado por cada afiliado a las ARS por el SFS régimen contributivo para el período de cobertura correspondiente.
    /// </summary>
    public decimal SfsCapitaAfiliado { get; set; }

    /// <summary>
    /// Es el monto de cápita que deberá se dispersado por cada afiliado Adicional a las ARS para el período de cobertura correspondiente.
    /// </summary>
    public decimal SfsCapitaAfiliadoAdicional { get; set; }

    /// <summary>
    /// Código único de la versión del Plan de servicios de Salud (PDSS) al cual pertenece el Subgrupo.
    /// </summary>
    public string? SfsPlanNumero { get; set; }

    /// <summary>
    /// Son las resoluciones que regulan los procesos de recaudo y dispersión del Seguro Familiar de Salud para ese periodo específico.
    /// </summary>
    public string SfsResoluciones { get; set; } = null!;

    /// <summary>
    /// Son notas de proceso, normativas  o aclaraciones que incidieron en los procesos de recaudo y dispersión del Seguro Familiar de Salud para ese periodo específico.
    /// </summary>
    public string? SfsNotasTecnicas { get; set; }

    /// <summary>
    /// Es la tasa para la categoría de riesgo I que se aplica al salario en nomina del trabajador para el aporte correspondiente al mismo trabajador, para aportar las cotizaciones al SRL.
    /// </summary>
    public decimal SrlCategoriaRiesgoI { get; set; }

    /// <summary>
    /// Es la tasa para la categoría de riesgo II que se aplica al salario en nomina del trabajador para el aporte correspondiente al mismo trabajador, para aportar las cotizaciones al SRL.
    /// </summary>
    public decimal SrlCategoriaRiesgoIi { get; set; }

    /// <summary>
    /// Es la tasa para la categoría de riesgo III que se aplica al salario en nomina del trabajador para el aporte correspondiente al mismo trabajador, para aportar las cotizaciones al SRL.
    /// </summary>
    public decimal SrlCategoriaRiesgoIii { get; set; }

    /// <summary>
    /// Es la tasa para la categoría de riesgo IV que se aplica al salario en nomina del trabajador para el aporte correspondiente al mismo trabajador, para aportar las cotizaciones al SRL.
    /// </summary>
    public decimal SrlCategoriaRiesgoIv { get; set; }

    /// <summary>
    /// Es el salario nacional oficial definido por el Consejo Nacional de la Seguridad Social para las cotizaciones 
    /// </summary>
    public decimal SrlSalarioCotizable { get; set; }

    /// <summary>
    /// Es la cantidad de salarios (Salario Nacional Oficial) definido por el Consejo Nacional de la Seguridad Social para las cotizaciones del SRL, con el cual se calcula el salario tope de cotización. 
    /// </summary>
    public decimal SrlSalariosCotizableTope { get; set; }

    /// <summary>
    /// Es el salario máximo hasta  el cual debe cotizar un trabajador para el SRL. Se obtiene de multiplicar el Salario Cotizables por Salarios Cotizables Tope.
    /// </summary>
    public decimal SrlSalarioTope { get; set; }

    /// <summary>
    /// Es la tasa que se aplica al salario en nomina del trabajador para el aporte correspondiente al empleador,   para aportar las cotizaciones al SRL vía la TSS.
    /// </summary>
    public decimal SrlAporteEmpleador { get; set; }

    /// <summary>
    /// Es la tasa que se aplica al salario en nomina del trabajador para el aporte correspondiente al mismo trabajador,  para aportar las cotizaciones al SRL vía la TSS.
    /// </summary>
    public decimal SrlAporteTrabajador { get; set; }

    /// <summary>
    /// Son las resoluciones que regulan los procesos de recaudo y dispersión del Seguro de Riesgos Laborales para ese periodo específico.
    /// </summary>
    public string SrlResoluciones { get; set; } = null!;

    /// <summary>
    /// Es la tasa que se aplica al aporte realizado por el trabajador  al SRL para el  fondo del cuidado de la salud y beneficios monetarios de los trabajadores afiliados, de donde se toman los recursos para la dispersión a las ARL.  
    /// </summary>
    public decimal SrlDispersionArl { get; set; }

    /// <summary>
    /// Es la tasa que se aplica al aporte realizado por el trabajador  al SRL para el fondo de la Comisión  de la SISALRIL, de donde se toman los recursos para la los gastos de las operaciones  de supervisión del SRL de la SISALRIL.
    /// </summary>
    public decimal SrlDispersionSisalril { get; set; }

    /// <summary>
    /// Es el monto de cápita que deberá se dispersado por cada afiliado a las ARS por el SFS régimen subsidiado para el período de cobertura correspondiente.
    /// </summary>
    public decimal SfsSubCapitaAfiliado { get; set; }

    /// <summary>
    /// Son las resoluciones que regulan los procesos de recaudo y dispersión del Seguro Familiar de Salud para ese periodo específico.
    /// </summary>
    public string SfsSubResoluciones { get; set; } = null!;

    /// <summary>
    /// Son notas de proceso, normativas  o aclaraciones que incidieron en los procesos de recaudo y dispersión del Seguro Familiar de Salud para ese periodo específico.
    /// </summary>
    public string SfsSubNotasTecnicas { get; set; } = null!;

    /// <summary>
    /// Cantidad de salarios a contemplar en un mes para calcular el margen de solvencia mínimo de las ARS 
    /// </summary>
    public short? FinancieroCantidadSalario { get; set; }

    /// <summary>
    /// Porcentaje máximo de los ingresos que pueden utilizar las ARS en sus gastos administrativos 
    /// </summary>
    public decimal? FinancieroPorcentajeExcesoGastoAmd { get; set; }

    /// <summary>
    /// Para detallar las resoluciones que aplican a la presentación y seguimiento fe los estados financieros de las ARS
    /// </summary>
    public string? FinancieroResoluciones { get; set; }

    public string FinancieroPublicacionEstados { get; set; } = null!;
}
