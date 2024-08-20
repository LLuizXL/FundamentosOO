using FundamentosOO;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

internal class Program
{


    private static void Main(string[] args)
    {
        //Livro livro1 = new Livro();

        //livro1.Titulo = "Harry Potter";
        //livro1.Editora = "Editora Abril";
        //livro1.Autor = "J.K. Rowling";
        //livro1.AnoLancamento = 2001;

        //Livro livro2 = new Livro();
        //livro2.Titulo = "X-Men: Espelho Negro";
        //livro2.Autor = "Marjorie M. Liu";
        //livro2.Editora = "Panini Comics";
        //livro2.AnoLancamento = 2006;

        //Livro livro3 = new Livro();
        //livro3.Titulo = "Call of Duty WWII: Field Manual";
        //livro3.Autor = "Activision";
        //livro3.Editora = "Treyarch Studios";
        //livro3.AnoLancamento = 2017;

        //instanciar (criar objeto) do tipo Aluno
        Aluno Aluno1 = new Aluno();

        // Preencher os atributos do objeto
        Aluno1.Nome = "Luiz Guilherme Vieira de Melo";
        Aluno1.RM = "3782";
        Aluno1.Email = "luiz.mwlo76@gmail.com";
        Aluno1.Nascimento = new DateOnly(2007, 06, 06);

        Aluno Aluno2 = new Aluno();

        Aluno2.Nome = "Melo de Vieira Guilherme Luiz";
        Aluno2.RM = "2873";
        Aluno2.Email = "alter.ego@gmail.com";
        Aluno2.Nascimento = new DateOnly(2006, 07, 07);

        //Imprimir na tela
        Console.WriteLine("Aluno1");
        Console.WriteLine("Nome: " + Aluno1.Nome);
        Console.WriteLine("RM:" + Aluno1.RM);
        Console.WriteLine("Email: " + Aluno1.Email);
        Console.WriteLine("Data Nascimento: " + Aluno1.Nascimento);
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Aluno2");
        Console.WriteLine("Nome: " + Aluno2.Nome);
        Console.WriteLine("RM:" + Aluno2.RM);
        Console.WriteLine("Email: " + Aluno2.Email);
        Console.WriteLine("Data Nascimento: " + Aluno2.Nascimento);
        Console.WriteLine("----------------------------------------");





        //Instanciar umobjeto do tipo produto
        Produto prod1 = new Produto();
        prod1.Codigo = 98765;
        prod1.Nome = "Coca-Cola 2 Litros";
        prod1.Preco = 12.99;
        prod1.Estoque = 76;

        //chamar o método quantidade estoque
        prod1.QuantidadeEstoque();
        prod1.Estoque = 76 - 6;
        prod1.QuantidadeEstoque();
        Console.WriteLine("---------------------------------------");

        //Instanciar um objeto de tipo Carro

        Carro carro1 = new Carro();

        carro1.Marca = "Ford";
        carro1.Modelo = "Mustang Dark Horse 2024";
        carro1.Velocidade = 80;

        carro1.Acelerar();
        Console.WriteLine("---------------------------------------");
        //---------------------------------------------------------------------------------


        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Reverse Luiz";
        pessoa1.Idade = 71;

        pessoa1.Envelhecer(5);
        Console.WriteLine("---------------------------------------");
        //-----------------------------------------------------------------------------

        Funcionario func1 = new Funcionario();
        func1.Nome = "Luis Santos";
        func1.Idade = 20;
        func1.Cargo = "Aprendiz";
        func1.Salario = 1400.00;
        func1.ApresentarSe();



        Console.WriteLine("---------------------------------------------------------");


        Gato gato = new Gato();

        gato.Nome = "Frajola";
        Console.WriteLine(gato.Nome + ", o gato, faz: ");
        gato.emitirSom();

        Porco porco = new Porco();
        porco.Nome = "Chovinista";
        Console.WriteLine(porco.Nome + ", O porco, faz: ");
        porco.emitirSom();

        Galinha galinha = new Galinha();
        galinha.Nome = "Galizé";
        Console.WriteLine(galinha.Nome + ", a galinha, faz:");
        galinha.emitirSom();
    }
}