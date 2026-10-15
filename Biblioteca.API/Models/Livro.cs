namespace Biblioteca.API.Models
{
    public class Livro
    {
        public int id { get; set; }
        public string Codigo { get; set; }
        public string NomeAutor { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Titulo { get; set; }
    }
}
