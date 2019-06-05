using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopDemo.Models
{
    public class FeedBack
    {
        public int FeedBackId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool ContactMe { get; set; }
    }
}
