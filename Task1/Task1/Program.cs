using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesFactory.BLL;
using ShoesFactory.BLL.Enums;

namespace Task1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Shop park = new Shop {
                new ChildrenShoes {
                    Name = "name1",
                    Price = 12,
                   ShoesType = ShoesType.Winter
                },
                new MensShoes {
                    Name = "name2",
                    Price = 13,
                    ShoesType = ShoesType.Summer
                },
                
                new WomensShoes {
                    Name = "name5",
                    Price = 10,
                    ShoesType =  ShoesType.SpringAutumn
                },
            };

            


        }
    }
}
