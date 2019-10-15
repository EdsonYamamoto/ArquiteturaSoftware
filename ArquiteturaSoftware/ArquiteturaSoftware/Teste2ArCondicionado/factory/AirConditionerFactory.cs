using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste2ArCondicionado.factory
{
    public abstract class AirConditionerFactory
    {
        public abstract IArCondicionado Create(double temperature);
    }
}
