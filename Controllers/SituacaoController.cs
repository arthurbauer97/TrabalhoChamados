using Microsoft.AspNetCore.Mvc;
using TrabalhoChamados.Models;

namespace TrabalhoChamados.Controllers
{
    public class SituacaoController : Controller
    {
     private readonly ISituacaoRepository _repository;

    public SituacaoController(ISituacaoRepository repository)
    {
        _repository = repository;
    }

    public IActionResult Index()
    {
        var situacao = _repository.GetAll();
        return View(situacao);
    }

      [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Situacao situacao)
        {
            _repository.Create(situacao);

            return RedirectToAction("index");
        }
        
         public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Situacao situacao)
        {
            _repository.Update(situacao);
            return RedirectToAction("Index");
        }
    }
}