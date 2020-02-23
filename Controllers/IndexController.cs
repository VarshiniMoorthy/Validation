using System.Collections.Generic;
using System.Web.Mvc;
using ProductsDetails.respository;
using Product.Entity;
using System;
namespace OnlineShopping.Controllers
{
    public class IndexController : Controller
    {
        
        ProductsRespository productsRespository;
        public IndexController()
        {
            productsRespository = new ProductsRespository();

        }
        public ActionResult Index()
        {
            IEnumerable<ProductData> productData = productsRespository.GetProductDetails();
            
            return View(productData);
        }
        [HttpGet]
        [ActionName("AddProdcut")]
        public ActionResult AddProdcutGet()
        {
            return View();
        }
        [HttpPost]
        [ActionName("AddProdcut")]
        public ActionResult AddProdcutPost()
        {
            ProductData productData = new ProductData();
            TryUpdateModel(productData);
            if (ModelState.IsValid)
            {
                productsRespository.AddProductDetails(productData);
                TempData["Message"] = "product added succesfully";
                return RedirectToAction("Index");
            }
            return View();
            
        }
        public ActionResult Delete(int id)
        {
            productsRespository.DeleteProduct(id);
            TempData["Message"] = "product deleted succesfully";
            return RedirectToAction("Index");

        }
        [HttpGet]
        
        public ActionResult Edit(int id)
        {
            ProductData productData = productsRespository.GetProductId(id);
            return View(productData);

        }
        [HttpPost]
        public ActionResult Update(FormCollection formCollection)
        {
            ProductData productData = new ProductData();
            productData.ProductId = Convert.ToInt32(formCollection["ProductId"]);
            productData.ProductName = formCollection["ProductName"];
            productData.ProductPrice = Convert.ToDouble(formCollection["ProductPrice"]);
            productData.ProductQuantity = Convert.ToInt32(formCollection["ProductQuantity"]);
            if (ModelState.IsValid)
            {
                productsRespository.UpdateProduct(productData);
                TempData["Message"] = "Employee Details Updated Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
     
    }
}