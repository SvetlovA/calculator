using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var indexHtml = System.IO.File.ReadAllText(Path.Combine(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "index.html")));
            return Content(indexHtml, "text/html");
        }
    }
}
