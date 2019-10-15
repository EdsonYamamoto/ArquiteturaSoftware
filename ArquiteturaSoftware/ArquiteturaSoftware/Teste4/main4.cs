using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste4
{
    class main4
    {
        public main4()
        {
            Cadeira _cadeira1 = Cadeira.Instance;
            _cadeira1.Quantidade = 1;


            // Colocando em prática
            Cadeira2 _cadeira = Singleton<Cadeira2>.Instance();
            _cadeira.Quantidade = 5;

            Mesa _mesa = Singleton<Mesa>.Instance();
            _mesa.Tamanho = "10metros";


        }
    }
}
