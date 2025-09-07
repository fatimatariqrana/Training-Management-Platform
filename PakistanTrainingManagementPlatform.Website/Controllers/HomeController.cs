using PakistanTrainingManagementPlatform.Services;
using PakistanTrainingManagementPlatform.Website.ViewModels;
using System.Web.Mvc;

namespace PakistanTrainingManagementPlatform.Website.Controllers
{
    public class HomeController : Controller
    {
        CategoriesService categoryService = new CategoriesService();
        public ActionResult Index()
        {
            HomeViewModels model = new HomeViewModels();
            model.Categories=categoryService.GetCategories();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}