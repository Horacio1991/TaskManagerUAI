namespace Entity
{
    public class Tarea
    {
        public int TareaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaSolicitada { get; set; }
        public DateTime FechaEsperadaFinalizacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public int EstadoTareaId { get; set; }
        public int UsuarioId { get; set; }
    }
}
