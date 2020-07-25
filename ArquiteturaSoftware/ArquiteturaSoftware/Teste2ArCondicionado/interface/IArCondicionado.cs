using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste2ArCondicionado
{
    public interface IArCondicionado
    {
        void Operate();
        Object GetObject();

        double GetTemperatura();
    }
}
