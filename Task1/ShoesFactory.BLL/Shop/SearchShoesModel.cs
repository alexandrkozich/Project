using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesFactory;
using ShoesFactory.BLL;

namespace ShoesFactory.BLL
{
   public class SearchShoesModel
    {
       
            public string Name { get; set; }
            public int FromSpeed { get; set; }
            public int ToSpeed { get; set; }
       
    }
}
