namespace Nupre_API.Entidades
{
    public partial class Prestadoras_Master
    {
        public int Prestadora_Numero { get; set; }
        public string Prestadora_Nombre { get; set; }
        //public string Medico_Cedula { get; set; }
        public int Prestadora_Categoria_Numero { get; set; }

        public string Registro_Estado { get; set; }
        public string Registro_Usuario { get; set; }
        public DateTime Registro_Fecha { get; set; }

    }
}
