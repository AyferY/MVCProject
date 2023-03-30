using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService  //Oluşturduğum interface'i çektim.
    {
        ICategoryDal _categorydal; //Category'leri döndermek için ICategoryDal'ı kullanmam gerekiyor. _categorydal'ı türettim.

        //GenericRepository'de constructor method oluşturup içine veri eklemesi yapmıştık.
        //Burada da aynı mantıkla ilerliycez. _categorydal'ı doldurmamız lazım.

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categorydal= categoryDal;  //Burada sadece categoryDal içindeki methodları aktarmış oldun.
        }

        //Burada set işlemini yaptık artık listeleme, return kısmına geçebiliriz.
        public List<Category> GetList()
        {
            return _categorydal.List();
        }

    }
}
