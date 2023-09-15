using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace AplicacoWebds.Models
{
    public class CLiente
    {
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Usuário")]
        public string nomecli { get; set; }

        [Required(ErrorMessage = "código inválido", AllowEmptyStrings = false)]
        public int codcli { get; set; }

        [Required(ErrorMessage = "informe um endereço válido", AllowEmptyStrings = false)]
        [Display(Name = "Informe seu endereço")]
        [StringLength(50, MinimumLength = 20)]
        public string endereco{get; set;}

        [Required(ErrorMessage = "informe um telefone válido", AllowEmptyStrings = false)]
        [Display(Name = "informe seu telefone")]
        [DisplayFormat(DataFormatString = "{9,c}")]
        public string telefone { get; set; }
        
        [Required(ErrorMessage = "Informe o seu email")]
        [RegularExpression("@\"\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*\" ")]
        public string email { get; set;}


        [Required(ErrorMessage = "O CPF é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe seu CPF")]
        [StringLength(12, MinimumLength = 12)]
        public int cpf { get; set; }


        [Required(ErrorMessage = "A data de nascimento é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "yyyy/mm/dd")]
        public DateTime datanasc { get; set; }
        
    }
}