using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class CategoryController : Controller
    {

       

        CategoryManager cm = new CategoryManager();
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            //var categoryvalues = cm.GetAllBL(); //Category listemi döndermek için önce Business Layer'daki
                                                //CategoryManager'ı çağırmam gerekiyor.(Yukarda)
            return View();   //view komutu göster demek. categoryvalues değişkeni içindeki değerleri dönder demektir.
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();  //Burada sadece ekranın yüklenmesini beklediğimiz için return view dedik.

        }

       
        [HttpPost]           
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p); 
            return RedirectToAction("GetCategoryList");  
        }
    }
}
