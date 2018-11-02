using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Client
    {
        public void Main()
        {
            
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new SummerFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new WinterFactory2());
            Console.WriteLine();
            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new SpringAutumnFactory3());
            Console.ReadKey();
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateWomensShoesA();
            var productB = factory.CreateMensShoesB();
            var productC = factory.CreateChildrensShoesC();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
