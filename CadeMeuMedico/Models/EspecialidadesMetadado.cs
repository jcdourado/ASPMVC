using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{

    [MetadataType(typeof(EspecialidadesMetadado))]
    public partial class Especialidades
    {

    }

    public class EspecialidadesMetadado
    {
        
        [Required(ErrorMessage = "Digite o nome da Especialidade")]
        [StringLength(100, ErrorMessage = "Digite no máximo 100 caracteres")]
        public string Nome { get; set; }

        public virtual ICollection<Medicos> Medicos { get; set; }
    }
}