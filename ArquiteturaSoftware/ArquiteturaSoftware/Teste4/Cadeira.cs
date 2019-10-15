using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste4
{
    public sealed class Cadeira
    {
        private static readonly Cadeira instance = new Cadeira();
        public int Quantidade { get; set; }

        private Cadeira() { }

        public static Cadeira Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
