using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;
        public List<Category> GetList()
        {
            return 
        }

        //GenericRepository<Category> repo = new GenericRepository<Category>();



        //public List<Category> GetAllBL()   //GetAllBL liste tipinde ve Category türünde bit method.
        //{
        //    return repo.List();  // GenericRepository'den gelen List methodunu içinde çalıştırıyoruz ve bu sayede GetAllBL
        //                         // dönderdiğimizde geliyor.

        //}

        //public void CategoryAddBL(Category p)  //Category tipindeki p değeri ile çalışacak bu method ve değer dönmeyecek(void).
        //{



        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 ||
        //        p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}

    }
}
