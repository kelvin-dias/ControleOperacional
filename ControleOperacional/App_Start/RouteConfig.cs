using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControleOperacional
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Rotas HomeController
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "HomeIndex",
                url: "Home/Index",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //Rotas Servidores
            routes.MapRoute(
                name: "ServidorIndex",
                url: "Servidor/Index",
                defaults: new { controller = "Servidor", action = "Index" }
            );
            routes.MapRoute(
                name: "ServidorCreate",
                url: "Servidor/Create",
                defaults: new { controller = "Servidor", action = "Create" }
            );

            //Rotas Ocorrencia
            routes.MapRoute(
                name: "OcorrenciaIndex",
                url: "Ocorrencia/Index",
                defaults: new { controller = "Ocorrencia", action = "Index" }
            );
            routes.MapRoute(
                name: "OcorrenciaCreate",
                url: "Ocorrencia/Create",
                defaults: new { controller = "Ocorrencia", action = "Create" }
            );

            //Rotas Iteracao
            routes.MapRoute(
                name: "GravarIteracao",
                url: "Iteracao/GravarIteracao",
                defaults: new { controller = "Iteracao", action = "GravarIteracao", id = UrlParameter.Optional }
            );
        }
    }
}
