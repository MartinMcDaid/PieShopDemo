using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopDemo.Models
{
    public interface IFeedbackRepository
    {
        void AddFeedBack(FeedBack feedBack);
    }
}
