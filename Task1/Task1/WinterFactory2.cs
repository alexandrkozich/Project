using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class WinterFactory2 : IAbstractFactory
    {
        public IAbstractWomensA CreateWomensShoesA()
        {
            return new WomensWinterShoesA2();
        }

        public IAbstractMensShoesB CreateMensShoesB()
        {
            return new MensWinterShoesB2();
        }
        public IAbstractProductC CreateChildrensShoesC()
        {
            return new ChildrensWinterShoesC2();
        }
    }
}
