using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Product.Models;
using MVC_Product.Services;

namespace MVC_Product.Controllers
{
    public class ProductController : Controller
    {
        private ProductService _productService;

        public ProductController()
        {
            _productService = new InMemoryProductService();
        }
        // GET: Product
        public ActionResult Index()
        {
            var listProduct = _productService.GetListProduct(1, 10);
            return View(listProduct);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            _productService.CreateProduct(product);
            return Redirect("/Product");
        }

        public ActionResult Detail(int id)
        {
            var product = _productService.GetProductDetail(id);
            if (product == null)
            {
                return View("Error");
            }

            return View(product);
        }
        public ActionResult Edit(int id)
        {
            var product = _productService.GetProductDetail(id);
            if (product == null)
            {
                return View("Error");
            }

            return View(product);
        }
        [HttpPost]
        public ActionResult Update(Product product)
        {
            var updateProduct = _productService.UpdateProduct(product.Id, product);
            if (updateProduct == null)
            {
                return View("Error");
            }

            return Redirect("/Product");
        }

        public ActionResult Delete(int id)
        {
            var deleteProduct = _productService.DeleteProduct(id);
            if (deleteProduct == false)
            {
                return View("Error");
            }

            return Redirect("/Product");
        }
    }
}