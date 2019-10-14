using System;

namespace EstudoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string teste = Console.ReadLine();
            var veic = veiculo.VeiculoFactory.Build(Convert.ToInt32(teste));
            if (veic != null)
            {
                Console.WriteLine($" You built a {veic.GetType().Name}");
                Console.WriteLine(veic.Correr());
                switch (veic.GetType().Name){
                    case "Carro":
                        ((veiculo.Carro)veic).Teste();
                        break;
                }
            }

            ArCondicionado.AirConditioner
                .InitializeFactories()
                .ExecuteCreation(ArCondicionado.enumerator.Actions.Cooling, 22.5)
                .Operate();

            ArCondicionado.AirConditioner
                .InitializeFactories()
                .ExecuteCreation(ArCondicionado.enumerator.Actions.Warming,25)
                .Operate();
        }
    }
}
