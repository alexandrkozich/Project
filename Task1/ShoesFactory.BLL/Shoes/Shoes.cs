using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesFactory.BLL.Enums;
namespace ShoesFactory.BLL
{
    public class Shoes

    {
       
        
        public string Name { get; set; }
        public double Price { get; /*private*/ set; }
        public ShoesType ShoesType { get; set; }

        public static implicit operator Shoes(Shop v)
        {
            throw new NotImplementedException();
        }
    }
}
