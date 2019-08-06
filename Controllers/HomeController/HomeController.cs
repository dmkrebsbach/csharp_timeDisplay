using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay
{
    public class HomeController : Controller // Home is the name of the directory where all of these actions/views should reference
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}