using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers{
    public class ProductsController : Controller{
        public IActionResult index(){
            return View();
        }
        public IActionResult Creacion(){
            return View();
        }

        public IActionResult Vista(){
            return View();
        }
        
        public IActionResult Delete(){
            return View();
        }

        public IActionResult Update(){
            return View();
        }

        public IActionResult Editar(){
            return View();
        }

        public IActionResult Show(){
            return View();
        }
    
    }
}