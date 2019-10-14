using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoCSharp.ArCondicionado
{
    public abstract class AirConditionerFactory
    {
        public abstract IArCondicionado Create(double temperature);
    }
}
