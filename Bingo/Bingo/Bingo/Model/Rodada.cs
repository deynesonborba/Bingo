using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Model
{
    public class Rodada
    {
        [Key]
        public int IdRodadas { get; set; }
        public int IdCartela { get; set; }        
        [StringLength(200)]
        public String NumerosSorteados { get; set; }
        public int IdBrindes { get; set; }
        [ForeignKey("IdBrindes")]
        public virtual Brinde brinde { get; set; } // ESTÁ É A PROPRIEDADE QUE DUPLICA NO BANCO
        public DateTime DataRodada { get; set; }
        public int QuantNumerosSorteados { get; set; }
    }
}
