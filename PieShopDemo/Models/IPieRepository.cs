using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopDemo.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieByID(int pieId);
    }
}
