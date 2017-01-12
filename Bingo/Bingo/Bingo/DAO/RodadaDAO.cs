using Bingo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.DAO
{
    public class RodadaDAO
    {
        //public static List<RodadaDao> rodadas = new List<RodadaDao>();
        public void SalvarRodada(Rodada rodada)
        {
            Context context = new Context();
            {
                context.Rodadas.Add(rodada);
                context.SaveChanges();
            }
        }

        public Rodada buscarRodadaPorId(int id)
        {
            Context context = new Context();
            Rodada rodada = context.Rodadas.Where(r => r.IdRodadas == id).FirstOrDefault();
            return rodada;
        }

        public void AlterarRodada(Rodada rodada)
        {
            Context context = new Context();
            context.Entry(rodada).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}