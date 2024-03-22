using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers{
    public class PrincipalController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}