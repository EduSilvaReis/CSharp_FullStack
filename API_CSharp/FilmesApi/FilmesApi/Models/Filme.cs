using System.ComponentModel.DataAnnotations;//responsavel por validar a necessidade de determinados campos 

namespace FilmesApi.Models;

public class Filme
{
    #region DataAnnotations
    /*A anotação[Required] torna obrigatório passar um parâmetro determinado.
    A anotação[StringLength] limita o tamanho de caracteres de uma string.
    A anotação [Range] limita o intervalo inferior e superior para valores numéricos.
    */
    #endregion

    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Title { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Gender { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duration { get; set; }
    public virtual ICollection<Sessao> Sessoes { get; set; }

    /*[Required(ErrorMessage = "O Description do filme é obrigatório")]
    [MaxLength(8000, ErrorMessage = "O tamanho da desrição não pode exceder 8000 caracteres")]
    [MinLength(20, ErrorMessage = "O tamanho da desriçãonão pode ser menor que 20 caracteres")]
    public string Description { get; set; }
    public DateTime UpdatedDate { get; set;}*/
}

