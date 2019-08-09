using ControleOperacional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleOperacional.Controllers
{
    public class AmbienteServidorController : Controller
    {
        private static IList<AmbienteServidor> Ambientes = new List<AmbienteServidor>()
            {
                new AmbienteServidor()
                {
                    AmbienteId = 1,
                    Nome = "RJ1"
                },
                new AmbienteServidor()
                {
                    AmbienteId = 2,
                    Nome = "RJ2"
                },
                new AmbienteServidor()
                {
                    AmbienteId = 3,
                    Nome = "MRJ"
                },
                new AmbienteServidor()
                {
                    AmbienteId = 4,
                    Nome = "MSP"
                }
            };

        // GET: AmbienteServidor
        public ActionResult Index()
        {
            return View(Ambientes);
        }
    }
}