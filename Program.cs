using System;

namespace Observables
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados();

            TelaExibeAtual atual = new TelaExibeAtual(dados);
            TelaExibeEstatística estatística = new TelaExibeEstatística(dados);

            dados.Update();
            Console.WriteLine("--------------------------------------------------");

            dados.Update();
            Console.WriteLine("--------------------------------------------------");

            dados.Update();
            Console.WriteLine("--------------------------------------------------");

            dados.Update();
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
