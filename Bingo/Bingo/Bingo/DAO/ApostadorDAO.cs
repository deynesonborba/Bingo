using Bingo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Bingo.DAO
{
    public class ApostadorDAO
    {
        public void insertApostador(Apostador apostador)
        {
            Context context = new Context();
            context.Apostadores.Add(apostador);
            context.SaveChanges();
        }

        public Apostador buscarApostardorPorId(int id)
        {
            Context context = new Context();
            return context.Apostadores.Where(a => a.IdApostador == id).FirstOrDefault();
        }

        public Apostador buscarApostadorPeloNome(Object nome)
        {
            Context context = new Context();
            return context.Apostadores.Where(a => a.Nome == nome.ToString()).FirstOrDefault();
        }

        public static IOrderedEnumerable<Apostador> buscarApostadorPeloNomeString(Apostador apostador)
        {
            Context context = new Context();
            //return context.Apostadores.Where(a => a.Nome == nome.ToString()).FirstOrDefault();
            return context.Apostadores.Where(b => b.Nome.Contains(apostador.Nome)).ToList().OrderBy(b => b.Nome);
        }

        public Apostador buscarPeloCpf(String cpf)
        {
            Context context = new Context();
            return context.Apostadores.Where(a => a.Cpf == cpf.ToString()).FirstOrDefault();

        }

        public static Apostador buscarPeloCpfTela(Apostador apostador)
        {
            Context context = new Context();
            //return context.Apostadores.Where(a => a.Cpf == cpf.ToString()).FirstOrDefault();

            try
            {
                return context.Apostadores.FirstOrDefault(x => x.Cpf == apostador.Cpf);
            }
            catch
            {
                return null;
            }
        }

        public List<Apostador> listarApostadores()
        {
            Context context = new Context();
            return context.Apostadores.ToList();
        }

        public void alterarApostador(Apostador apostador)
        {
            Context context = new Context();
            context.Entry(apostador).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
