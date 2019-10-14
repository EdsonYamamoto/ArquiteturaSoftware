using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoCSharp.ArCondicionado
{
    class Cooling : IArCondicionado
    {
        private readonly double _temperature; public Cooling(double temperature)
        {
            _temperature = temperature;
        }

        public void Operate()
        {
            Console.WriteLine($"Cooling the room to the required temperature of {_temperature} degrees");
        }
    }
}
