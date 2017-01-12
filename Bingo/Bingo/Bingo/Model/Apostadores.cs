using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Model
{
   
    public class Apostadores
    {
        [Key]
        public int IdApostador { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(20)]
        public string  Telefone { get; set; }
        [StringLength(20)]
        public string Cpf { get; set; }
        //teste
    }
}
