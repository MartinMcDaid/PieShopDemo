using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShopDemo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PieShopDemo.Controllers
{
    public class FeedBackController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedBackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
