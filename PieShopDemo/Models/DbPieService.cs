using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopDemo.Models
{
    public class DbPieService : IPieRepository
    {
        private readonly AppDbContext _appDbContext;
        //Constructor injection here
        public DbPieService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPieByID(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
