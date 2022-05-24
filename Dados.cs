using System;
using System.Collections.Generic;
using System.Text;

namespace Observables
{
    class Dados : ISubject
    {
        public double temperatura { get; private set; }
        public double humidade { get; private set; }

        private List<IObervables> Observables = new List<IObervables>();

        private Random rand = new Random();

        public bool getTemperatura()
        {
            double novaTemp = rand.Next(0, 100);

            if (novaTemp != this.temperatura)
            {
                this.temperatura = novaTemp;
                return true;
            }
            return false;
        }

        public bool getHumidade()
        {
            double novaHumidade = rand.Next(0, 100);

            if(novaHumidade != this.humidade)
            {
                this.humidade = novaHumidade;
                return true;
            }
            return false;
        }

        public void PushObservables()
        {
            foreach(IObervables obervables in Observables)
            {
                obervables.Display(this.temperatura, this.humidade);
            }
        }

        public void Update()
        {
            if (this.getTemperatura() || this.getHumidade())
            {
                this.PushObservables();
            }
        }

        public void AddObervable(IObervables obervable)
        {
            this.Observables.Add(obervable);
        }
        public void RemoveObervable(IObervables obervable)
        {
            this.Observables.Remove(obervable);
        }
    }
}
