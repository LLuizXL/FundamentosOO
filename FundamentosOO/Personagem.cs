using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        public virtual void apresentacao()
        {

        }
        public virtual int atacar()
        {

        }
        public virtual int defender()
        {
        }
        public virtual void evolucao()
        {

        }
        public virtual void batalha(Personagem pers)
        {
            Console.WriteLine(this.Nome + " Começa a batalha!");
        }

    }


}
