using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoCSharp.ArCondicionado.factory
{
    public class CoolingFactory : AirConditionerFactory
    {
        public override IArCondicionado Create(double temperature) => new Cooling(temperature);
    }

}
