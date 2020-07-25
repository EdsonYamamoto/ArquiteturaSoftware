using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste2ArCondicionado
{
    public class main2
    {
        public main2()
        {

            AirConditioner
                .InitializeFactories()
                .ExecuteCreation(Teste2ArCondicionado.enumerator.Actions.Cooling, 22.5)
                .Operate();
               ;



        }
    }
}
