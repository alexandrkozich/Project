using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MensSummerShoesB1 : IAbstractMensShoesB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1 mujskaya letnyaya.";
        }

        public string AnotherUsefulFunctionB(IAbstractWomensA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }
}
