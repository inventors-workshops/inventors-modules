using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace IdentityTest
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            // Routes
            routes.MapPageRoute("moduleHome", "Modules/{id}", "~/Modules/ModuleHome.aspx");
            routes.MapPageRoute("addResource", "Modules/{id}/ResourceAdd", "~/Modules/ResourceAdd.aspx");
        }
    }
}
