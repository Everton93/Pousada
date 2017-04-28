using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("_Conta")]
    public class Conta
    {
        [Key]
        
        public int contaID { get; set; }
        [ForeignKey("_hospedeContaID")]
        public virtual Quarto quartoConta { get; set; }
        [ForeignKey("_quartoContaID")]
        public virtual Cliente hospedeConta { get; set; }
        public List<Servicos> servicosCliente { get; set; }
        public float valorTotal { get; set; }


    }
}
