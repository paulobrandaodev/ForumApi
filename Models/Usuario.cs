using System;
using System.ComponentModel.DataAnnotations;

namespace ForumApi.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name="Nome do Usuário")]
        [Required(ErrorMessage="Este campo é obrigatório")]
        [MinLength(2, ErrorMessage="Você deve inserir um nome com mais de 2 caracteres")]
        [MaxLength(10, ErrorMessage="Você não pode colocar mais do que 10 caracteres no campo nome")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage="Este campo é obrigatório")]
        [MinLength(2, ErrorMessage="Você deve inserir um login com mais de 2 caracteres")]
        [MaxLength(10, ErrorMessage="Você não pode colocar mais do que 10 caracteres no campo login")]
        [RegularExpression(@"^[a-zA-Z- '\s]{1,40}$", ErrorMessage="Você não pode usar caractere especial")]
        public string Login { get; set; }

        [Required(ErrorMessage="Este campo é obrigatório")]
        [MinLength(8, ErrorMessage="Você deve inserir uma senha com mais de 8 caracteres")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}