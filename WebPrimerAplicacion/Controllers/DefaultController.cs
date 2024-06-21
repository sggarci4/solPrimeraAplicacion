using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPrimerAplicacion.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Inicio()
        {
            return View("Inicio");
        }

        public ActionResult IrVista2()
        {
            return View("SegundaVista");
        }
    }
}