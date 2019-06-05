using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopDemo.Models
{
    public class FeedBackService : IFeedbackRepository
    {
        private readonly AppDbContext _appDbContext;

        public FeedBackService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddFeedBack(FeedBack feedBack)
        {
            _appDbContext.FeedBacks.Add(feedBack);
            _appDbContext.SaveChanges();
        }
    }
}
