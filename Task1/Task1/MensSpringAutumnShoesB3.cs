using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MensSpringAutumnShoesB3 : IAbstractMensShoesB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B3.";
        }

        public string AnotherUsefulFunctionB(IAbstractWomensA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}
