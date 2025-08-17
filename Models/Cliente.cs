using System.ComponentModel.DataAnnotations;

namespace BancoAPI.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public string Cpf { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; }
    }
}