using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrabalhoChamados.Models;

namespace TrabalhoChamados.Controllers
{
    public class ChamadoController : Controller
    {
        private readonly IChamadoRepository _repositoryChamado;
        private readonly IClienteRepository _repositoryCliente;
        private readonly ISituacaoRepository _repositorySituacao;

        public ChamadoController(IChamadoRepository chamadoRepository,
                                 IClienteRepository clienteRepository,
                                 ISituacaoRepository situacaoRepository)
        {
            _repositoryChamado = chamadoRepository;
            _repositoryCliente = clienteRepository;
            _repositorySituacao = situacaoRepository;
        }

        public IActionResult Index()
        {
            var chamados = _repositoryChamado.GetAll().OrderByDescending(x => x.data);          

            return View(chamados);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.clientes = _repositoryCliente.GetAll();
            ViewBag.situacoes = _repositorySituacao.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Chamado chamado)
        {
        
            _repositoryChamado.Create(chamado);

            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            _repositoryChamado.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
           var chamado = _repositoryChamado.GetById(id);
           ViewBag.situacoes = _repositorySituacao.GetAll();
            return View(chamado);
        }

        [HttpPost]
        public IActionResult Edit(Chamado chamado)
        {
            _repositoryChamado.Update(chamado);
            return RedirectToAction("Index");
        }    
    
    }
}