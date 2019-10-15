using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste2ArCondicionado.factory
{
    public class WarmingFactory : AirConditionerFactory
    {
        public override IArCondicionado Create(double temperature) => new Warming(temperature);
    }
}
