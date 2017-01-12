using Bingo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.DAO
{
    class BrindeDAO
    {        
        public void insertBrinde(Brinde brinde)
        {
            Context context = new Context();
            {
                context.Brindes.Add(brinde);
                context.SaveChanges();
            }
        }

        public Brinde buscarBrindePorNome(Object nome)
        {
            Context context = new Context();
            Brinde brinde = context.Brindes.Where(b => b.NomeBrinde == nome.ToString()).FirstOrDefault();
            return brinde;
        }

        public static IOrderedEnumerable<Brinde>  buscarBrindePorNomeString(Brinde brinde)
        {
            Context context = new Context();
            return context.Brindes.Where(b => b.NomeBrinde.Contains(brinde.NomeBrinde)).ToList().OrderBy(b => b.NomeBrinde);
        }

        public Brinde buscarBrindePorId(int id)
        {
            Context context = new Context();
            Brinde brinde = context.Brindes.Where(b => b.IdBrindes == id).FirstOrDefault();
            return brinde;
        }
        public void AlteraBrinde(Brinde brinde)
        {
            Context context = new Context();
            {
                context.Entry(brinde).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Brinde> ListaBrindes()
        {
            Context context = new Context();
            List<Brinde> listaBrindes = context.Brindes.ToList(); 
             
            return listaBrindes;
        }
    }
}
