using AreasInAspDotNetMvcApps.Areas.Blogs.Models;
using AreasInAspDotNetMvcApps.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AreasInAspDotNetMvcApps.Areas.Blogs.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blogs/Blog/Index
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Blog> blogs = db.Blogs.ToList();

            return View(blogs);
        }
        // GET: Blogs/Blog/Discuss
        public ActionResult Discuss()
        {
            return View();
        }
    }
}