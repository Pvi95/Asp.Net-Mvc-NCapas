using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ent = Entidades;
using dom = Dominio;

namespace ASP.NET_MVC_NCapas.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            var _clientes = new dom.ClientesD().ClientesList();
            return View(_clientes);
        }

        //Controlador para CREAR clientes
        [HttpGet]
        public ActionResult Crear()
        {
            var _cliente = new ent.ClientesE();
            return PartialView("Crear", _cliente);
        }

        [HttpPost]
        public ActionResult Crear(ent.ClientesE cliente)
        {
            new dom.ClientesD().CrearCliente(cliente);
            return RedirectToAction("Index");
        }

        //Controlador para EDITAR las clientes

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var _cliente = new dom.ClientesD().ClientesPorID(id);
            return PartialView("Editar", _cliente);
        }
        [HttpPost]
        public ActionResult Editar(ent.ClientesE clienteEditado)
        {
            new dom.ClientesD().ModificarCliente(clienteEditado);
            return RedirectToAction("Index");
        }

        //Controlador para VER DETALLES de las clientes
        [HttpGet]
        public ActionResult VerDetallesCliente(int id)
        {
            var _categoria = new dom.ClientesD().ClientesPorID(id);
            return PartialView(_categoria);
        }
    }
}