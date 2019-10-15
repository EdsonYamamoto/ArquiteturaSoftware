using System;
using System.Collections.Generic;
using System.Text;
using ArquiteturaSoftware.Teste3Server.Controller;

namespace ArquiteturaSoftware.Teste3Server
{
    class Server
    {
        public static void EndPoint1(object Teste)
        {            
            Console.WriteLine(Teste);
            Console.WriteLine(Teste.GetType().Name);

            switch (Teste.GetType().Name)
            {
                case "String":
                    Console.WriteLine("string");
                    break;

                case "Int32":
                    Console.WriteLine("numero");
                    break;
            }

            VendedorController c = new VendedorController();
            Console.WriteLine(c.Index());
        }

    }
}
