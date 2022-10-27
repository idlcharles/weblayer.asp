

using System.ComponentModel.DataAnnotations;

namespace WebLayer.Models
{
    public class ClienteInsertViewModel
    {        [Required(ErrorMessage = "Nome deve ser Informado.")]
        public string Nome { get; set; }
                [Required(ErrorMessage = "CPF deve ser Informado.")]
        public string CPF { get; set; }
                [DataType(DataType.Date)]
        [Required(ErrorMessage = "Data deve ser Informada.")]
        public DateTime DataNascimento { get; set; }
                [EmailAddress(ErrorMessage = "Email Inválido")]
        [Required(ErrorMessage = "Email válido deve ser Informado.")]
        public string Email { get; set; }
        public bool Ativo { get; set; }

    }
}
