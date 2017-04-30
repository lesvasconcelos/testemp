using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testemeuspedidos.Models
{
    public class HomeViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório", AllowEmptyStrings = false)]
        [Display(Name ="Nome completo")]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="E-mail")]
        public string Email { get; set; }

        [Range(0, 10,ErrorMessage = "O valor precisa estar no intervalo de 0 a 10")]
        public int? HTML { get; set; }

        [Range(0, 10, ErrorMessage = "O valor precisa estar no intervalo de 0 a 10")]
        public int? CSS { get; set; }

        [Range(0, 10, ErrorMessage = "O valor precisa estar no intervalo de 0 a 10")]
        public int? Javascript { get; set; }

        [Range(0, 10, ErrorMessage = "O valor precisa estar no intervalo de 0 a 10")]
        public int? Python { get; set; }

        [Range(0, 10, ErrorMessage = "O valor precisa estar no intervalo de 0 a 10")]
        public int? Django { get; set; }

        [Range(0, 10, ErrorMessage = "O valor precisa estar no intervalo de 0 a 10")]
        public int? DesenvolvimentoIOS { get; set; }

        [Range(0, 10, ErrorMessage = "O valor precisa estar no intervalo de 0 a 10")]
        public int? DesenvolvimentoAndroid { get; set; }

        public void ProcessarCandidatura()
        {
            var nenhumPerfil = true;

            if (TemPontuacaoMinima(HTML, CSS, Javascript))
            {
                EmailModel.Enviar(EmailPerfil.FrontEnd, Email);
                nenhumPerfil &= false;
            }
            if (TemPontuacaoMinima(Python, Django))
            {
                EmailModel.Enviar(EmailPerfil.BackEnd, Email);
                nenhumPerfil &= false;
            }
            if (TemPontuacaoMinima(DesenvolvimentoAndroid, DesenvolvimentoIOS))
            {
                EmailModel.Enviar(EmailPerfil.Mobile, Email);
                nenhumPerfil &= false;
            }

            if (nenhumPerfil)
            {
                EmailModel.Enviar(EmailPerfil.Generico, Email);
            }
        }

        private bool TemPontuacaoMinima(params int?[] conhecimentos)
        {
            return conhecimentos.All(w => w.HasValue && w.Value >= 7 && w.Value <= 10);
        }
    }
}
