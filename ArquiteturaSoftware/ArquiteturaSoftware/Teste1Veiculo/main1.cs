using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste1Veiculo
{
    public class main1
    {
        public main1()
        {

            string teste = Console.ReadLine();
            var veic = Teste1Veiculo.VeiculoFactory.Build(Convert.ToInt32(teste));
            if (veic != null)
            {
                Console.WriteLine(" You built a {veic.GetType().Name}");
                Console.WriteLine(veic.Correr());
                switch (veic.GetType().Name)
                {
                    case "Carro":
                        ((Teste1Veiculo.Carro)veic).Teste();
                        break;
                }
            }
        }
    }
}
