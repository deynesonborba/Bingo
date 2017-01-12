using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bingo.View;

namespace Bingo.Model
{
    
    public class Cartela
    {
        [Key]
        public int IdCartela { get; set; }
        [StringLength(200)]
        public String NumerosCartela { get; set; }
        public int IdApostador { get; set; }
        //[ForeignKey("IdApostador")]
        //public virtual Apostador apostador { get; set; } // ESTÁ É A PROPRIEDADE QUE DUPLICA NO BANCO
        public int IdRodadas { get; set; }
        [ForeignKey("IdRodadas")]
        public virtual Rodada rodada { get; set; }     
    }
}
