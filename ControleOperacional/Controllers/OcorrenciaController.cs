using System;
using System.Net;
using System.Web.Mvc;
using Modelo.Entidades;
using Servico.Entidades;

namespace ControleOperacional.Controllers
{

    public class OcorrenciaController : Controller
    {
        private OcorrenciaServico ocorrenciaServico = new OcorrenciaServico();

        // Métodos do Controlador Ocorrencia
        private ActionResult GravarOcorrencia(Ocorrencia ocorrencia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Geração do número aleatório da Ocorrência
                    Random randNum = new Random();
                    ocorrencia.Numero_Ocorrencia = randNum.Next(100000, 999999);

                    ocorrencia.Status = 0;

                    ocorrencia.DataHora = DateTime.Now;
                    ocorrenciaServico.GravarServidor(ocorrencia);
                    return RedirectToAction("Index");
                }
                return View(ocorrencia);
            }
            catch
            {
                return View(ocorrencia);
            }
        }

        private ActionResult ObterVisaoOcorrenciaPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ocorrencia produto = ocorrenciaServico.ObterOcorrenciaPorId((long)id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }


        // GET: Ocorrencia
        public ActionResult Index()
        {
            return View(ocorrenciaServico.ObterOcorrenciasClassificadasPorDataHora());
        }

        // GET: Ocorrencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ocorrencia/Create
        [HttpPost]
        public ActionResult Create(Ocorrencia ocorrencia)
        {
            return GravarOcorrencia(ocorrencia);
        }

        //	GET:	Servidor/Details
        public ActionResult Details(long? id)
        {

            return ObterVisaoOcorrenciaPorId(id);

        }
    }
}