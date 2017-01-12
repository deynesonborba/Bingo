using Bingo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Bingo.DAO
{
    public class CartelaDAO
    {
        public void SalvarCartela(Cartela cartela)
        {
            Context context = new Context();
            {
                context.Cartelas.Add(cartela);
                context.SaveChanges();
            }
        }

        public void AlteraCartela(Cartela cartela)
        {
            Context context = new Context();
            {
                context.Entry(cartela).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Cartela buscarCartelaPorIdApostador(int apostadorId)
        {
            Context context = new Context();
            return context.Cartelas.Where(c => c.IdApostador == apostadorId).FirstOrDefault();
        }

        public Cartela buscarCartelaPelosNumeros(String numerosParameter)
        {
            Context context = new Context();
            return context.Cartelas.Where(c => c.NumerosCartela.Equals(numerosParameter)).FirstOrDefault();
        }
    }
}

