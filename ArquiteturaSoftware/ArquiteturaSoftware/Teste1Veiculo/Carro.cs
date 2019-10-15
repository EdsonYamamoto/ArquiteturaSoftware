using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste1Veiculo
{
    class Carro : IVeiculo
    {
        public string Correr()
        {
            return "andando carro";
        }

        public void Teste()
        {
            Console.WriteLine("Teste");
        }
    }
}
