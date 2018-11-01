using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class SpringAutumnFactory3 : IAbstractFactory
    {
        public IAbstractWomensA CreateWomensShoesA()
        {
            return new WomensSpringAutumnShoesA3();
        }

        public IAbstractMensShoesB CreateMensShoesB()
        {
            return new MensSpringAutumnShoesB3();
        }
        public IAbstractProductC CreateChildrensShoesC()
        {
            return new ChildrensSpringAutumnShoesC3();
        }
    }
}
