﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Nupre_API.DTOs;
using Nupre_API.Entidades;
using System.Net.Quic;

namespace Nupre_API.Repositorio
{
    
    public class RepositorioProfesionalesActividadesTrans : IRepositorioProfesionalesActividadesTrans
    {
        private readonly ApplicationDbContext context;
        public RepositorioProfesionalesActividadesTrans(ApplicationDbContext contex)
        {
            this.context = contex;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="trans"></param>
        /// <returns></returns>
        public async Task<Solicitudes_Actividades_Trans> Crear(Solicitudes_Actividades_Trans trans)
        {
            trans.RegistroFecha = DateTime.Now; 
            
            context.Add(trans);
            await context.SaveChangesAsync( );
            return trans;
        }


        public async Task<List<Solicitudes_Actividades_Trans>> obtenerActididades(Solicitudes_Actividades_Trans trans)
        {
            return await context.Profesionales_Solicitudes_Actividades_Trans.Where(x => x.Solicitud_Numero == trans.Solicitud_Numero
            && x.RegistroEstado == "A"
            ).ToListAsync();
        }

        public async Task<Solicitudes_Actividades_Trans> obtenerActididadesPorSolicitud(Solicitudes_Actividades_Trans trans)
        {

            return await context.Profesionales_Solicitudes_Actividades_Trans.Where(x =>
             x.RegistroEstado == "A" &&
            x.Solicitud_Numero == trans.Solicitud_Numero).FirstOrDefaultAsync(); 
        }

        public async Task<List<Solicitudes_Actividades_Progress_DTO>> obtener_Progreso_solicitudes(int solicitudNumero) {

            var resultado = new List<Solicitudes_Actividades_Progress_DTO>(); 
            var query = await context.Profesionales_Actividades_Tipos_Cata.Where(X => X.Registro_Estado == "A").ToListAsync();
            var actividadesRealizadas = context.Profesionales_Solicitudes_Actividades_Trans.Where(x => x.Solicitud_Numero == solicitudNumero && x.RegistroEstado == "A").ToList();


            foreach (var (index, item) in query.Select((item, index) => (index, item)))
            {

                resultado.Add(new Solicitudes_Actividades_Progress_DTO
                {
                    Actividad_numero = item.Actividad_Numero,
                    Actividad_descripcion = item.Actividad_Descripcion,
                    Proceso_Orden = item.Actividad_Numero,
                    Actividad_Completa = actividadesRealizadas.Exists(li => li.Actividad_Numero == item.Actividad_Numero) == true ? 1 : 0,
                    //Actividad_Completa = (actividadesRealizadas.Exists(li => li.Actividad_Numero == a.Actividad_Numero) == true ? 0 : 1),

                    Porcentaje = (actividadesRealizadas.Count() / 100)
                });
            }


            //var reusltado;

            //    .Select(a => new Solicitudes_Actividades_Progress_DTO
            //    {
            //        Actividad_numero = a.Actividad_Numero,
            //        Actividad_descripcion = a.Actividad_Descripcion,
            //        Proceso_Orden = a.Actividad_Numero,
            //        Actividad_Completa = (actividadesRealizadas.Exists(li => li.Actividad_Numero == a.Actividad_Numero)== true ? 0 : 1),

            //        Porcentaje = (actividadesRealizadas.Count() / 100)

            //    }).ToList();



            return resultado; 
              

        }
    }   

}
