using System;
using System.Collections.Generic;
using System.Text;

namespace Observables
{
    class TelaExibeAtual : IObervables
    {
        private ISubject dados;
        public TelaExibeAtual(ISubject dados)
        {
            this.dados = dados;
            this.dados.AddObervable(this);
        }

        public void Display(double temp, double humidade)
        {
            Console.WriteLine($"A temperatura atual é de: {temp} e a humidade é de {humidade}");
        }
    }
}
