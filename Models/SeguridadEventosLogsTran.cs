﻿using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un tabla transaccional donde se los LOGS de accedo y ejecuciones de los usuarios  que utilizan los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguridadEventosLogsTran
{
    /// <summary>
    /// Número único  del registro log del sistema.
    /// </summary>
    public long EventoLogNumero { get; set; }

    /// <summary>
    /// Número único del  tipo eventos log  que se ejecuta en el sistema.
    /// </summary>
    public byte EventoLogTipoNumero { get; set; }

    /// <summary>
    /// Observación sobre la  operación del evento que genero el registro log del sistema.
    /// </summary>
    public string EventoLogObservacion { get; set; } = null!;

    /// <summary>
    /// Nombre el usuario que origino la operación del evento que genero el registro log del sistema.
    /// </summary>
    public string UsuarioUsuarioNombre { get; set; } = null!;

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

    public virtual SeguridadEventosLogsTipoCatum EventoLogTipoNumeroNavigation { get; set; } = null!;

    public virtual SeguridadUsuariosMaster UsuarioUsuarioNombreNavigation { get; set; } = null!;
}
