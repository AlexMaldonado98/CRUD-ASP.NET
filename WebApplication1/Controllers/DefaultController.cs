using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {

        Tickets.Class1 a = new Tickets.Class1();
        // GET: Default
        public ActionResult Index()
        {
            var tickets = a.Listar();
            return View(tickets);
        }
        public ActionResult Index2()
        {
            var tickets = a.Listar();
            return View(tickets);
        }

        public ActionResult Edit(int id)
        {
            return View(a.Buscar(id));
        }
        [HttpPost]

        public ActionResult Edit(Tickets.tickets item)
        {
            a.Modificar(item);
            return View("index",a.Listar());
        }

        public ActionResult Create()
        {
            return View(new Tickets.tickets());
        }
        [HttpPost]

        public ActionResult Create(Tickets.tickets item)
        {
            a.Agregar(item);
            return View("index", a.Listar());
        }

        public ActionResult Delete(int id)
        {
            return View(a.Buscar(id));
        }
        [HttpPost]
        public ActionResult Delete(Tickets.tickets item)
        {
            a.Delete(item);
            return View("index", a.Listar());
        }
    }
}