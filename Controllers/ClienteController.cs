using AplicacoWebds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacoWebds.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()  
        {
            var cliente = new CLiente();
            return View(cliente);
        } 
        [HttpPost]
            public ActionResult Index(CLiente cliente)
            {
                if (ModelState.IsValid)
                {
                return View("Resultado", cliente);
                }
            return View(cliente);
            }
        public ActionResult Resultado(CLiente cliente)
        {
            return View(cliente);
        }
    }
}