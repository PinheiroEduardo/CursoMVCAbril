using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CursoMVCAbril.Application.ViewModels
{
    public class ClienteEnderecoViewModel
    {
        public ClienteEnderecoViewModel()
        {
            EnderecoId = Guid.NewGuid();
            ClienteId = Guid.NewGuid();
        }

        //Cliente
        
        [Key]
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínino {0} caracteres")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("CPF")]

        public string CPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]

        public DateTime DataNascimento { get; set; }

        [ScaffoldColumn(false)]

        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }


        public virtual ICollection<EnderecoViewModel> Enderecos { get; set; } 



        //Endereço
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

    }
}