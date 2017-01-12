using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Model
{
    public class Rodadas
    {
        [Key]
        public int IdRodadas { get; set; }
        public int CartelasId { get; set; }
        [ForeignKey("CartelasId")]
        public virtual Cartelas IdCartelas { get; set; }
        [StringLength(200)]
        public String NumerosSorteados { get; set; }
        public int BrindesId { get; set; }
        [ForeignKey("BrindesId")]
        public virtual Brindes IdBrindes { get; set; }
        public DateTime DataRodada { get; set; }
    }
}
