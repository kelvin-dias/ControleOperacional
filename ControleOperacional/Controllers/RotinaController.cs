using Modelo.Entidades;
using Persistencia.Context;
using System.Linq;
using System.Web.Mvc;

namespace ControleOperacional.Controllers
{
    public class RotinaController : Controller
    {
        private EFContext context = new EFContext();

        //	GET: Rotinas
        public ActionResult Index()
        {
            return View(context.Rotinas.OrderBy(c => c.Nome));
        }

        // GET: Rotinas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rotinas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rotina rotina)
        {
            context.Rotinas.Add(rotina);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}