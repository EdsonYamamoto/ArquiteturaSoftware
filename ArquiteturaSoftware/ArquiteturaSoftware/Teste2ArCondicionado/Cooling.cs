using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste2ArCondicionado
{
    public class Cooling : IArCondicionado
    {
        private readonly double _temperature;
        public Cooling(double temperature)
        {
            _temperature = temperature;
        }

        public object GetObject()
        {
            return this;
        }

        public void Operate()
        {
            Console.WriteLine($"Cooling the room to the required temperature of {_temperature} degrees");
        }
        public double GetTemperatura()
        {
            return _temperature;
        }
    }
}
