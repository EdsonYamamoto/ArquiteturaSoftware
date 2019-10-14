using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoCSharp.veiculo
{
    public static class VeiculoFactory{
        public static IVeiculo Build(int numberOfWheels)
        {
            switch (numberOfWheels)
            {
                case 1:
                    //return new UniCycle();
                    break;
                case 2:
                    return new Bicicleta();
                case 3:
                    break;
                case 4:
                    return new Carro();
                default:
                    return new Truck();

            }
            return null;
        }
    }
}
