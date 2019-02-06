using System.Web.Mvc;

namespace AreasInAspDotNetMvcApps.Areas.Transection
{
    public class TransectionAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Transection";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Transection_default",
                "Transection/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}