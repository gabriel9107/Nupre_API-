namespace Nupre_API.Entidades
{
    public class Profesionales_Asociaciones_Tipo_Cata
    {

        //Numero de la asociacion 
        public int Asociacion_Numero { get; set; }

        //Nombre de la sociacion 
        public string Asociacion { get; set; } = null!; 

        
        public string Descripcion { get; set; } = null!;
        public string Registro_Estado { get; set; } = null!;
        public string Registro_Usuario { get; set; } = null!;
        public DateTime Registro_Fecha { get; set; }


    }
}
