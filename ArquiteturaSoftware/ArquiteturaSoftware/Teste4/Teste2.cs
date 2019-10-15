using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaSoftware.Teste4
{
    public sealed class Singleton<T> where T : class, new()
    {
        private static T instance;

        public static T Instance()
        {
            lock (typeof(T))
                if (instance == null) instance = new T();

            return instance;
        }
    }

    public class Cadeira2
    {
        public int Quantidade { get; set; }
    }

    public class Mesa
    {
        public string Tamanho { get; set; }
    }
}
