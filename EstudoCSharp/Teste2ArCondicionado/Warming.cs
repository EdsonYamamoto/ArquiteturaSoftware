﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoCSharp.ArCondicionado
{
    public class Warming : IArCondicionado
    {
        private readonly double _temperature;

        public Warming(double temperature)
        {
            _temperature = temperature;
        }

        public void Operate()
        {
            Console.WriteLine($"Warming the room to the required temperature of {_temperature} degrees.");
        }
    }
}
