using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public void ApresentarSe()
        {
            Console.WriteLine("Hi, my name is " + this.Nome + ", i am " + this.Idade + " years old, I'm working as a " + this.Cargo +
                "and i think epic games gives me " + this.Salario + " bucks per year cause i be clapping these bots bruh. too ez");
        }
    }
}
