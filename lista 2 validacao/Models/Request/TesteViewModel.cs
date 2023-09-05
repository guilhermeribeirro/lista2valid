using aplicativo_wb_co.Models.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace aplicativo_wb_co.Models.Request
{
    public class TesteViewModel
    {
        public string Nome { get; set; }



        [RACustomValidation(ErrorMessage = "O campo RA deve começar com 'RA' seguido de 6 dígitos numéricos.")]
        public string RA { get; set; }



        public int Idade { get; set; }


        [CpfValidation(ErrorMessage = "CPF inválido")]

        public string CPF { get; set; }
    }

}
