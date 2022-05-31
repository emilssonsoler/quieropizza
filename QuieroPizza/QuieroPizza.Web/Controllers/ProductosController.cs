using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.id = 1;
            producto1.Descripcion = "Pizza 6 queso";

            var producto2 = new ProductoModel();
            producto2.id = 2;
            producto2.Descripcion = "Pizza Cuadrada";

            var producto3 = new ProductoModel();
            producto3.id = 3;
            producto3.Descripcion = "Pizza Orilla de Queso";

            var listaDeProducto = new List<ProductoModel>();
            listaDeProducto.Add(producto1);
            listaDeProducto.Add(producto2);
            listaDeProducto.Add(producto3);
            return View(listaDeProducto);
        }
    }
}