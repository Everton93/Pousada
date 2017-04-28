using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("servicos")]
    public class Servicos
    {
        [Key]
        public int servicoID { get; set; }
        [Required]
        public virtual Hospedagem quartoServico { get; set; }
        public string nomeServico { get; set; }
        public float valor { get; set; }
        public string descricao { get; set; }

    }
}
