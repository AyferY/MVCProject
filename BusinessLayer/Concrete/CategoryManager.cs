using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        // üzerinde çalışacağımız clası çağırıyoruz ve dolayısıyla da çalışacağımız entity'i çağırıyoruz.
        // Bundan da repo isimli bir nesne türetiyoruz.


        //Create, update, remove ve delete işlemleri için methodlar tanımlamamız gerekiyor.


        public List<Category> GetAllBL()   //GetAllBL liste tipinde ve Category türünde bit method.
        {
            return repo.List();  // GenericRepository'den gelen List methodunu içinde çalıştırıyoruz ve bu sayede GetAllBL
                                 // dönderdiğimizde geliyor.

        }

        public void CategoryAddBL(Category p)  //Category tipindeki p değeri ile çalışacak bu method ve değer dönmeyecek(void).
        {
            if(p.CategoryName == "" || p.CategoryName.Length <= 3 ||   
                p.CategoryDescription == "" || p.CategoryName.Length >= 51)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);   //p değeri bu kurallardan birine takılmazsa repo içinde bulunan insert komutu çalışacak
                                  //ve p değerini içine ekleyecek.
            }
        }
    }
}
