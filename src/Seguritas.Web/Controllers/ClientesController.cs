using System.Web.Mvc;

namespace Seguritas.Web.Controllers
{
    public class ClientesController : Controller
    {

        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}