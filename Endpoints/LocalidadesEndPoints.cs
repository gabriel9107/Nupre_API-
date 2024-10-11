using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nupre_API.DTOs;
using Nupre_API.Entidades;
using Nupre_API.Repositorio;

namespace Nupre_API.Endpoints
{


    public static class  LocalidadesEndPoints
    {
        private static readonly string contenedor = "Localidades"; 

        public static RouteGroupBuilder mapProfesionales_Solicitudes_Localidades(this RouteGroupBuilder group)
        {

            group.MapPost("crearLocalidad", Crear).DisableAntiforgery();
            group.MapGet("obtenerLocalidad", BuscarPorId);
            group.MapGet("obtenerListado", BuscarListadoPorId);
            return group;
        }

        public static async Task<Created<Profesionales_Solicitudes_Localidades_Tran>> Crear([FromBody] Crear_Localidades_DTO trans, IRepositorioProfesionales_Solicitudes_Localidades_Tran repositorio, IMapper mapper, IRepositorioProfesionalesActividadesTrans actividades)
        {

            var  post = mapper.Map<Profesionales_Solicitudes_Localidades_Tran>( trans );

            if (post.Localidad_Secuencia != 0)
            {
                var existe = await actividades.existe(post.Solicitud_Numero, 4);
                if (existe == false)
                {
                    var actividad = new Solicitudes_Actividades_Trans()
                    {
                        Actividad_Numero = 4,
                        Solicitud_Numero = post.Solicitud_Numero,
                        Solicitud_Tipo_Numero = 1,
                        Actividad_Contenido = "N/A",
                        Sometimiento_Secuencia = 1,
                        RegistroUsuario = post.Registro_Usuario,
                        RegistroEstado = "A"

                    };

                    await actividades.Crear(actividad);

                }



            }

            var respuesta = await repositorio.Crear(post);
            return TypedResults.Created($"/{respuesta.Solicitud_Numero}", respuesta);


        }  



        public static async Task<Results<Ok<List<Profesionales_Solicitudes_Localidades_Tran>>, NotFound>> BuscarListadoPorId(IRepositorioProfesionales_Solicitudes_Localidades_Tran repositorio, int id)
        {
            var query = await repositorio.ObtenerListaLocalidadesPoId(id);
            return TypedResults.Ok(query);
        }


        public static async Task<Results<Ok<Profesionales_Solicitudes_Localidades_Tran>, NotFound>> BuscarPorId(IRepositorioProfesionales_Solicitudes_Localidades_Tran repositorio, int id)
        {

            var query = await repositorio.obtenerId(id);
            //if(query is null)
            //{
            //    return TypedResults.NotFound(); 
            //}
            return TypedResults.Ok(query);
        }
    }
}
