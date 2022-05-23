using Microsoft.AspNetCore.Mvc;
using SampleEFApp.Models;
using SampleEFApp.Sevices;

namespace SampleEFApp.Controllers
{
    public class ProductController : Controller
    {
        ProductRepo _repo = new ProductRepo();
        public IActionResult Index()
        {
            var products = _repo.GetAll();
            if(products == null)
                return NotFound();
            return View(products);
        }
        public IActionResult Details(int id)
        {
            var product = _repo.Get(id);
            if (product == null)
                return NotFound();
            return View(product);
        }
        [HttpGet]
        public IActionResult Create(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create( Product product)
        {
            var prod = _repo.Add(product);
            if (prod == null)
                return View();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product = _repo.Get(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(int id,Product product)
        {
            var prod = _repo.Update(product);
            if (prod == null)
                return View();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product product = _repo.Get(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(int id,Product product)
        {
            var prod = _repo.Delete(id);
            if (prod == null)
                return View();
            return RedirectToAction("Index");
        }
    }
}
