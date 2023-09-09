using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O título do filme é obrigatório")]
        public string Title { get; set; }
        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public string Gender { get; set; }
        [Required]
        [Range(60, 600, ErrorMessage = "A duração deve ter entre 60 e 600 minutos")]
        public int Duration { get; set; }
    }
}
