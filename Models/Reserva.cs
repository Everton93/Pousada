using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("_Reserva")]
    public class Reserva
    {
        [Key]
        public string reservaID { get; set; }
        [ForeignKey("hospdedeReservaID")]
        public virtual Cliente hospede { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataSaida { get; set; }
        public int numPessoas { get; set; }

        [Required]
        public virtual Quarto tipoQuarto { get; set; }


    }
}
