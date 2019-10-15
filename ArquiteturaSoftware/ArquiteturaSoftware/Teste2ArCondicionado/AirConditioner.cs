using ArquiteturaSoftware.Teste2ArCondicionado.factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste2ArCondicionado
{
    public class AirConditioner
    {
        private readonly Dictionary<enumerator.Actions, AirConditionerFactory> _factories;

        private AirConditioner()
        {
            _factories = new Dictionary<enumerator.Actions, AirConditionerFactory>();

            foreach (enumerator.Actions action in Enum.GetValues(typeof(enumerator.Actions)))
            {
                string teste = "";
                teste = "ArquiteturaSoftware.Teste2ArCondicionado.factory." + Enum.GetName(typeof(enumerator.Actions), action) + "Factory";
                
                var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType(teste));
                _factories.Add(action, factory);
            }
        }

        public static AirConditioner InitializeFactories() => new AirConditioner();

        public IArCondicionado ExecuteCreation(enumerator.Actions action, double temperature) => _factories[action].Create(temperature);
    }
}
