using System;
using System.ComponentModel.DataAnnotations;

namespace CursoMVCAbril.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            EnderecoId = Guid.NewGuid();
        }
        [Key]

        public Guid EnderecoId { get; set; }

        [Required]
        [MaxLength(300)]

        public string Logradouro { get; set; }

        [Required]
        [MaxLength(6)]

        public string Numero { get; set; }

        [Required]
        [MaxLength(8)]

        public string CEP { get; set; }

        [Required]
        [MaxLength(50)]

        public string Bairro { get; set; }

        [MaxLength(300)]

        public string Complemento { get; set; }

        [Required]

        public Guid ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; } 
    }
}