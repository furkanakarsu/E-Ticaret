using CORE.CoreEntity;
using CORE.CoreService;
using DataAccess.Context;
using DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Concrete
{
    public class BaseService<T> : ICoreService<T> where T : EntityRepository
    {
        //ProjectDbContext db = new ProjectDbContext();
        ProjectDbContext db = Singleton.Context;

        //Singleton.Context yazildiginda Singleton class'inin icerisindeki Context propertysini cagirmis oluyoruz.Bu property kullanilacak eger daha once herhangi bir instance alinmadi ise yani _context olan property'nin ici bos ise, ProjectDbContext'en yani Singleton ile bir instance alinmadiysa, ilk instance i yolluyor eger baska bir yerde alindiysa bu property (Singleton.Context) ve dolayisiyla (Singleton._context) static olarak kalacagi icin if dongusune girmeyip _context i yollayacak ki bu da onceden ici doldurulmus new ProjectDbContext olacak. Yani ProjectDbContext in instance ini almamiza yarayan diger parca.
        public string Add(T model)
        {
            try
            {
                db.Set<T>().Add(model);
                db.SaveChanges();
                return "Veri Eklendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public string Add(List<T> models)
        {
            try
            {
                db.Set<T>().AddRange(models);
                db.SaveChanges();
                return "Veriler Eklendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }

        public List<T> GetList()
        {
            return db.Set<T>().ToList();
        }

        public string Remove(int id)
        {
            try
            {
                T item = GetById(id);
                item.Status = CORE.CoreEntity.Enums.Status.Deleted;
                Update(item);
                return "Veri Güncellendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //db=Nike
        public string Update(T model)//Product => adidas
        {
            try
            {
                if (model.Status == CORE.CoreEntity.Enums.Status.Deleted)
                {
                    T updated = GetById(model.Id); //
                    DbEntityEntry entry = db.Entry(updated);//Nike
                    entry.CurrentValues.SetValues(model);
                    db.SaveChanges();
                    return "Veri Silindi";
                }
                else
                {
                    model.Status = CORE.CoreEntity.Enums.Status.Updated;
                    T updated = GetById(model.Id); //
                    DbEntityEntry entry = db.Entry(updated);//Nike
                    entry.CurrentValues.SetValues(model);
                    db.SaveChanges();
                    return "Veri güncellendi";
                }


            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
