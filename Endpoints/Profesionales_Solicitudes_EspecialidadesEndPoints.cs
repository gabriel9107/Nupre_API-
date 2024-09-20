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
            return group;
        }


  
        public static async Task<Created<CrearProfesion_Especialidad_DTO>> Crear([FromForm] CrearProfesion_Especialidad_DTO solicitud, IRepositorioProfesionalesEspecialidadesTrans repositorio, 
            IMapper mapper,IAlmacenadorArchivos almacenadorArchivos )
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


        public static async Task<Ok<List<Profesionales_Solicitudes_Especialidades_Trans>>> obtenerListadoPorSolicitud(IRepositorioProfesionalesEspecialidadesTrans repositorio, int solicitud_numero)
        {

            var titulos = await repositorio.obtenerTitulacionPorSolicitud(solicitud_numero);
            
            return TypedResults.Ok(titulos);
        }
         


    }
}
