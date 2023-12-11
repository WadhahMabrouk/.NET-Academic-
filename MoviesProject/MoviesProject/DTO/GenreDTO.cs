using System.ComponentModel.DataAnnotations;

namespace MoviesProject.DTO
{
    public class GenreDTO
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
