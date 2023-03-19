using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class CategoryController : Controller
    {

        //Get Category Manager

        CategoryManager cm = new CategoryManager();   // Başka bir sınıfı çağırma bu şekilde olur.
                                                      // Bu class'da artık her yerde bu sınıfı cm diye çağırırsın.
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetAllBL(); //Category listemi döndermek için önce Business Layer'daki
                                                //CategoryManager'ı çağırmam gerekiyor.(Yukarda)
            return View(categoryvalues);   //view komutu göster demek. categoryvalues değişkeni içindeki değerleri dönder demektir.
        }

        //GetCategoryList methodundan dönen değerleri ekranda gösterebilmek için üzerine sağ tıklayıp-add view deyip bir view oluşturuyorsun.
        //Bu değerlerin ekranda görünmesi için aynı isimde oluşan view kodunda çalışmana devam etmelisin.
    }
}
