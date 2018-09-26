using Microsoft.AspNetCore.Mvc;
using TrabalhoChamados.Models;

namespace TrabalhoChamados.Controllers
{
    public class ClienteController : Controller
    {
     private readonly IClienteRepository _repository;

    public ClienteController(IClienteRepository repository)
    {
        _repository = repository;
    }

    public IActionResult Index()
    {
        var cliente = _repository.GetAll();
        return View(cliente);
    }

      [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            _repository.Create(cliente);

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
        public IActionResult Edit(Cliente cliente)
        {
            _repository.Update(cliente);
            return RedirectToAction("Index");
        }
    }
}