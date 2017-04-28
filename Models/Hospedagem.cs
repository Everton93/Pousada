using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("_Hospedagem")]
    public class Hospedagem
    {
        [Key]
        public int hospedagemID { get; set; }
        [Required]
        public virtual Cliente clienteHospede { get; set; }
        [Required]
        public virtual Quarto quarto { get; set; }
        public int numPessoas { get; set; }
        public IList<Servicos> servicosHospede { get; set; }
    }
}
