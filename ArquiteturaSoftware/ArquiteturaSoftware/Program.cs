using System;

namespace ArquiteturaSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            string teste = Console.ReadLine();
            var veic = Teste1Veiculo.VeiculoFactory.Build(Convert.ToInt32(teste));
            if (veic != null)
            {
                Console.WriteLine($" You built a {veic.GetType().Name}");
                Console.WriteLine(veic.Correr());
                switch (veic.GetType().Name)
                {
                    case "Carro":
                        ((Teste1Veiculo.Carro)veic).Teste();
                        break;
                }
            }

            Teste2ArCondicionado.AirConditioner
                .InitializeFactories()
                .ExecuteCreation(Teste2ArCondicionado.enumerator.Actions.Cooling, 22.5)
                .Operate();

            Teste2ArCondicionado.AirConditioner
                .InitializeFactories()
                .ExecuteCreation(Teste2ArCondicionado.enumerator.Actions.Warming, 25)
                .Operate();
        }
    }
}
