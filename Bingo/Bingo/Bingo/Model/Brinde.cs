using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Model
{
    public class Brinde
    {
        [Key]
        public int IdBrindes { get; set; }
        [StringLength(80)]
        public string NomeBrinde { get; set; }
        public String Situacao { get; set; }
    }
}
