using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssPensionadosNovedadesDetallesTran
{
    /// <summary>
    /// ID de Novedad
    /// </summary>
    public short NovedadNumero { get; set; }

    /// <summary>
    /// Secuencia única para identificar un registro dentro de la novedad
    /// </summary>
    public short NovedadDetalleSecuencia { get; set; }

    /// <summary>
    /// A= Afiliacion, B= Baja
    /// </summary>
    public string NovedadDetalleTipoCodigo { get; set; } = null!;

    /// <summary>
    /// PE= Pendiente de recibir documentacion electronica, OK= Proceso completado
    /// </summary>
    public string StatusCodigo { get; set; } = null!;

    /// <summary>
    /// Numero de reclamacion del formulario asignado por la SISALRIL
    /// </summary>
    public int FormularioNumero { get; set; }

    /// <summary>
    /// Codigo del pensionado
    /// </summary>
    public int PensionadoNumero { get; set; }

    /// <summary>
    /// Numero de seguridad social
    /// </summary>
    public long CiudadanoNss { get; set; }

    /// <summary>
    /// Nombre del pensionado
    /// </summary>
    public string PensionadoNombres { get; set; } = null!;

    /// <summary>
    /// Primer apellido del pensionado
    /// </summary>
    public string PensionadoPrimerApeliido { get; set; } = null!;

    /// <summary>
    /// Segundo apellido del pensionado
    /// </summary>
    public string PensionadoSegundoApeliido { get; set; } = null!;

    /// <summary>
    /// Tipo de documento del pensionado (Cédula o Pasaporte)
    /// </summary>
    public string PensionadoDocumentoTipo { get; set; } = null!;

    /// <summary>
    /// Cédula o Pasaporte del pensionado
    /// </summary>
    public string PensionadoDocumentoNo { get; set; } = null!;

    /// <summary>
    /// Fecha de nacimiento del pensionado (AAAAMMDD)
    /// </summary>
    public DateTime? PensionadoFechaNacimiento { get; set; }

    /// <summary>
    /// Código de nacionalidad del pensionado
    /// </summary>
    public short NacionalidadNumero { get; set; }

    /// <summary>
    /// M=Masculino, F= Femenino
    /// </summary>
    public string PensionadoSexo { get; set; } = null!;

    /// <summary>
    /// S=Soltero, C=Casado, U=Union libre
    /// </summary>
    public string EstadoCivilCodigo { get; set; } = null!;

    /// <summary>
    /// Primer número de telefono del pensionado
    /// </summary>
    public string PensionadoTelefono1 { get; set; } = null!;

    /// <summary>
    /// Segundor número de telefono del pensionado
    /// </summary>
    public string PensionadoTelefono2 { get; set; } = null!;

    /// <summary>
    /// Tercer número de telefono del pensionado
    /// </summary>
    public string PensionadoTelefono3 { get; set; } = null!;

    /// <summary>
    /// Correo electronico del pensionado
    /// </summary>
    public string PensionadoEmail { get; set; } = null!;

    /// <summary>
    /// Direccion de la residencia del pensionado
    /// </summary>
    public string PensionadoDireccion { get; set; } = null!;

    /// <summary>
    /// Número de residencia del pensionado
    /// </summary>
    public string PensionadoCasaNumero { get; set; } = null!;

    /// <summary>
    /// Sector donde reside el pensionado
    /// </summary>
    public string PensionadoSectorReside { get; set; } = null!;

    /// <summary>
    /// Código de municipio donde reside el pensionado
    /// </summary>
    public short MunicipioNumero { get; set; }

    /// <summary>
    /// S=Si, N=No
    /// </summary>
    public string PensionadoHijosMenores { get; set; } = null!;

    /// <summary>
    /// Fecha de nacimiento del primer hijo menor en formato (AAAAMMDD)
    /// </summary>
    public DateTime? PensionadoHijo1FechaNacimiento { get; set; }

    /// <summary>
    /// Fecha de nacimiento del Segundo hijo menor en formato (AAAAMMDD)
    /// </summary>
    public DateTime? PensionadoHijo2FechaNacimiento { get; set; }

    /// <summary>
    /// Fecha de nacimiento del Tercer hijo menor en formato (AAAAMMDD)
    /// </summary>
    public DateTime? PensionadoHijo3FechaNacimiento { get; set; }

    /// <summary>
    /// Fecha de nacimiento del cuarto hijo menor en formato (AAAAMMDD)
    /// </summary>
    public DateTime? PensionadoHijo4FechaNacimiento { get; set; }

    /// <summary>
    /// Fecha de nacimiento del quinto hijo menor en formato (AAAAMMDD)
    /// </summary>
    public DateTime? PensionadoHijo5FechaNacimiento { get; set; }

    /// <summary>
    /// Número de seguridad social del conyuge
    /// </summary>
    public long ConyugeNss { get; set; }

    /// <summary>
    /// Nombre del conyuge
    /// </summary>
    public string ConyugeNombres { get; set; } = null!;

    /// <summary>
    /// Primer apllido del conyuge
    /// </summary>
    public string ConyugePrimerApeliido { get; set; } = null!;

    /// <summary>
    /// Segundo apellido del conyuge
    /// </summary>
    public string ConyugeSegundoApeliido { get; set; } = null!;

    /// <summary>
    /// Tipo de documento del conyuge (Cedula o Pasaporte)
    /// </summary>
    public string ConyugeDocumentoTipo { get; set; } = null!;

    /// <summary>
    /// Número de cedula del conyuge
    /// </summary>
    public string ConyugeDocumentoNo { get; set; } = null!;

    /// <summary>
    /// Fecha de nacimiento del conyuge (AAAMMDD)
    /// </summary>
    public DateTime? ConyugeFechaNacimiento { get; set; }

    /// <summary>
    /// Código de nacionalidad del conyuge
    /// </summary>
    public short ConyugeNacionalidadNumero { get; set; }

    /// <summary>
    /// Primer telefono del conyuge
    /// </summary>
    public string ConyugeTelefono1 { get; set; } = null!;

    /// <summary>
    /// Segundo telefono del conyuge
    /// </summary>
    public string ConyugeTelefono2 { get; set; } = null!;

    /// <summary>
    /// Tercer telefono del conyuge
    /// </summary>
    public string ConyugeTelefono3 { get; set; } = null!;

    /// <summary>
    /// Correo electronico del conyuge
    /// </summary>
    public string ConyugeEmail { get; set; } = null!;

    /// <summary>
    /// Direccion de residencia del conyuge
    /// </summary>
    public string ConyugeDireccion { get; set; } = null!;

    /// <summary>
    /// Sector de residencia del conyuge
    /// </summary>
    public string ConyugeSectorReside { get; set; } = null!;

    /// <summary>
    /// Número de municipio donde reside el conyuge
    /// </summary>
    public short ConyugeMunicipioNumero { get; set; }

    /// <summary>
    /// Nombre de la empresa donde laboro el pensionado
    /// </summary>
    public string EmpresaNombre { get; set; } = null!;

    /// <summary>
    /// Direccion de ubicacion de la empresa
    /// </summary>
    public string EmpresaDireccion { get; set; } = null!;

    /// <summary>
    /// Sector de ubicacion de la empresa
    /// </summary>
    public string EmpresaSectorReside { get; set; } = null!;

    /// <summary>
    /// Municipio de ubicacion de la empresa
    /// </summary>
    public short EmpresaMunicipioNumero { get; set; }

    /// <summary>
    /// T=Tiempo en el puesto, E= Emfermedad S= Especial, O Otros
    /// </summary>
    public string PensionMotivoCodigo { get; set; } = null!;

    /// <summary>
    /// Código del motivo de la baja
    /// </summary>
    public string MotivoBajaCodigo { get; set; } = null!;

    /// <summary>
    /// Si el pensionado esta inscrito en una ARS
    /// </summary>
    public string ArsInspcrito { get; set; } = null!;

    /// <summary>
    /// Si el pensionado esta inscrito en una ARS
    /// </summary>
    public string PensionadoInspcritoArs { get; set; } = null!;

    /// <summary>
    /// Fecha de registro
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual TssPensionadosMotivoBajaCatum MotivoBajaCodigoNavigation { get; set; } = null!;

    public virtual TssPensionadosNovedadesDetallesTipoCatum NovedadDetalleTipoCodigoNavigation { get; set; } = null!;

    public virtual TssPensionadosNovedadesTran NovedadNumeroNavigation { get; set; } = null!;

    public virtual TssPensionadosMaster PensionadoNumeroNavigation { get; set; } = null!;

    public virtual TssPensionadosStatusCatum StatusCodigoNavigation { get; set; } = null!;
}
