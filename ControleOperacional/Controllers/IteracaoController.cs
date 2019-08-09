using Modelo.Tabelas;
using Servico.Tabelas;
using System;
using System.Web.Mvc;

namespace ControleOperacional.Controllers
{
    public class IteracaoController : Controller
    {
        private IteracaoServico iteracaoServico = new IteracaoServico();

        // GET: Iteracao
        public ActionResult ListarIteracoes(long? Id)
        {
            return View(iteracaoServico.ObterIteracoes(Id));
        }

        // GET: Servidor/Create
        public ActionResult GravarIteracao()
        {
            return View();
        }

        // POST: Gravar Iteracao
        [HttpPost]
        public ActionResult GravarIteracao(long? Id, Iteracao iteracao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    iteracao.OcorrenciaId = Id;
                    iteracao.DataHoraIteracao = DateTime.Now;

                    iteracaoServico.GravarIteracao(iteracao);
                    return RedirectToAction("Details", "Ocorrencia", new { Id = iteracao.OcorrenciaId });
                }
                return View(iteracao);
            }
            catch
            {
                return View(iteracao);
            }
        }
    }
}