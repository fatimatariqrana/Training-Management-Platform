using PakistanTrainingManagementPlatform.Entities;
using PakistanTrainingManagementPlatform.Services;
using System.Linq;
using System.Web.Mvc;

namespace PakistanTrainingManagementPlatform.Website.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ProductTable(string search)
        {
            var products = productsService.GetProducts();
            if(string.IsNullOrEmpty(search)==false)
            {
                products = products.Where(p => p.Name != null && p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            return PartialView(products);
        }


        // GET: Category
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
             productsService.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }



        // GET: Category
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var product = productsService.GetProduct(ID);
            return PartialView(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productsService.UpdateProduct(product);
            return RedirectToAction("ProductTable");
        }



        [HttpPost]
        public ActionResult Delete(int ID)
        {
            productsService.DeleteProduct(ID);
            return RedirectToAction("ProductTable");
        }



    }
}