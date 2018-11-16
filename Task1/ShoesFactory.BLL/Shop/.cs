using System;
using System.Collections.Generic;
using System.Text;

namespace ShoesFactory.BLL
{
   public class ShoesComparer : EqualityComparer<Shoes>
    {
       

            public override bool Equals(Shoes b1, Shoes b2)
            {
                return b1.Name == b2.Name;
            }


            public override int GetHashCode(Shoes shoes)
            {
                return shoes.Name.GetHashCode();
            }
        }
    }


