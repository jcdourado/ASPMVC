using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(CidadesMetadado))]
    public partial class Cidades
    {

    }

	public class CidadesMetadado
	{
        
        [Required(ErrorMessage = "Digite o nome da Cidade")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
        public string Nome { get; set; }

        
        public virtual ICollection<Medicos> Medicos { get; set; }

    }
}