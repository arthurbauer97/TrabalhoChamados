using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrabalhoChamados.Models;

namespace TrabalhoChamados.Controllers
{
    public class ChamadosController : Controller
    {
        private readonly IChamadosRepository _repository;

        public ChamadosController(IChamadosRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var chamados = _repository.GetAll().OrderByDescending(x => x.data);          

            return View(chamados);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Chamados chamados)
        {
            _repository.Create(chamados);

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
        public IActionResult Edit(Chamados chamados)
        {
            _repository.Update(chamados);
            return RedirectToAction("Index");
        }
    
    }
}