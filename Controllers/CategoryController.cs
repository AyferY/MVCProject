using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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
            //var categoryvalues = cm.GetAllBL(); //Category listemi döndermek için önce Business Layer'daki
                                                //CategoryManager'ı çağırmam gerekiyor.(Yukarda)
            return View();   //view komutu göster demek. categoryvalues değişkeni içindeki değerleri dönder demektir.
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();  //Burada sadece ekranın yüklenmesini beklediğimiz için return view dedik.

        }

        //Burada diyorsun ki; AddCategory, HttpPost işlemi oluştuğu zaman devreye girsin diyorsun.
        //post ne demek bu projede sayfada bir şeye tıkladığın zaman post methodu devreye girer o da buraya gelir,
        //çünkü o tıklanan yerde bunu adreslemiştin. Bu sayede butona her basıldığında ekleme işlemi yapılmamış olur.
        [HttpPost]           
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p); 
            return RedirectToAction("GetCategoryList");  
        }
    }
}
