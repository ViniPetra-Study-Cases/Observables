using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Observables
{
    class TelaExibeEstatística : IObervables
    {
        private List<double> temps = new List<double>();
        private List<double> humidades = new List<double>();
        private ISubject dados;

        public TelaExibeEstatística(ISubject dados)
        {
            this.dados = dados;
            this.dados.AddObervable(this);
        }

        public void Display(double temp, double humidade)
        {
            this.temps.Add(temp);
            this.humidades.Add(humidade);

            double maxTemp = temps.Max<double>();
            double maxHumidade = humidades.Max<double>();
            double minTemp = temps.Min<double>();
            double minHumidade = humidades.Min<double>();

            Console.WriteLine($"A temperatura maxima foi de {maxTemp} e a mínima foi de {minTemp}");
            Console.WriteLine($"A humidade maxima foi de {maxHumidade} e a mínima foi de {minHumidade}");
        }
        
    }
}
