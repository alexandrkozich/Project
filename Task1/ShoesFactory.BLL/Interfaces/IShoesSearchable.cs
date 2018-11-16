using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.BLL
{
   public interface IShoesSearchable
    {
        
            IEnumerable<Shoes> Search(SearchShoesModel model);
       
}
}
