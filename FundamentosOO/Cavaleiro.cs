using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Cavaleiro : Personagem
    {

        public override void apresentacao()
        {
            Console.WriteLine(this.Nome + " é um cavaleiro destemido, conhecido por sua bravura no campo de batalha e sua força incomparável." +
                " Armado com uma poderosa espada e uma armadura reluzente, ele é o símbolo da defesa e honra. " +
                " Sua força física é seu maior trunfo, e ele usa sua agilidade para desviar de ataques inimigos quando necessário." +
                "Pontos de vida: this.Vida, Força: " + this.Forca + ", Inteligência: " + this.Inteligencia + ", Agilidade: " + this.Agilidade);
        }
        public override void atacar()
        {
            int dano = (this.Forca + this.Inteligencia) / 2;

            Console.WriteLine(this.Nome + " avança com sua espada, desferindo um golpe poderoso no inimigo. Dano: ");
        }

        public override void defender()
        {
            Console.WriteLine("levanta seu escudo, bloqueando o ataque inimigo e reduzindo o dano recebido. Pontos de Defesa: ");
        }
    }
}
