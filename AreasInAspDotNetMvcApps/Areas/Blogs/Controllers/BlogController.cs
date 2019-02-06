using System.Web.Mvc;

namespace AreasInAspDotNetMvcApps.Areas.Blogs.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blogs/Blog/Index
        public ActionResult Index()
        {
            return View();
        }
        // GET: Blogs/Blog/Discuss
        public ActionResult Discuss()
        {
            return View();
        }
    }
}