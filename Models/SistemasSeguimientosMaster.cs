using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasSeguimientosMaster
{
    public int SeguimientoNumero { get; set; }

    public int ArchivoNumero { get; set; }

    public short SeguimientoEstadoNumero { get; set; }

    public string SeguimientoArchivoNombre { get; set; } = null!;

    public DateTime SeguimientoArchivoFecha { get; set; }

    public string SeguimientoArchivoUsuario { get; set; } = null!;

    public int SeguimientoRegistrosCantidad { get; set; }

    public string SeguimientoArchivoRespuestaNombre { get; set; } = null!;

    public DateTime SeguimientoArchivoRespuestaFecha { get; set; }

    public string SeguimientoArchivoRespuestaUsuario { get; set; } = null!;

    public int SeguimientoPadreNumero { get; set; }

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

    public virtual SistemasArchivosCatum ArchivoNumeroNavigation { get; set; } = null!;

    public virtual CambiosExcepcionesAltasTran? CambiosExcepcionesAltasTran { get; set; }

    public virtual CambiosExcepcionesBajasTran? CambiosExcepcionesBajasTran { get; set; }

    public virtual CambiosExcepcionesSolicitudesTran? CambiosExcepcionesSolicitudesTran { get; set; }

    public virtual SistemasSeguimientosEstadosCatum SeguimientoEstadoNumeroNavigation { get; set; } = null!;

    public virtual TraspasosAccionSisalrilArsOrigenDestinoTran SeguimientoNumero1 { get; set; } = null!;

    public virtual TraspasosNucufNotificacionCondicionEnfermedadTran SeguimientoNumero10 { get; set; } = null!;

    public virtual TraspasosNucufNotificacionPreavisoEfectividadTran SeguimientoNumero11 { get; set; } = null!;

    public virtual TraspasosNucufNotificacionSolicitudesArsDestinoTran SeguimientoNumero12 { get; set; } = null!;

    public virtual TraspasosRespuestaAccionCondicionEnfermedadTran SeguimientoNumero13 { get; set; } = null!;

    public virtual TraspasosCancelacionSisalrilArsTran SeguimientoNumero2 { get; set; } = null!;

    public virtual TraspasosNotificacionArsCancelacionTran SeguimientoNumero3 { get; set; } = null!;

    public virtual TraspasosNotificacionCondicionEnfermedadTran SeguimientoNumero4 { get; set; } = null!;

    public virtual TraspasosNucufAccionCondicionEnfermedadTran SeguimientoNumero5 { get; set; } = null!;

    public virtual TraspasosNucufAltasTran SeguimientoNumero6 { get; set; } = null!;

    public virtual TraspasosNucufAutorizacionCancelacionTran SeguimientoNumero7 { get; set; } = null!;

    public virtual TraspasosNucufBajasTran SeguimientoNumero8 { get; set; } = null!;

    public virtual TraspasosNucufDetalleAutorizacionCancelacionTran SeguimientoNumero9 { get; set; } = null!;

    public virtual TraspasosAccionCondicionEnfermedadTran SeguimientoNumeroNavigation { get; set; } = null!;
}
