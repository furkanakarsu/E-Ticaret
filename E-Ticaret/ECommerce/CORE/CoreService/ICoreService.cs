using CORE.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CORE.CoreService
{
    public interface ICoreService<T> where T:EntityRepository
    {
        //Add
        string Add(T model);
        //Add List
        string Add(List<T> models);
        //Get 
        T GetById(int id);
        //Delete
        string Remove(int id);
        //Update
        string Update(T model);
        //Get List
        List<T> GetList();
        //x=>x.
        bool Any(Expression<Func<T, bool>> exp);
        List<T> GetDefault(Expression<Func<T, bool>> exp);


    }
}
