using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(UsuariosMetadado))]
    public partial class Usuarios
    {

    }

    public class UsuariosMetadado
    {
        [Required(ErrorMessage = "Digite o nome do Usuário")]
        [StringLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o login do Usuário")]
        [StringLength(50, ErrorMessage = "No máximo 50 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha do Usuário")]
        [StringLength(50, ErrorMessage = "No máximo 50 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do Usuário")]
        [StringLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Email { get; set; }
    }
}