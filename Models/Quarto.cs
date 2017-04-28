using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("_Quarto")]
    public class Quarto
    {
        [Key]
        public int quartoID { get; set; }
        public string tipoQuarto { get; set; }
        public double precoDiaria { get; set; }

        [Required, StringLength(130)]
        public string descricao { get; set; }
    }
}
