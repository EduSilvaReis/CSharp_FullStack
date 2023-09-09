using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class ReadFilmeDto
    {
        public string Title{ get; set; }
        public string Gender { get; set; }
        public int Duration { get; set; }
        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
        public ICollection<ReadSessaoDto> Sessoes { get; set; }
    }
}