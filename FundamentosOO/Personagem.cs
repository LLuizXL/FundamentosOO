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
        public virtual void atacar()
        {

        }
        public virtual void defender()
        {

        }
        public virtual void evolucao()
        {

        }
        public virtual void Batalha(Personagem pers)
        {
            int dano1 = this.Forca + this.Inteligencia / 2;
            int defesa1 = (this.Vida + this.Inteligencia) / 3;

            int dano2 = this.Forca + this.Inteligencia / 2;
            int defesa2 = (this.Vida + this.Inteligencia) / 3;


            Console.WriteLine("--------" + this.Nome + " Começa a batalha!" + "---------");
            this.atacar();


            Console.WriteLine("Vida restante do Oponente: ");

            Console.WriteLine(pers.Vida - dano);


        }

    }


}
