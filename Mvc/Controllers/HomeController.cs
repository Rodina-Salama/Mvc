using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            //ContentResult contentResult = new ContentResult();
            //contentResult.Content = "Hello from  Content Index Action";

            //return  contentResult;
            return View();

        }
        public IActionResult AboutUs()
        {
            //return Content("Hello from AboutUs Action");
            return View();

        }
        public IActionResult ContactUs()
        {
            return View();

        }
        public IActionResult Privacy()
        {
            return View();

        }
    }
}
