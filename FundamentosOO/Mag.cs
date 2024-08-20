using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Mago : Personagem
    {
        public override void apresentacao()
        {
            Console.WriteLine("Goofier é uma maga talentosa, conhecida por seu domínio sobre a magia elemental e seus feitiços poderosos." +
          " Com sua inteligência afiada e conhecimento profundo dos arcanos, ela pode conjurar feitiços devastadores e manipular as forças da natureza." +
          " Apesar de sua baixa força física, ela compensa com sua incrível agilidade e habilidades mágicas." +
          "                                     Pontos de vida: " + this.Vida + ", Força: " + this.Forca + ", Inteligência: " + this.Inteligencia + ", Agilidade: " + this.Agilidade + ", ");

        }

        public override void atacar()
        {
            int dano = this.Forca + this.Inteligencia / 2;


            Console.WriteLine("Elara conjura uma esfera de chamas que explode ao atingir o alvo, causando dano massivo de fogo e queimaduras contínuas.    Dano: ");
            Console.WriteLine(dano);

        }
        public override void defender()
        {
            Console.WriteLine("Elara ergue uma barreira arcana que absorve parte dos danos recebidos, refletindo um pouco de energia mágica de volta aos atacantes." +
                "Pontos de Defesa: " + (this.Agilidade + this.Inteligencia) / 3);
        }

        public override void evolucao()
        {
            Console.WriteLine(this.Nome + " Subiu de nivel, Boa!");

        }
    }
}
