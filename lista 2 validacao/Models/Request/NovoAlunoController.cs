using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace aplicativo_wb_co.Models.Request
{
    public class NovoAlunoViewModel
    {

        [Required(ErrorMessage = "Nome é obrigatorio")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "RA é obrigatorio")]
        [MinLength(3, ErrorMessage = "A descrição deve ter no mínimo 3 caracteres.")]
        public string RA { get; set;}



        [Required(ErrorMessage = "Email é obrigatorio")]
        [MinLength(3, ErrorMessage = "A descrição deve ter no mínimo 3 caracteres.")]
        public string  Email { get; set;}



        [Required(ErrorMessage = "CPF é obrigatorio")]
        public string CPF { get; set; }

        public int Idade { get; set; }  

        [Required(ErrorMessage = "ativo é obrigatorio")]
        public bool Ativo { get; set;}
    }
}
