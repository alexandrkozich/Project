using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class SummerFactory1 : IAbstractFactory
    {
        public IAbstractWomensA CreateWomensShoesA()
        {
            return new WomensSummerShoesA1();
        }

        public IAbstractMensShoesB CreateMensShoesB()
        {
            return new MensSummerShoesB1();
        }
        public IAbstractProductC CreateChildrensShoesC()
        {
            return new ChildrensSummerShoesC1();
        }
    }
}
