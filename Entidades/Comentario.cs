namespace WebAPIAutores.Entidades
{
    public class Comentario
    {
        public int id { get; set; }
        public string Contenido { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }
    }
}
