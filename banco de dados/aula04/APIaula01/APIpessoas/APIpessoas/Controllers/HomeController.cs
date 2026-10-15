using Microsoft.AspNetCore.Mvc;

namespace APIpessoas.Controllers
{
        [ApiController]
    [Route("[Controller")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string texto = "API funcionou";
            return OK(texto);

        }
    }
}
