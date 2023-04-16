using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Gstore.Controllers

{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View ();
        }

        public string Welcome()
        {
            return "exemplo2";
        }







    }













}

