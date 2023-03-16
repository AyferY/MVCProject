using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();  //İlk önce bir context nesnesi türettik.
        DbSet<Category> _object;  //DBSet türünden bir _object isimli bir nesne oluşturduk. Dbset türünün içerisine bir tablo adı yazmalısın.
        //Burada üzerinde çalıştığımız sınıfı yazmalıyız. Yani Category sınıfını.
        
        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)  // void değer döndermez.
        {
            _object.Add(p);   // _object'e p değerini ekle.
            c.SaveChanges();  // c'de yani context'de değişiklikleri kaydet demektir.
        }

        public List<Category> Listele()
        {
            return _object.ToList();   //_objectten (yani Category tablosundan gelen veriyi liste formatında dönderir.
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
