using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.AspNetCore.Mvc;
using Nupre_API.DTOs;
using Nupre_API.Entidades;
using Nupre_API.Repositorio;
using Nupre_API.Servicios;
using Microsoft.AspNetCore.Builder;

namespace Nupre_API.Endpoints
{
    public static class Profesionales_Solicitudes_EspecialidadesEndPoints
    {
        private static readonly string contenedor = "Titulacion_Especialidades";
        public static RouteGroupBuilder mapProfesionalesEspecialidades(this RouteGroupBuilder group)
        {
            group.MapPost("guardarTitulacion", Crear).DisableAntiforgery(); 
            group.MapGet("listadoTitulacion/{solicitud_numero}", obtenerListadoPorSolicitud);
            group.MapGet("obtenerTitulacionByNumeroSolicitud", obtenerPorId);
            return group;
        }


  
        public static async Task<Created<CrearProfesion_Especialidad_DTO>> Crear([FromForm] CrearProfesion_Especialidad_DTO solicitud, IRepositorioProfesionalesEspecialidadesTrans repositorio, 
            IMapper mapper,IAlmacenadorArchivos almacenadorArchivos, IRepositorioProfesionalesActividadesTrans actividades )
        {


            CrearDocumentoComun_DTO DocumentoTitulo;
            int _nomeDocumentoTitulo;


            var _solicitud = mapper.Map<Profesionales_Solicitudes_Especialidades_Trans>(solicitud);

            if(solicitud.Documento_Codigo is not null)
            {
                DocumentoTitulo = await almacenadorArchivos.Almacenar_NombreArchivo(contenedor, solicitud.Documento_Codigo);

                _solicitud.Documento_Codigo = DocumentoTitulo.Nombre;
            }

           




            var id = await repositorio.Crear(_solicitud);
                
            if(id != 0)
            {
                var existe = await actividades.existe(_solicitud.Solicitud_Numero, 2);
                if (existe == false)
                {
                    var actividad = new Solicitudes_Actividades_Trans()
                    {
                        Actividad_Numero = 2,
                        Solicitud_Numero = _solicitud.Solicitud_Numero,
                        Solicitud_Tipo_Numero = 1,
                        Actividad_Contenido = "N/A",
                        Sometimiento_Secuencia = 1,
                        RegistroUsuario = _solicitud.Registro_Usuario,
                        RegistroEstado = "A"

                    };

                    await actividades.Crear(actividad);

                }
               
               
               
            }



            return TypedResults.Created($"/{id}", solicitud);
        }


        public static async Task<Results<Ok<Profesionales_Solicitudes_Especialidades_Trans>, NotFound>> obtenerEspecialidadestrans(IRepositorioProfesionalesEspecialidadesTrans repositorio, int id)
        {
            var titulacion = await repositorio.obtenerTitulacionPorId(id);
            if (titulacion is null)
            {
                return TypedResults.NotFound();

            }
            return TypedResults.Ok(titulacion);
        }


        public static async Task<Ok<List<DetalleProfesionales_DTO>>> obtenerListadoPorSolicitud(IRepositorioProfesionalesEspecialidadesTrans repositorio, int solicitud_numero)
        {

            var titulos = await repositorio.ObtenerTitulacionPorSolicitud(solicitud_numero);
            
            return TypedResults.Ok(titulos);
        }


        public static async Task<Ok<DetalleProfesionales_DTO>> obtenerPorId(IRepositorioProfesionalesEspecialidadesTrans repositorio, int solicitud_numero)
        {

            var titulos = await repositorio.ObtenerPorId(solicitud_numero);

            return TypedResults.Ok(titulos);
        }



    }
}
