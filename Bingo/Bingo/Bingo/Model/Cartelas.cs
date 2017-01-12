using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Model
{
    
    public class Cartelas
    {
        [Key]
        public int IdCartela { get; set; }
        public int numero1 { get; set; }
        public int numero2 { get; set; }
        public int numero3 { get; set; }
        public int numero4 { get; set; }
        public int numero5 { get; set; }
        public int numero6 { get; set; }
        public int numero7 { get; set; }
        public int numero8 { get; set; }
        public int numero9 { get; set; }
        public int numero10 { get; set; }
        public int ApostadorId { get; set; }
        [ForeignKey("ApostadorId")]
        public virtual Apostadores IdApostador { get; set; }


    }
}
