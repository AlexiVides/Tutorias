using AplicacionWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionWeb.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public ActionResult PersonaVista()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonaVista(Persona p)
        {
            _ = p;
            return View();
        }

    }
}