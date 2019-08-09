using System.Web.Mvc;
using System.Net;
using Modelo.Entidades;
using Servico.Entidades;

namespace ControleOperacional.Controllers
{
    public class ServidorController : Controller
    {
        private ServidorServico servidorServico = new ServidorServico();

        //Métodos do Controlador Servidor
        private ActionResult ObterVisaoServidorPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Servidor produto = servidorServico.ObterServidorPorId((long)id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        private ActionResult GravarServidor(Servidor servidor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    servidorServico.GravarServidor(servidor);
                    return RedirectToAction("Index");
                }
                return View(servidor);
            }
            catch
            {
                return View(servidor);
            }
        }

        // GET: Servidor/Index
        public ActionResult Index()
        {
            return View(servidorServico.ObterCategoriasClassificadasPorNome());
        }
        
        // GET: Servidor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servidor/Create
        [HttpPost]
        public ActionResult Create(Servidor servidor)
        {
            return GravarServidor(servidor);
        }

        //	GET: Servidor/Edit
        public ActionResult Edit(long? id)
        {
            return ObterVisaoServidorPorId(id);
        }

        // POST: Servidor/Edit
        [HttpPost]
        public ActionResult Edit(Servidor servidor)
        {
            return GravarServidor(servidor);
        }

        //	GET:	Servidor/Details
        public ActionResult Details(long? id)
        {
            return ObterVisaoServidorPorId(id);
        }

        //	GET:	Servidor/Delete
        public ActionResult Delete(long? id)
        {
            return ObterVisaoServidorPorId(id);
        }

        //	POST:	Servidor/Delete
        [HttpPost]
        public ActionResult Delete(long id)
        {
            try
            {
                Servidor servidor = servidorServico.EliminarServidorPorId(id);
                TempData["Message"] = "Produto " + servidor.Nome.ToUpper()
                + " foi removido";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }




    }
}